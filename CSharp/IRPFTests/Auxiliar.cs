using IRPF.Lib.Helpers;
using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IRPF.Tests
{
    public class Auxiliar
    {
        internal static void _main(string[] args)
        {
            //testeCarrega_ArquivoDEC();
            //testeCarrega_ArquivoMapeamentos();
            testeProcuraOcorrenciasExemplos();

            Console.WriteLine("Fim");
            Console.ReadKey();
        }
        private static void testeProcuraOcorrenciasExemplos()
        {
            var files = Directory.GetFiles("Exemplo");
            //var regs = files
            //    .SelectMany(f => File.ReadLines(f))
            //    .GroupBy(o => o.Substring(0, 2))
            //    .Select(o => new { Id = o.Key, lines = o.ToArray(), qtd = o.Count() })
            //    .OrderByDescending(o => o.qtd)
            //    .ToArray();

            //var txt = string.Join(Environment.NewLine, regs.Select(o => string.Format("{0} => {1}", o.Id, o.qtd)));

            var lines0 = File.ReadAllLines(files[0]);
            lines0 = lines0;
            bool a = checkHashLine(lines0[1]); // o Header não carrega
        }
        private static bool checkHashLine(string line)
        {
            // Migrado para 'Hash.Valida_NRControle'

            var lineToCheck = line.Substring(0, line.Length - 10);
            var hashToCheck = line.Substring(line.Length - 10);

            // vou testar os hashes mais comuns
            // Vou começar com MD5, depreciado, mas vai saber (10 caracteres hex) ...
            //var calculado = Hash.obterMd5Utf8(lineToCheck);
            // Testarei CRC pois é fácil e usado em ZIPs para detecção de rros
            var calculado = Hash.obterCrc32Utf8(lineToCheck);
            // Depois testarei a família SHA
            // 1. SHA1
            // 2. SHA256
            // ? 512 ?

            return false;
        }
        static void testeCarrega_ArquivoMapeamentos()
        {
            var map = Lib.Files.Mapeamento.fromFile("mapeamentoTxt.xml");
            var txtIrpf = map.Items.First(o => o.TipoArquivo == "ARQ_IRPF");
            var classe = geraTemplateClasse(txtIrpf["18"]);
            classe = classe;
        }
        private static string geraTemplateClasse(Lib.Files.MapeamentoDeclaracaoTXTRegistro item)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < item.Campos.Length; i++)
            {
                string nome = templateAjustaNome(item.Campos[i].Nome);
                string prefix = nome.Split('_')[0];
                var typeName = item.Campos[i].Tipo;
                var len = item.Campos[i].AtributoLen();
                var type = "string";
                if (typeName == "N" && len == "Length(13,2)") type = "decimal";

                switch (prefix)
                {
                    case "IN":
                        if (typeName == "N") type = "bool";
                        break;
                    case "CD":
                    case "QT":
                    case "NR":
                        if (typeName == "N") type = "int";
                        break;
                    case "VR":
                        break;
                    default:
                        break;
                }

                if (type == "string") // exceções
                {
                    if (typeName == "N")
                    {
                        if (len.Contains(",")) type = "decimal";
                    }
                }

                sb.AppendFormat("[Index({0}), Type(TipoRegistro.{1}), {2}]", i + 1, typeName, len);
                sb.AppendLine();

                sb.AppendFormat("public {0} {1} {{get;set;}}", type, nome);
                sb.AppendLine(); sb.AppendLine();
            }
            return sb.ToString();
        }
        private static string templateAjustaNome(string nome)
        {
            return string.Join("_", templateAjustaParteNome(nome.Split('_')));
        }
        private static IEnumerable<string> templateAjustaParteNome(string[] partes)
        {
            foreach (var part in partes)
            {
                string txt = part;
                if (part.Length <= 2)
                {
                    yield return part;
                    continue;
                }

                txt = txt.Replace("ESPECIE", "Especie");
                txt = txt.Replace("REG", "Reg");
                txt = txt.Replace("CPF", "Cpf")
                         .Replace("CNPJ", "Cnpj");
                txt = txt.Replace("RENDTO", "Rendto")
                         .Replace("REND", "Rend");
                txt = txt.Replace("CONTRIB", "Contrib") // junto pra forçar ordem
                         .Replace("TRIB", "Trib");
                txt = txt.Replace("DESCRICAO", "Descricao")
                         .Replace("DESC", "Desc");
                txt = txt.Replace("SIMP", "Simp") // Isso bagunça com "SImp" -> Simplificado
                         .Replace("IMPOSTO", "Imposto")
                         .Replace("IMP", "Imp"); // junto pra forçar ordem
                txt = txt.Replace("BASE", "Base");
                txt = txt.Replace("CALCULO", "Calculo")
                         .Replace("CALC", "Calc");
                txt = txt.Replace("DEVIDO", "Devido");
                txt = txt.Replace("COMP", "Comp");
                txt = txt.Replace("LEI", "Lei");
                txt = txt.Replace("MUNICIPIO", "Municipio");
                txt = txt.Replace("FONTE", "Fonte");
                txt = txt.Replace("LEAO", "Leao");
                txt = txt.Replace("FUNDO", "Fundo");
                txt = txt.Replace("REDUC", "Reduc");
                txt = txt.Replace("RESTIT", "Restit")
                         .Replace("REST", "Rest")
                         .Replace("RES", "Res");  // junto pra forçar ordem
                txt = txt.Replace("TITULAR", "Titular").Replace("TIT", "Tit");
                txt = txt.Replace("DEPENDENTES", "Dependentes")
                         .Replace("DEPENDENTE", "Dependente")
                         .Replace("DEPENDEN", "Dependen")
                         .Replace("DEPEND", "Depend")
                         .Replace("DEPEN", "Depen")
                         .Replace("DEP", "Dep");  // junto pra forçar ordem
                txt = txt.Replace("DESP", "Desp");
                txt = txt.Replace("BENEFIC", "Benefic")
                         .Replace("BENEF", "Benef");
                txt = txt.Replace("PAGADORA", "Pagadora")
                         .Replace("PAGAR", "Pagar")
                         .Replace("PGTO", "Pgto")
                         .Replace("PAGTO", "Pagto");
                txt = txt.Replace("ALIQUOTA", "Aliquota")
                         .Replace("ALIQ", "Aliq")  // junto pra forçar ordem
                         .Replace("QUOTAS", "Quotas")
                         .Replace("QUOTA", "Quota");
                txt = txt.Replace("ISENTOS", "Isentos")
                         .Replace("ISENTO", "Isento");
                txt = txt.Replace("EXCLUSIVO", "Exclusivo");
                txt = txt.Replace("TOTAL", "Total").Replace("TOT", "Tot");
                txt = txt.Replace("RURAL", "Rural");
                txt = txt.Replace("GANHO", "Ganho");
                txt = txt.Replace("LIQUIDO", "Liquido");
                txt = txt.Replace("BENS", "Bens");
                txt = txt.Replace("VALOR", "Valor");
                txt = txt.Replace("ANO", "Ano");
                txt = txt.Replace("NAO", "Nao");
                txt = txt.Replace("SUB", "Sub");
                txt = txt.Replace("EXTERIOR", "Exterior")
                         .Replace("EXT", "Ext");
                txt = txt.Replace("SUSP", "Susp");
                txt = txt.Replace("DIFERIDO", "Diferido");
                txt = txt.Replace("TRANSPORTE", "Transporte");
                txt = txt.Replace("DIVIDA", "Divida");
                txt = txt.Replace("JUDIC", "Judic");
                txt = txt.Replace("ANTERIOR", "Anterior")
                         .Replace("ANT", "Ant");
                txt = txt.Replace("ATUAL", "Atual");
                txt = txt.Replace("EFETIVA", "Efetiva");
                txt = txt.Replace("CONTROLE", "Controle");
                txt = txt.Replace("DOACAO", "Doacao")
                         .Replace("DOACOES", "Doacoes");
                txt = txt.Replace("CAMPANHA", "Campanha");
                txt = txt.Replace("EXCLUSIVO", "Exclusivo")
                         .Replace("EXCLUS", "Exclus");
                txt = txt.Replace("CHAVE", "Chave");
                txt = txt.Replace("DEC", "Dec");
                txt = txt.Replace("TIPO", "Tipo");
                txt = txt.Replace("NOME", "Nome");
                txt = txt.Replace("PENSAO", "Pensao");
                txt = txt.Replace("PRIVADA", "Privada");
                txt = txt.Replace("TERC", "Terc");
                txt = txt.Replace("JUR", "Jur");
                txt = txt.Replace("MEDIC", "Medic");
                txt = txt.Replace("INST", "Inst");
                txt = txt.Replace("PARC", "Parc");
                txt = txt.Replace("DEDUT", "Dedut");
                txt = txt.Replace("SALARIO", "Salario");
                txt = txt.Replace("RECEB", "Receb");
                txt = txt.Replace("PREVIDENCIA", "Previdencia");
                txt = txt.Replace("COMUNICACAO", "Comunicacao");
                txt = txt.Replace("SAIDA", "Saida");
                txt = txt.Replace("COD", "Cod");

                yield return txt;
            }
        }
        static void testeCarrega_ArquivoDEC()
        {
            string path = "Exemplo\\37___-IRPF-A-2019-2018-ORIGI.DBK";// "Exemplo\\11111111030-IRPF-A-2020-2019-ORIGI.DBK";//"Exemplo\\11___-IRPF-A-2020-2019-ORIGI.DEC";
            var dec = Lib.Files.DEC_Intermediate.FromFile(path);

            dec = dec;
        }
        static void testeCarrega_REG_17(string[] args)
        {
            string path = "Exemplo\\10___-IRPF-A-2020-2019-ORIGI.DEC";
            var lines = File.ReadAllLines(path);

            var decExemplo = new Lib.Classes.R17_DemaisRendimentosImpostoPago();
            var result = decExemplo.Deserialize(lines[2]);

            using (var ms = new MemoryStream())
            {
                var sw = new StreamWriter(ms);
                decExemplo.Serialize(sw);

                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                var l2 = sr.ReadLine();

                if (l2 != lines[2]) throw new Exception("Fuck");
            }
            Console.ReadKey();
        }
        static void testeCarrega_REG_16(string[] args)
        {
            string path = "Exemplo\\11111111030-IRPF-A-2020-2019-ORIGI.DBK";//"Exemplo\\11___-IRPF-A-2020-2019-ORIGI.DEC";
            var lines = File.ReadAllLines(path);

            var decExemplo = new Lib.Classes.R16_Declarante();
            var result = decExemplo.Deserialize(lines[1]);

            using (var ms = new MemoryStream())
            {
                var sw = new StreamWriter(ms);
                decExemplo.Serialize(sw);

                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                var l2 = sr.ReadLine();

                if (l2 != lines[1]) throw new Exception("Fuck");
            }
            Console.ReadKey();
        }
        static void testeCarrega_REG_IR(string[] args)
        {
            string path = "Exemplo\\11111111030-IRPF-A-2020-2019-ORIGI.DBK";//"Exemplo\\11___-IRPF-A-2020-2019-ORIGI.DEC";
            var lines = File.ReadAllLines(path);

            var decExemplo = new Lib.Classes.IR_RegistroHeader();
            var result = decExemplo.Deserialize(lines[0]);

            using (var ms = new MemoryStream())
            {
                var sw = new StreamWriter(ms);
                decExemplo.Serialize(sw);

                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                var l2 = sr.ReadLine();

                if (l2 != lines[0]) throw new Exception("Fuck");

            }
            Console.ReadKey();
        }
        static void testeSerializacao()
        {
            var tSer = new testeSerializable()
            {
                Campo1 = "A",
                Campo2 = "B",
                Campo3 = "C",
                Campo4 = "D",
                Pular = 1,
            };

            var data = tSer.ReadObject();

            using (var ms = new MemoryStream())
            {
                var sw = new StreamWriter(ms);
                tSer.Serialize(sw);

                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                Console.WriteLine(sr.ReadToEnd());
            }

        }
    }
}
