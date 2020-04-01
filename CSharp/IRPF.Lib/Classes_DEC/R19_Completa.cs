using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R19_Completa : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }
        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_CPF { get; set; }
        [Index(3), Type(TipoRegistro.C), Length(14)]
        public string NR_Fonte { get; set; }
        [Index(4), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpExt { get; set; }
        [Index(5), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpComp { get; set; }
        [Index(6), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_IRFonteLei11033 { get; set; }
        [Index(7), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RecEx_Tit { get; set; }
        [Index(8), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_LivCaix_Tit { get; set; }
        [Index(9), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_CarneLeao_Tit { get; set; }
        [Index(10), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RecEx_Dep { get; set; }
        [Index(11), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_LivCaix_Dep { get; set; }
        [Index(12), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_CarneLeao_Dep { get; set; }
        [Index(13), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_PrevPriv { get; set; }
        [Index(14), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Fapi { get; set; }
        [Index(15), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_PrevOfTitular { get; set; }
        [Index(16), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_PrevOfDependente { get; set; }
        [Index(17), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Total13Titular { get; set; }
        [Index(18), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Total13Dependente { get; set; }
        [Index(19), Type(TipoRegistro.N), Length(5)]
        public int NR_DependentesDespInstrucao { get; set; }
        [Index(20), Type(TipoRegistro.N), Length(5)]
        public int NR_AlimentandoDespInstrucao { get; set; }
        [Index(21), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendPF_Tit { get; set; }
        [Index(22), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendPF_Depend { get; set; }
        [Index(23), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendExt_Tit { get; set; }
        [Index(24), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendExt_Depend { get; set; }
        [Index(25), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpDevidoSemRendExt { get; set; }
        [Index(26), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_LimiteImpPagoExt { get; set; }
        [Index(27), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_AteLimiteFundPresp { get; set; }
        [Index(28), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_AcimaLimiteFundPresp { get; set; }
        [Index(29), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }






    }
}
