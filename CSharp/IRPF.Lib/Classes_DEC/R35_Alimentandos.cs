using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R35_Alimentandos : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(1)]
        public string IN_Residenc { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(5)]
        public int NR_Chave { get; set; }

        [Index(5), Type(TipoRegistro.C), Length(60)]
        public string NM_Nome { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(8)]
        public string DT_Nascim { get; set; }

        [Index(7), Type(TipoRegistro.C), Length(11)]
        public string NI_Alimentando { get; set; }

        [Index(8), Type(TipoRegistro.C), Length(1)]
        public string IN_Tipo_Processo { get; set; }

        [Index(9), Type(TipoRegistro.N), Length(10)]
        public int NR_Controle { get; set; }
    }
}
