
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
    }
}
