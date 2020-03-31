
namespace IRPF.Lib.Declaracao
{
    public class RendimentosPJ
    {
        private Identificador IdentificadorDeclaracao;
        public RendimentosPJ() { } // Serialização
        public RendimentosPJ(Identificador IdentificadorDeclaracao)
        {
            this.IdentificadorDeclaracao = IdentificadorDeclaracao;
        }
    }
}
