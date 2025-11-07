using System.Xml.Serialization;

namespace IRPF.Lib.IRPF2025.Declaracao
{
    public class Dependentes : IRPFBase
    {
        public Dependentes() { } // Serialização

        [XmlElement("item")]
        public DependentesItens[] Itens { get; set; }

        internal static Dependentes importarDec(Identificador ide, Files.DEC2025_Intermediate dec)
        {
            throw new System.NotImplementedException();
        }
    }
}
