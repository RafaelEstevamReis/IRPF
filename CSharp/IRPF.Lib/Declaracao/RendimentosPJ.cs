﻿
namespace IRPF.Lib.Declaracao
{
    public class RendimentosPJ : IRPFBase
    {
        private Identificador IdentificadorDeclaracao;
        public RendimentosPJ() { } // Serialização
        public RendimentosPJ(Identificador IdentificadorDeclaracao)
        {
            this.IdentificadorDeclaracao = IdentificadorDeclaracao;
        }
    }
}