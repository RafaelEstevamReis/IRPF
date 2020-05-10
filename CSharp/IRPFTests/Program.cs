using System;
using System.Linq;

namespace IRPF.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para que mais de um possa fazer testes, ocu gerar um novo arquivo "Auxiliar.cs" e ignorá-lo no Commit
            Auxiliar._main(args);

            Console.WriteLine("Fim");
            Console.ReadKey();
        }

        static void Exemplo_Manipula_ArquivoDEC()
        {
            // Carrega arquivo DEC de exemplo
            string pathLeitura = "Exemplo\\22222222303-IRPF-A-2020-2019-ORIGI.DBK";
            string pathEscrita = "Teste\\22222222303-IRPF-A-2020-2019-ORIGI.DBK";
            var dec = Lib.Files.DEC_Intermediate.FromFile(pathLeitura);

            // Valores esperados para o arquivo de exemplo do commit df31f61
            // IR HASH: 0021677088
            // IR NR_C: 4183433249
            Console.WriteLine("Verifica NR_HASH: " + dec.Header.NR_Hash);
            Console.WriteLine("Verifica NR_CONTROLE: " + dec.Header.NR_Controle);

            Console.Write("Novo Nome: ");
            string nome = Console.ReadLine();

            // Seta campos
            dec.Header.NN_Nome =
                dec.Declarante.NM_Nome = nome.ToUpper();
            // Recaclula o que for necessário (trabalho em progresso)
            dec.TotalizaDeclaracao();

            // Grava arquivo 
            Lib.Files.DEC_Intermediate.GravarArquivoDecBackup(dec, pathEscrita);
        }
    }

}