using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R45_RecebidosAcumuladamente : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(2)]
        public int CD_RRA_Titular { get; set; }

        [Index(4), Type(TipoRegistro.C), Length(14)]
        public string NR_Pagador { get; set; }

        [Index(5), Type(TipoRegistro.C), Length(60)]
        public string NM_Pagador { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Rendto { get; set; }

        [Index(7), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Contrib { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Pensao { get; set; }

        [Index(9), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto { get; set; }

        [Index(10), Type(TipoRegistro.N), Length(2)]
        public int NR_MES_Recebimento { get; set; }

        [Index(11), Type(TipoRegistro.C), Length(6)]
        public string FILLER { get; set; }

        [Index(12), Type(TipoRegistro.N), Length(1)]
        public string OPCAO_Tributacao { get; set; }

        [Index(13), Type(TipoRegistro.N), Length(4, 1)]
        public decimal NUM_Meses { get; set; }

        [Index(14), Type(TipoRegistro.N), Length(13, 2)]
        public decimal Imposto_RRA { get; set; }

        [Index(15), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Isento_65 { get; set; }

        [Index(16), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Valor_Tributavel { get; set; }

        [Index(17), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}
