using IRPF.Tests;
using System;
using System.IO;
using System.Text;
using System.Xml;

// Para que mais de um possa fazer testes, ocu gerar um novo arquivo "Auxiliar.cs" e ignorá-lo no Commit
Auxiliar._main(args);

Console.WriteLine("Fim");

void Exemplo_Manipula_ArquivoDEC()
{
    // Carrega arquivo DEC de exemplo
    string pathLeitura = "Exemplo\\22222222303-IRPF-A-2020-2019-ORIGI.DBK";
    string pathEscrita = "Teste\\22222222303-IRPF-A-2020-2019-ORIGI.DBK";
    var dec = IRPF.Lib.Files.DEC2025_Intermediate.FromFile(pathLeitura);

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
    IRPF.Lib.Files.DEC2025_Intermediate.GravarArquivoDecBackup(dec, pathEscrita);
}
void GeraDocumentacaoLayoutDadosDIRPFYYYY_xml(string arquivoXml, string arquivoMD)
{
    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

    // Leitura original como UTF-8 (com mojibake dentro)
    string corruptedText = File.ReadAllText(arquivoXml, Encoding.UTF8);
    // Reversão: 1252 bytes -> UTF-8 string
    byte[] bytes1 = Encoding.GetEncoding(1252).GetBytes(corruptedText);
    string xmlContent = Encoding.UTF8.GetString(bytes1);

    var sb = new StringBuilder();
    var settings = new XmlReaderSettings { IgnoreWhitespace = true, IgnoreComments = true };
    using (var stringReader = new StringReader(xmlContent))
    using (var reader = XmlReader.Create(stringReader, settings))
    {
        reader.ReadToFollowing("file");

        while (reader.ReadToFollowing("tipo"))
        {
            string tipoNome = reader.GetAttribute("nome");
            string tipoObs = reader.GetAttribute("obs") ?? "";

            sb.AppendLine($"## Tipo: {tipoNome}");
            if (!string.IsNullOrEmpty(tipoObs))
            {
                sb.AppendLine($"{tipoObs}");
            }
            sb.AppendLine();

            // Start table
            sb.AppendLine("| Nome | Formato | Tamanho | Observação |");
            sb.AppendLine("|------|---------|---------|------------|");

            if (reader.ReadToDescendant("campo"))
            {
                do
                {
                    string campoNome = reader.GetAttribute("nome") ?? "";
                    string formato = reader.GetAttribute("formato") ?? "";
                    string tam = reader.GetAttribute("tam") ?? "";
                    string obs = reader.GetAttribute("obs") ?? "";

                    // Remove pipes para não quebrar a tabela
                    obs = obs.Replace("|", "\\|");

                    sb.AppendLine($"| {campoNome} | {formato} | {tam} | {obs} |");
                } while (reader.ReadToNextSibling("campo"));
            }
            sb.AppendLine();
        }
    }

    File.WriteAllText(arquivoMD, sb.ToString());
}
