using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R24_RendimentosTributacaoExclusiva : IFixedLenLine
    {
        public R24_RendimentosTributacaoExclusiva() { }
        public R24_RendimentosTributacaoExclusiva(IR_RegistroHeader Header)
        {
            this.NR_Reg = 24;
            this.NR_Cpf = Header.CPF_Contribuinte;
            this.NR_Controle = "";
        }

        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(4)]
        public int CD_Exclusivo { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Valor { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}