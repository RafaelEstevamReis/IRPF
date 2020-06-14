using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R27_BensDireitos : IFixedLenLine
    {
        public R27_BensDireitos() { }
        public R27_BensDireitos(IR_RegistroHeader header)
        {
            this.NR_Controle = "";
            this.NR_Reg = 27;
            this.NR_Cpf = header.CPF_Contribuinte;
        }

        public enum UnidadeMedida
        {
            MetroQuadrado = 0,
            Hectare = 1,
            Vazio = 2
        }

        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(2)]
        public int CD_BEM { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(1)]
        public bool IN_Exterior { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(3)]
        public int CD_PAIS { get; set; }

        [Index(6), Type(TipoRegistro.C), Length(512)]
        public string TX_BEM { get; set; }

        [Index(7), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ANTER { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ATUAL { get; set; }

        [Index(9), Type(TipoRegistro.C), Length(40)]
        public string NM_LOGRA { get; set; }

        [Index(10), Type(TipoRegistro.C), Length(6)]
        public string NR_NUMERO { get; set; }

        [Index(11), Type(TipoRegistro.C), Length(40)]
        public string NM_CompLEM { get; set; }

        [Index(12), Type(TipoRegistro.C), Length(40)]
        public string NM_BAIRRO { get; set; }

        [Index(13), Type(TipoRegistro.C), Length(9)]
        public string NR_CEP { get; set; }

        [Index(14), Type(TipoRegistro.C), Length(2)]
        public string SG_UF { get; set; }

        [Index(15), Type(TipoRegistro.N), Length(4)]
        public int CD_MUNICIP { get; set; }

        [Index(16), Type(TipoRegistro.C), Length(40)]
        public string NM_MUNICIP { get; set; }

        [Index(17), Type(TipoRegistro.N), Length(1)]
        public string NM_IND_Reg_IMOV { get; set; }

        [Index(18), Type(TipoRegistro.C), Length(40)]
        public string MATRIC_IMOV { get; set; }

        [Index(19), Type(TipoRegistro.C), Length(40)]
        public string filler { get; set; }

        [Index(20), Type(TipoRegistro.N), Length(11, 1)]
        public decimal AREA { get; set; }

        [Index(21), Type(TipoRegistro.N), Length(1)]
        public UnidadeMedida NM_UNID { get; set; }

        [Index(22), Type(TipoRegistro.C), Length(60)]
        public string NM_CARTORIO { get; set; }

        [Index(23), Type(TipoRegistro.N), Length(5)]
        public int NR_CHAVE_BEM { get; set; }

        [Index(24), Type(TipoRegistro.N), Length(8)]
        public string DT_AQUISICAO { get; set; }

        [Index(25), Type(TipoRegistro.C), Length(20)]
        public string FILLER { get; set; }

        [Index(26), Type(TipoRegistro.N), Length(8)]
        public int NR_NIRF { get; set; }

        [Index(27), Type(TipoRegistro.C), Length(30)]
        public string NR_RENAVAN { get; set; }

        [Index(28), Type(TipoRegistro.C), Length(30)]
        public string NR_Dep_AVIACAO_CIVIL { get; set; }

        [Index(29), Type(TipoRegistro.C), Length(30)]
        public string NR_CAPITANIA_PORTOS { get; set; }

        [Index(30), Type(TipoRegistro.N), Length(4)]
        public int NR_AGENCIA { get; set; }

        [Index(31), Type(TipoRegistro.C), Length(13)]
        public string NR_CONTA { get; set; }

        [Index(32), Type(TipoRegistro.C), Length(2)]
        public string NR_DV_CONTA { get; set; }

        [Index(33), Type(TipoRegistro.C), Length(14)]
        public string NM_CpfCnpj { get; set; }

        [Index(34), Type(TipoRegistro.C), Length(30)]
        public string NR_IPTU { get; set; }

        [Index(35), Type(TipoRegistro.N), Length(3)]
        public int NR_BANCO { get; set; }

        [Index(36), Type(TipoRegistro.C), Length(1)]
        public string IN_TIPO_BENEFIC { get; set; }

        [Index(37), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf_BENEFIC { get; set; }

        [Index(38), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}