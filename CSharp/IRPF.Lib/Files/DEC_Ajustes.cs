using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Files
{
    public class DEC_Ajustes
    {
        public static bool CorrigeChecksums(string PathArquivoDEC)
        {
            bool algumErrado = false;

            if (!DEC_Intermediate.ValidaNomeArquivo(PathArquivoDEC)) throw new InvalidOperationException("Nome inválido para o arquivo");
            string nomeArquivoSemExtensao = new FileInfo(PathArquivoDEC).Name.Split('.')[0];
            var lines = File.ReadAllLines(PathArquivoDEC);

            int idxIR = 0; // fixo
            int idxR9 = -1; // não sei se tem

            // Hash da declaração '2'
            //   4122185819

            // Arruma todos os campos, exceto o HEADER e o TRAILLER
            var linesCalcular = lines
                .Where(l => !l.StartsWith("HR")
                         && !l.StartsWith("DR")
                         && !l.StartsWith("R9"))
                .ToArray();
            for (int i = 0; i < linesCalcular.Length; i++)
            {
                if (linesCalcular[i].StartsWith("IR"))
                {
                    // zera HASH
                    linesCalcular[i] = linesCalcular[i].Substring(0, 101)
                                       + "0000000000"
                                       + linesCalcular[i].Substring(111, 872)
                                       + "0000000000";
                    continue; // mantém zero
                }
                // Para cada linha, o Checksum tá no final

                string lineSemHash = linesCalcular[i].Substring(0, linesCalcular[i].Length - 10);
                string hashLido = linesCalcular[i].Substring(linesCalcular[i].Length - 10);

                string hashCalculado = Lib.Helpers.Hash.obterCrc32Utf8(lineSemHash);

                if (hashCalculado != hashLido)
                {
                    algumErrado = true;
                    linesCalcular[i] = lineSemHash + hashCalculado;
                }
            }

            var crcArquivo = Lib.Helpers.Hash.obterCrc32Utf8Linhas(linesCalcular);
            // Arruma Hash do Header
            {
                linesCalcular[0] = linesCalcular[0].Substring(0, 101)
                                           + crcArquivo
                                           + linesCalcular[0].Substring(111);
                string lineSemHash = linesCalcular[0].Substring(0, linesCalcular[0].Length - 10);
                string hashLido = linesCalcular[0].Substring(linesCalcular[0].Length - 10);

                string hashCalculado = Lib.Helpers.Hash.obterCrc32Utf8(lineSemHash);

                linesCalcular[0] = lineSemHash + hashCalculado;
            }
            throw new Exception("Não funciona ¬¬'");
            return algumErrado;
        }
    }
}
