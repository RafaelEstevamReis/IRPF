
using System.Collections.Generic;
namespace IRPF.Lib.Declaracao
{
    public class Pagamentos : IRPFBase
    {
        private DeclaracaoIRPF declaracaoIRPF;

        public Pagamentos() { } // Serialização
        public Pagamentos(DeclaracaoIRPF declaracaoIRPF)
        {
            this.declaracaoIRPF = declaracaoIRPF;
        }

        public PagamentosItens[] Itens { get; set; }
    }
}
