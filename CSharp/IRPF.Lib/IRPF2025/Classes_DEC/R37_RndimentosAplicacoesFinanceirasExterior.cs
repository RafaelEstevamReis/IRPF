using IRPF.Lib.Serialization;
using System;

namespace IRPF.Lib.IRPF2025.Classes_DEC
{
    public class R37_RndimentosAplicacoesFinanceirasExterior : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(5)]
        public int NR_Chave_Bem { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(5)]
        public int NR_Ordem { get; set; }

        [Index(5), Type(TipoRegistro.C), Length(1)]
        public int IN_Tipo { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_GANHO_PREJUIZO { get; set; }

        [Index(7), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_IMPOSTO_DEVIDO { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_IMPOSTO_PAGO_EXTERIOR_BRASIL { get; set; }

        [Index(9), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_BASE_CALCULO { get; set; }

        [Index(10), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_SALDO { get; set; }

        [Index(11), Type(TipoRegistro.N), Length(2)]
        public int CD_GRUPO_BEM { get; set; }
        
        [Index(12), Type(TipoRegistro.N), Length(2)]
        public int CD_BEM { get; set; }

        [Index(13), Type(TipoRegistro.N), Length(10)] // ?
        public string NR_Controle { get; set; }
    }
}
