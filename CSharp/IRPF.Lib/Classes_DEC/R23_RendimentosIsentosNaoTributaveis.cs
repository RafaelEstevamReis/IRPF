using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R23_RendimentosIsentosNaoTributaveis : IFixedLenLine
    {
        public R23_RendimentosIsentosNaoTributaveis() { }
        public R23_RendimentosIsentosNaoTributaveis(IR_RegistroHeader header)
        {
            this.NR_Controle = "";
            this.NR_Reg = 23;
            this.NR_Cpf = header.CPF_Contribuinte;
        }

        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(4)]
        public int CD_Isento { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Valor { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}
