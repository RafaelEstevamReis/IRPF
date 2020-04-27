namespace IRPF.Lib.Declaracao
{
    public class RendimentosPJItem : IRPFBase
    {
        public RendimentosPJItem() { } // Serialização

        public string NomeFontePagadora { get; set; }
        public string NIFontePagadora { get; set; }
        public decimal rendRecebidoPJ { get; set; }
        public decimal contribuicaoPrevOficial { get; set; }
        public decimal impostoRetidoFonte { get; set; }
        public decimal decimoTerceiro { get; set; }
        public decimal IRRFDecimoTerceiro { get; set; }
    }
}
