
namespace IRPF.Lib.Declaracao
{
    public class RendimentosIsentos : IRPFBase
    {
        private DeclaracaoIRPF declaracaoIRPF;
        public RendimentosIsentos() { } // Serialização
        public RendimentosIsentos(DeclaracaoIRPF declaracaoIRPF)
        {
            this.declaracaoIRPF = declaracaoIRPF;
        }
    }
}
