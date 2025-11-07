namespace IRPF.Lib.IRPF2025.Declaracao
{
    public class RendimentosPJComExigibilidade : IRPFBase
    {
        private Identificador IdentificadorDeclaracao;
        public RendimentosPJComExigibilidade() { } // Serialização
        public RendimentosPJComExigibilidade(Identificador IdentificadorDeclaracao)
        {
            this.IdentificadorDeclaracao = IdentificadorDeclaracao;
        }

        internal static RendimentosPJComExigibilidade importarDec(Identificador ide, Files.DEC2025_Intermediate dec)
        {
            throw new System.NotImplementedException();
        }
    }
}
