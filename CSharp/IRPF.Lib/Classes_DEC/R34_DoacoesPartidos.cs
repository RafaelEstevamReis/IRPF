using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R34_DoacoesPartidos : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.C), Length(14)]
        public string NR_Partido { get; set; }

        [Index(4), Type(TipoRegistro.C), Length(60)]
        public string NM_Partido { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Doacao { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}
