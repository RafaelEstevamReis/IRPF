using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R18_TotaisDeclaracaoDescontoSimplificado : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public string NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_CPF { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendTrib { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_DescImp { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_BaseCalc { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpDevido { get; set; }

        [Index(7), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpComp { get; set; }

        [Index(9), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Leao { get; set; }

        [Index(10), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_IRFonteLei11033 { get; set; }

        [Index(11), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpRestit { get; set; }

        [Index(12), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpPagar { get; set; }

        [Index(13), Type(TipoRegistro.N), Length(1)]
        public string NR_Quotas { get; set; }

        [Index(14), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Quota { get; set; }

        [Index(15), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotIsento { get; set; }

        [Index(16), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotExclusivo { get; set; }

        [Index(17), Type(TipoRegistro.N), Length(13, 2)]
        public decimal FILLER0 { get; set; }

        [Index(18), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendTribDependente { get; set; }

        [Index(19), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpostoDependente { get; set; }

        [Index(20), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpPagarEspecie { get; set; }

        [Index(21), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendTribPJTitular { get; set; }

        [Index(22), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendTribARural { get; set; }

        [Index(23), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotFonteTitular { get; set; }

        [Index(24), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotBensAnoBaseAnterior { get; set; }

        [Index(25), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotBensAnoBase { get; set; }

        [Index(26), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendIsentoTitular { get; set; }

        [Index(27), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendIsentoDependentes { get; set; }

        [Index(28), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendExclusTitular { get; set; }

        [Index(29), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendExclusDependentes { get; set; }

        [Index(30), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ResNaoTrib_AR { get; set; }

        [Index(31), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotDividaAnoBaseAnterior { get; set; }

        [Index(32), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotDividaAnoBase { get; set; }

        [Index(33), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotIRFonteLei11033 { get; set; }

        [Index(34), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_SubTotalIsentoTransporte { get; set; }

        [Index(35), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_SubTotalExclusivoTransporte { get; set; }

        [Index(36), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_GanhoLiquidoRVTransporte { get; set; }

        [Index(37), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendIsentoGCTransporte { get; set; }

        [Index(38), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendPFExt { get; set; }

        [Index(39), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendPFExtDepen { get; set; }

        [Index(40), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_DoacoesCampanha { get; set; }

        [Index(41), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendPJExibSuspTitular { get; set; }

        [Index(42), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendPJExibSuspdepen { get; set; }

        [Index(43), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotDepJudicTitular { get; set; }

        [Index(44), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotDepJudicDependen { get; set; }

        [Index(45), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendACTit { get; set; }

        [Index(46), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotIRFACTit { get; set; }

        [Index(47), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotImpostoRRATit { get; set; }

        [Index(48), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendACDep { get; set; }

        [Index(49), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotIRFACDep { get; set; }

        [Index(50), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotImpostoRRADep { get; set; }

        [Index(51), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotImpostoDevido { get; set; }

        [Index(52), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpostoDiferidoGCAP { get; set; }

        [Index(53), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpostoDevidoGCAP { get; set; }

        [Index(54), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpostoGanhoLiqRVAR { get; set; }

        [Index(55), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpostoDevidoGCME { get; set; }

        [Index(56), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpExt { get; set; }

        [Index(57), Type(TipoRegistro.N), Length(5, 2)]
        public decimal VR_AliquotaEfetiva { get; set; }

        [Index(58), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}
