
namespace IRPF.Lib.Declaracao
{
    public class Dependentes
    {
        private Contribuinte Contribuinte;
        public Dependentes() { } // Serialização
        public Dependentes(Contribuinte Contribuinte)
        {
            this.Contribuinte = Contribuinte;
        }
    }
}
