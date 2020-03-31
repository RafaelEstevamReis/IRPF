
namespace IRPF.Lib.Declaracao
{
    public class Contribuinte
    {
        private Identificador IdentificadorDeclaracao;

        public Contribuinte() { } // Serialização
        public Contribuinte(Identificador IdentificadorDeclaracao)
        {
            this.IdentificadorDeclaracao = IdentificadorDeclaracao;
        }
    }
}
