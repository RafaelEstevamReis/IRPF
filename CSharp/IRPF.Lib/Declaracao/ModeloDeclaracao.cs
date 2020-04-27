namespace IRPF.Lib.Declaracao
{
    public class ModeloDeclaracao : IRPFBase
    {
        public decimal ImpostoDevido { get; set; }
        public decimal BaseCalculo { get; set; }
        public decimal SaldoImpostoPagar { get; set; }
        public decimal ImpostoRestituir { get; set; }
        public decimal RendRecebidoExterior { get; set; }
        public decimal TotalRendRecebidosMaisExterior { get; set; }
        public decimal TotalLivroCaixa { get; set; }
        public decimal TotalDoacoesCampanhasEleitorais { get; set; }
    }
}
