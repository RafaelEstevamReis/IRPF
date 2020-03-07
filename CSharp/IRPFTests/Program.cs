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
            string path = "Exemplo\\11111111030-IRPF-A-2020-2019-ORIGI.DBK";//"Exemplo\\11___-IRPF-A-2020-2019-ORIGI.DEC";

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