
namespace IRPF.Lib.Declaracao
{
    public class ModeloSimplificada : ModeloDeclaracao
    {
        private DeclaracaoIRPF declaracaoIRPF;
        public ModeloSimplificada() { } // Serialização
        public ModeloSimplificada(DeclaracaoIRPF declaracaoIRPF)
        {
            this.declaracaoIRPF = declaracaoIRPF;
        }
    }
}
