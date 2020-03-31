
namespace IRPF.Lib.Declaracao
{
    public class PagamentosItens
    {
        public enum TipoPagamento
        {
            Titular,
            Dependente,
            Alimentando
        }
        public int Codigo { get; set; }
        public string DependenteOuAlimentando { get; set; }
        public string NomeBeneficiario { get; set; }
        public string NIBeneficiario { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ParcelaNaoDedutivel { get; set; }
        public string NITEmpregadoDomestico { get; set; }
        public TipoPagamento Tipo { get; set; }
    }
}