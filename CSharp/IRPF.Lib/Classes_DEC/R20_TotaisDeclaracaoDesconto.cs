using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R20_TotaisDeclaracaoDesconto : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendJur { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendFisicExt_Tit { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendFisicExt_Dep { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ResAR { get; set; }

        [Index(7), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotTrib { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_PrevOF { get; set; }

        [Index(9), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotPrivada { get; set; }

        [Index(10), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Depen { get; set; }

        [Index(11), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_DespInst { get; set; }

        [Index(12), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_DespMedic { get; set; }

        [Index(13), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Pensao { get; set; }

        [Index(14), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Pensao_Cartorio { get; set; }

        [Index(15), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_LivCaix { get; set; }

        [Index(16), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Deduc { get; set; }

        [Index(17), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_BaseCalc { get; set; }

        [Index(18), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto { get; set; }

        [Index(19), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_DedImposto { get; set; }

        [Index(20), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpDev { get; set; }

        [Index(21), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ContPatronal { get; set; }

        [Index(22), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpDev2 { get; set; }

        [Index(23), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpDev3 { get; set; }

        [Index(24), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpFonte { get; set; }

        [Index(25), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_CarneLeao { get; set; }

        [Index(26), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpCompL { get; set; }

        [Index(27), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpExt { get; set; }

        [Index(28), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_IRFonteLei11033 { get; set; }

        [Index(29), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotImpPago { get; set; }

        [Index(30), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpRest { get; set; }

        [Index(31), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpPagar { get; set; }

        [Index(32), Type(TipoRegistro.N), Length(1)]
        public int NR_Quotas { get; set; }

        [Index(33), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Quota { get; set; }

        [Index(34), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_BensAnt { get; set; }

        [Index(35), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_BensAtual { get; set; }

        [Index(36), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_DividaAnt { get; set; }

        [Index(37), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_DividaAtual { get; set; }

        [Index(38), Type(TipoRegistro.N), Length(13, 2)]
        public decimal FILLER { get; set; }

        [Index(39), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotIsentos { get; set; }

        [Index(40), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotExclus { get; set; }

        [Index(41), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpGC { get; set; }

        [Index(42), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotIRFonteLei11033 { get; set; }

        [Index(43), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpRV { get; set; }

        [Index(44), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_RendJurDependente { get; set; }

        [Index(45), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpFonteDependente { get; set; }

        [Index(46), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpPagoVCBens { get; set; }

        [Index(47), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpPagoVCEspecie { get; set; }

        [Index(48), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendIsentosTitular { get; set; }

        [Index(49), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendIsentosDependente { get; set; }

        [Index(50), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendExclTitular { get; set; }

        [Index(51), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendExclDependente { get; set; }

        [Index(52), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_DoacoesCampanha { get; set; }

        [Index(53), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendPJ_EXIB_SuspTitular { get; set; }

        [Index(54), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRendPJ_EXIB_SuspDependen { get; set; }

        [Index(55), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotDepJudic_Titular { get; set; }

        [Index(56), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotDepJudic_Dependen { get; set; }

        [Index(57), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRend_AC_Tit { get; set; }

        [Index(58), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Tot_PrevOfc_AC_Tit { get; set; }

        [Index(59), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Tot_PensAli_AC_Tit { get; set; }

        [Index(60), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Tot_IRF_AC_Tit { get; set; }

        [Index(61), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Tot_Imposto_RRA_Tit { get; set; }

        [Index(62), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotRend_AC_Dep { get; set; }

        [Index(63), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Tot_PrevOfc_AC_Dep { get; set; }

        [Index(64), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Tot_PensAli_AC_Dep { get; set; }

        [Index(65), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Tot_IRF_AC_Dep { get; set; }

        [Index(66), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Tot_Imposto_RRA_Dep { get; set; }

        [Index(67), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto_Diferido_GCap { get; set; }

        [Index(68), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto_Devido_GCap { get; set; }

        [Index(69), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto_GanhoLiq_RVar { get; set; }

        [Index(70), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto_Devido_GCME { get; set; }

        [Index(71), Type(TipoRegistro.N), Length(5, 2)]
        public decimal VR_Aliquota_Efetiva { get; set; }

        [Index(72), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}