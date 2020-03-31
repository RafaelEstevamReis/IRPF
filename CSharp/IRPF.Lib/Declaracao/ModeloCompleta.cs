
namespace IRPF.Lib.Declaracao
{
    public class ModeloCompleta : ModeloDeclaracao
    {
        private DeclaracaoIRPF declaracaoIRPF;
        public ModeloCompleta() { } // Serialização
        public ModeloCompleta(DeclaracaoIRPF declaracaoIRPF)
        {
            this.declaracaoIRPF = declaracaoIRPF;
        }
    }
}
