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
            if (!DEC_Intermediate.ValidaNomeArquivo(PathArquivoDEC)) throw new InvalidOperationException("Nome inválido para o arquivo");
            bool algumErrado = false;
            var lines = File.ReadAllLines(PathArquivoDEC);

            int idxIR = 0; // fixo
            int idxR9 = -1; // não sei se tem

            for (int i = 1; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("R9"))
                {
                    idxR9 = i;
                    continue; // não checa
                }
                // Para cada linha, o Checksum tá no final

                string lineSemHash = lines[i].Substring(0, lines[i].Length - 10);
                string hashLido = lines[i].Substring(lines[i].Length - 10);

                string hashCalculado = Lib.Helpers.Hash.obterCrc32Utf8(lineSemHash);

                if (hashCalculado != hashLido)
                {
                    algumErrado = true;
                    lines[i] = lineSemHash + hashCalculado;
                }

            }

            return algumErrado;
        }
    }
}
