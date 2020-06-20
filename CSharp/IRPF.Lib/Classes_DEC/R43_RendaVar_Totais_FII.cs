using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R43_RendaVar_Totais_FII : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalANUALResULTADOLiquidoSRendAVARIAVEL_FII { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalANUALResULTADONEGATIVOMESAnterior_FII { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalANUALBaseCalculoImposto_FII { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalANUALPREJUIZOCompENSAR_FII { get; set; }

        [Index(7), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalANUALImpostoDevido_FII { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalANUALImpostoPagar_FII { get; set; }

        [Index(9), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalANUALImpostoRETIDONAFonte_FII { get; set; }

        [Index(10), Type(TipoRegistro.N), Length(10)]
        public int NR_Controle { get; set; }


    }
}