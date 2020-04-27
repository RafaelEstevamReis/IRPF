using System.Xml.Serialization;

namespace IRPF.Lib.Declaracao
{
    public class Doacoes : IRPFBase
    {
        [XmlIgnore]
        public decimal TotalDoacoes { get; set; }
        [XmlAttribute("totalDoacoes")] // Dá treta com formato PT-BR
        public string XML_TotalDoacoes
        {
            get { return Helpers.ConversoesXML.Decimal_Get(TotalDoacoes); }
            set { TotalDoacoes = Helpers.ConversoesXML.Decimal_Set(value); }
        }

        internal static Doacoes importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            throw new System.NotImplementedException();
        }
    }
}
