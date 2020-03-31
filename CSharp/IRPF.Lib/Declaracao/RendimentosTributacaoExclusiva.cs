
namespace IRPF.Lib.Declaracao
{
    public class RendimentosTributacaoExclusiva : IRPFBase
    {
        private DeclaracaoIRPF declaracaoIRPF;
        public RendimentosTributacaoExclusiva() { } // Serialização
        public RendimentosTributacaoExclusiva(DeclaracaoIRPF declaracaoIRPF)
        {
            this.declaracaoIRPF = declaracaoIRPF;
        }
    }
}
