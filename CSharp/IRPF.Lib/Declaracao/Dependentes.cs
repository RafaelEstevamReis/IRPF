
namespace IRPF.Lib.Declaracao
{
    public class Dependentes : IRPFBase
    {
        private Contribuinte Contribuinte;
        public Dependentes() { } // Serialização
        public Dependentes(Contribuinte Contribuinte)
        {
            this.Contribuinte = Contribuinte;
        }
    }
}
