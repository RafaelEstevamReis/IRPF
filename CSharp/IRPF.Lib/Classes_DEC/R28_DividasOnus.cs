using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R28_DividasOnus : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(2)]
        public int CD_Div { get; set; }

        [Index(4), Type(TipoRegistro.C), Length(512)]
        public string TX_Div { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Anter { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Atual { get; set; }

        [Index(7), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Pgto_Anual { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}
