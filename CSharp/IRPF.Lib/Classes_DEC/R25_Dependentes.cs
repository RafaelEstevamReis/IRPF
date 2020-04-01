using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R25_Dependentes : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(5)]
        public int NR_Chave { get; set; }

        [Index(4), Type(TipoRegistro.C), Length(2)]
        public string CD_Depend { get; set; }

        [Index(5), Type(TipoRegistro.C), Length(60)]
        public string NM_Depend { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(8)]
        public string DT_Nascim { get; set; }

        [Index(7), Type(TipoRegistro.C), Length(11)]
        public string NI_Depend { get; set; }

        [Index(8), Type(TipoRegistro.C), Length(1)]
        public string IN_Saida { get; set; }

        [Index(9), Type(TipoRegistro.C), Length(11)]
        public string NR_NitPisPasep { get; set; }

        [Index(10), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}
