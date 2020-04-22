using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class HR_HeaderRecibo : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.C), Length(2)]
        public string NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.C), Length(3)]
        public string FILLER { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}
