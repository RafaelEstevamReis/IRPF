
namespace IRPF.Lib.Declaracao
{
    public class Resumo
    {
        private Identificador IdentificadorDeclaracao;
        private Contribuinte Contribuinte;
        public Resumo() { } // Serialização
        public Resumo(Identificador IdentificadorDeclaracao, Contribuinte Contribuinte)
        {
            this.IdentificadorDeclaracao = IdentificadorDeclaracao;
            this.Contribuinte = Contribuinte;
        }
    }
}
