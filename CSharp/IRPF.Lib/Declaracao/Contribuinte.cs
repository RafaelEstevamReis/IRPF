
namespace IRPF.Lib.Declaracao
{
    public class Contribuinte : IRPFBase
    {
        private Identificador IdentificadorDeclaracao;

        public Contribuinte() { } // Serialização
        public Contribuinte(Identificador IdentificadorDeclaracao)
        {
            this.IdentificadorDeclaracao = IdentificadorDeclaracao;
        }
    }
}
