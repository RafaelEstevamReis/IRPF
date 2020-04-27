using System;
using System.Xml.Serialization;

namespace IRPF.Lib.Declaracao
{
    public class Alimentandos : IRPFBase
    {
        [XmlElement("item")]
        public AlimentandosItens[] Itens { get; set; }

        internal static Alimentandos importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            throw new System.NotImplementedException();
        }
    }
}
