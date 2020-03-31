
namespace IRPF.Lib.Declaracao
{
    public class Pagamentos
    {
        private DeclaracaoIRPF declaracaoIRPF;

        public Pagamentos() { } // Serialização
        public Pagamentos(DeclaracaoIRPF declaracaoIRPF)
        {
            this.declaracaoIRPF = declaracaoIRPF;
        }
    }
}
