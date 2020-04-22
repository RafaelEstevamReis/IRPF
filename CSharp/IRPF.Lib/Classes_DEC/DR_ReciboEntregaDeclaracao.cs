using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class DR_ReciboEntregaDeclaracao : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.C), Length(2)]
        public string NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.C), Length(3)]
        public string FILLER { get; set; }

        [Index(4), Type(TipoRegistro.C), Length(1)]
        public string IN_Completa { get; set; }

        [Index(5), Type(TipoRegistro.C), Length(60)]
        public string NM_Nome { get; set; }

        [Index(6), Type(TipoRegistro.C), Length(15)]
        public string TIP_Logra { get; set; }

        [Index(7), Type(TipoRegistro.C), Length(40)]
        public string NM_Logra { get; set; }

        [Index(8), Type(TipoRegistro.C), Length(6)]
        public string NR_Numero { get; set; }

        [Index(9), Type(TipoRegistro.C), Length(21)]
        public string NM_Complem { get; set; }

        [Index(10), Type(TipoRegistro.C), Length(19)]
        public string NM_Bairro { get; set; }

        [Index(11), Type(TipoRegistro.C), Length(9)]
        public string NR_CEP { get; set; }

        [Index(12), Type(TipoRegistro.N), Length(4)]
        public int CD_Municip { get; set; }

        [Index(13), Type(TipoRegistro.C), Length(40)]
        public string NM_Municip { get; set; }

        [Index(14), Type(TipoRegistro.C), Length(2)]
        public string SG_UF { get; set; }

        [Index(15), Type(TipoRegistro.C), Length(100)]
        public string NM_EMail { get; set; }

        [Index(16), Type(TipoRegistro.C), Length(4)]
        public string FILLER2 { get; set; }

        [Index(17), Type(TipoRegistro.C), Length(8)]
        public string FILLER3 { get; set; }

        [Index(18), Type(TipoRegistro.C), Length(4)]
        public string NR_DDD_Telefone { get; set; }

        [Index(19), Type(TipoRegistro.C), Length(9)]
        public string FILLER4 { get; set; }

        [Index(20), Type(TipoRegistro.C), Length(1)]
        public string IN_Retificadora { get; set; }

        [Index(21), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotTrib { get; set; }

        [Index(22), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpDev { get; set; }

        [Index(23), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpRest { get; set; }

        [Index(24), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpPagar { get; set; }

        [Index(25), Type(TipoRegistro.N), Length(1)]
        public int NR_Quotas { get; set; }

        [Index(26), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Quota { get; set; }

        [Index(27), Type(TipoRegistro.N), Length(3)]
        public int NR_Banco { get; set; }

        [Index(28), Type(TipoRegistro.N), Length(4)]
        public int NR_Agencia { get; set; }

        [Index(29), Type(TipoRegistro.C), Length(1)]
        public string FILLER5 { get; set; }

        [Index(30), Type(TipoRegistro.N), Length(1)]
        public bool IN_DebitoPrimeiraQuota { get; set; }

        [Index(31), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_GCImpostoPago { get; set; }

        [Index(32), Type(TipoRegistro.C), Length(13)]
        public string NR_Conta { get; set; }

        [Index(33), Type(TipoRegistro.C), Length(2)]
        public string NR_DV_Conta { get; set; }

        [Index(34), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_VCMoedaEst { get; set; }

        [Index(35), Type(TipoRegistro.C), Length(11)]
        public string NR_Telefone { get; set; }

        [Index(36), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}
