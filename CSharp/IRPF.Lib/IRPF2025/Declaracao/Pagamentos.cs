using System.Collections.Generic;
using System.Xml.Serialization;

namespace IRPF.Lib.IRPF2025.Declaracao
{
    public class Pagamentos : IRPFBase
    {
        public Pagamentos() { } // Serialização

        [XmlElement("item")]
        public PagamentosItens[] Itens { get; set; }

        internal static Pagamentos importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            throw new System.NotImplementedException();
        }
    }
}
