
using System.Collections.Generic;
namespace IRPF.Lib.Declaracao
{
    public class Pagamentos : IRPFBase
    {
        public Pagamentos() { } // Serialização

        public PagamentosItens[] Itens { get; set; }

        internal static Pagamentos importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            throw new System.NotImplementedException();
        }
    }
}
