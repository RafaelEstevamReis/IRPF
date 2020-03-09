using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            testeCarrega_ArquivoDEC();
            //testeCarrega_ArquivoMapeamentos();
            //testeProcuraOcorrenciasExemplos();

            Console.WriteLine("Fim");
            Console.ReadKey();
        }
        private static void testeProcuraOcorrenciasExemplos()
        {
            var regs = Directory.GetFiles("Exemplo")
                .SelectMany(f => File.ReadLines(f))
                .GroupBy(o => o.Substring(0, 2))
                .Select(o => new { Id = o.Key, lines = o.ToArray(), qtd = o.Count() })
                .OrderByDescending(o => o.qtd)
                .ToArray();

            var txt = string.Join(Environment.NewLine, regs.Select(o => string.Format("{0} => {1}", o.Id, o.qtd)));
            regs = regs;

            /* 27 => 22
             * 22 => 12
             * 24 =>  9
             * 89 =>  5
             * 88 =>  5
             * IR =>  4
             * 16 =>  4
             * 21 =>  4
             * T9 =>  4
             * 86 =>  4
             * 25 =>  3
             * 26 =>  3
             * 17 =>  2
             * 18 =>  2
             * HR =>  2
             * DR =>  2
             * R9 =>  2
             * 19 =>  2
             * 20 =>  2
             * 47 =>  2
             * 23 =>  2
             * 45 =>  1
             * 90 =>  1
             * 91 =>  1
             * 92 =>  1
             */
        }
        static void testeCarrega_ArquivoMapeamentos()
        {
            var map = Lib.Files.Mapeamento.fromFile("mapeamentoTxt.xml");
            var txtIrpf = map.Items.First(o => o.TipoArquivo == "ARQ_IRPF");
            txtIrpf = txtIrpf;
            var classe = geraTemplateClasse(txtIrpf["18"]);
            classe = classe;
        }
        private static string geraTemplateClasse(Lib.Files.MapeamentoDeclaracaoTXTRegistro item)
        {
            item = item;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < item.Campos.Length; i++)
            {
                var typeName = item.Campos[i].Tipo;
                var len = item.Campos[i].AtributoLen();
                var type = "string";

                if (typeName == "N" && len == "Length(13,2)") type = "decimal";

                sb.AppendFormat("[Index({0}), Type(TipoRegistro.{1}), {2}]", i + 1, typeName, len);
                sb.AppendLine();

                sb.AppendFormat("public {0} {1} {{get;set;}}", type ,item.Campos[i].Nome);
                sb.AppendLine(); sb.AppendLine();
            }
            return sb.ToString();
        }
        static void testeCarrega_ArquivoDEC()
        {
            string path = "Exemplo\\37___-IRPF-A-2019-2018-ORIGI.DBK";// "Exemplo\\11111111030-IRPF-A-2020-2019-ORIGI.DBK";//"Exemplo\\11___-IRPF-A-2020-2019-ORIGI.DEC";
            var dec = Lib.Files.DEC_Intermediate.FromFile(path);

            dec = dec;
        }        
        static void testeCarrega_REG_17(string[] args){
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

    public class testeSerializable : IFixedLenLine
    {
        [Index(0), Length(4), Type(TipoRegistro.C)]
        public string Campo1 { get; set; }
        [Index(3), Length(4), Type(TipoRegistro.C)]
        public string Campo2 { get; set; }
        [Index(2), Length(4), Type(TipoRegistro.C)]
        public object Pular { get; set; }
        [Ignore]
        public string Campo3 { get; set; }
        [Index(1), Length(4), Type(TipoRegistro.C)]
        public string Campo4 { get; set; }

    }
}