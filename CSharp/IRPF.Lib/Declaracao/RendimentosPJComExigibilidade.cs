namespace IRPF.Lib.Declaracao
{
    public class RendimentosPJComExigibilidade : IRPFBase
    {
        private Identificador IdentificadorDeclaracao;
        public RendimentosPJComExigibilidade() { } // Serialização
        public RendimentosPJComExigibilidade(Identificador IdentificadorDeclaracao)
        {
            this.IdentificadorDeclaracao = IdentificadorDeclaracao;
        }

        internal static RendimentosPJComExigibilidade importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            throw new System.NotImplementedException();
        }
    }
}
