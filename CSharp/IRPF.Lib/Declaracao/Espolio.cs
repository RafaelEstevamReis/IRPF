
namespace IRPF.Lib.Declaracao
{
    public class Espolio : IRPFBase
    {
        private Identificador IdentificadorDeclaracao;
        public Espolio() { } // Serialização
        public Espolio(Identificador IdentificadorDeclaracao)
        {
            this.IdentificadorDeclaracao = IdentificadorDeclaracao;
        }

        internal static Espolio importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            throw new System.NotImplementedException();
        }
    }
}
