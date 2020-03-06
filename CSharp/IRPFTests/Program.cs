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