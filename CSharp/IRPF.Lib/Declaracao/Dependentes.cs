
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

        internal static Dependentes importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            throw new System.NotImplementedException();
        }
    }
}
