using System;
using System.Xml.Serialization;

namespace IRPF.Lib.IRPF2025.Declaracao
{
    public class Alimentandos : IRPFBase
    {
        [XmlElement("item")]
        public AlimentandosItens[] Itens { get; set; }

        internal static Alimentandos importarDec(Identificador ide, Files.DEC2025_Intermediate dec)
        {
            throw new NotImplementedException();
        }
    }
}
