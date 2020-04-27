using System.Xml.Serialization;

namespace IRPF.Lib.Declaracao
{
    public class PagamentosItens
    {
        public enum TipoPagamento
        {
            [XmlEnum("T")]
            Titular,
            [XmlEnum("D")]
            Dependente,
            [XmlEnum("A")]
            Alimentando
        }
        [XmlAttribute("codigo")]
        public int Codigo { get; set; }
        [XmlAttribute("dependenteOuAlimentando")]
        public string DependenteOuAlimentando { get; set; }
        [XmlAttribute("nomeBeneficiario")]
        public string NomeBeneficiario { get; set; }
        [XmlAttribute("niBeneficiario")]
        public string NIBeneficiario { get; set; }
        [XmlIgnore]
        public decimal ValorPago { get; set; }
        [XmlAttribute("valorPago")] // Dá treta com formato PT-BR
        public string XML_ValorPago
        {
            get { return Helpers.ConversoesXML.Decimal_Get(ValorPago); }
            set { ValorPago = Helpers.ConversoesXML.Decimal_Set(value); }
        }
        [XmlIgnore]
        public decimal ParcelaNaoDedutivel { get; set; }
        [XmlAttribute("parcelaNaoDedutivel")] // Dá treta com formato PT-BR
        public string XML_ParcelaNaoDedutivel
        {
            get { return Helpers.ConversoesXML.Decimal_Get(ParcelaNaoDedutivel); }
            set { ParcelaNaoDedutivel = Helpers.ConversoesXML.Decimal_Set(value); }
        }
        [XmlAttribute("nitEmpregadoDomestico")]
        public string NITEmpregadoDomestico { get; set; }
        [XmlAttribute("tipo")]
        public TipoPagamento Tipo { get; set; }
    }
}
