using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R42_RendaVar_FII : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(2)]
        public int NR_MES { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ResLiquido_MES { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ResULT_NEG_MESAnt { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_BaseCalculo_MES { get; set; }

        [Index(7), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_PREJACompENSAR_MES_OPCOMUNS { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(3)]
        public string VR_Aliquota_Imposto_OPCOMUNS { get; set; }

        [Index(9), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpostoDevido_MES_OPCOMUNS { get; set; }

        [Index(10), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto_RETIDO_MESES_Anteriores { get; set; }

        [Index(11), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto_RETIDO_Fonte { get; set; }

        [Index(12), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto_RETIDO_CompENSAR { get; set; }

        [Index(13), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto_Pagar { get; set; }

        [Index(14), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpostoPAGO { get; set; }

        [Index(15), Type(TipoRegistro.C), Length(1)]
        public string E_Dependente { get; set; }

        [Index(16), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf_Depen { get; set; }

        [Index(17), Type(TipoRegistro.N), Length(10)]
        public int NR_Controle { get; set; }
    }
}