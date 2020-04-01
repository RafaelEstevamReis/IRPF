using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R16_Declarante : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public string NR_Reg { get; set; }
        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_CPF { get; set; }
        [Index(3), Type(TipoRegistro.C), Length(60)]
        public string NM_Nome { get; set; }
        [Index(4), Type(TipoRegistro.C), Length(15)]
        public string TIP_Logradouro { get; set; }
        [Index(5), Type(TipoRegistro.C), Length(40)]
        public string NM_Logradouro { get; set; }
        [Index(6), Type(TipoRegistro.C), Length(6)]
        public string NR_Numero { get; set; }
        [Index(7), Type(TipoRegistro.C), Length(21)]
        public string NM_Complemento { get; set; }
        [Index(8), Type(TipoRegistro.C), Length(19)]
        public string NM_Bairro { get; set; }
        [Index(9), Type(TipoRegistro.C), Length(9)]
        public string NR_CEP { get; set; }
        [Index(10), Type(TipoRegistro.N), Length(4)]
        public string COD_Municipio { get; set; }
        [Index(11), Type(TipoRegistro.C), Length(40)]
        public string NM_Municipio { get; set; }
        [Index(12), Type(TipoRegistro.C), Length(2)]
        public string SG_UF { get; set; } /* Verificado na versão 2020 */
        [Index(13), Type(TipoRegistro.C), Length(3)]
        public string CD_EX { get; set; }
        [Index(14), Type(TipoRegistro.C), Length(3)]
        public string CD_Pais { get; set; }
        [Index(15), Type(TipoRegistro.C), Length(90)]
        public string NM_EMail { get; set; } /* Verificado na versão 2020 */
        [Index(16), Type(TipoRegistro.C), Length(11)]
        public string NR_NitPisPasep { get; set; }
        [Index(17), Type(TipoRegistro.C), Length(11)]
        public string NR_CpfConjugue { get; set; }
        [Index(18), Type(TipoRegistro.C), Length(4)]
        public string NR_DDDTelefone { get; set; }
        [Index(19), Type(TipoRegistro.C), Length(9)]
        public string Filler { get; set; }
        [Index(20), Type(TipoRegistro.N), Length(8)]
        public string DT_Nascim { get; set; }
        [Index(21), Type(TipoRegistro.C), Length(13)]
        public string NR_TituloEleitor { get; set; }
        [Index(22), Type(TipoRegistro.C), Length(3)]
        public string CD_Ocup { get; set; }
        //[Index(23), Type(TipoRegistro.C), Length(150)]
        //public string NM_Ocup { get; set; }
        [Index(24), Type(TipoRegistro.C), Length(2)]
        public string CD_Natur { get; set; }
        //[Index(25), Type(TipoRegistro.C), Length(130)]
        //public string NM_Natur { get; set; }
        [Index(26), Type(TipoRegistro.N), Length(1)]
        public int NR_Cotas { get; set; }
        [Index(27), Type(TipoRegistro.C), Length(1)]
        public string IN_Completa { get; set; }
        [Index(28), Type(TipoRegistro.C), Length(1)]
        public string IN_Retificadora { get; set; }
        [Index(29), Type(TipoRegistro.C), Length(1)]
        public string IN_Gerado { get; set; }
        [Index(30), Type(TipoRegistro.C), Length(1)]
        public string IN_Endereco { get; set; }
        [Index(31), Type(TipoRegistro.C), Length(12)]
        public string NR_ControleOriginal { get; set; }
        [Index(32), Type(TipoRegistro.C), Length(3)]
        public string NR_Banco { get; set; }
        [Index(33), Type(TipoRegistro.C), Length(4)]
        public string NR_Agencia { get; set; }
        [Index(34), Type(TipoRegistro.C), Length(1)]
        public string IN_DoencaDeficiencia { get; set; }
        [Index(35), Type(TipoRegistro.C), Length(1)]
        public string IN_Preenchida { get; set; }
        [Index(36), Type(TipoRegistro.C), Length(13)]
        public string NR_Conta { get; set; }
        [Index(37), Type(TipoRegistro.C), Length(2)]
        public string NR_DVConta { get; set; }
        [Index(38), Type(TipoRegistro.C), Length(1)]
        public string IN_DebitoAutomatico { get; set; }
        [Index(39), Type(TipoRegistro.C), Length(1)]
        public string IN_DebitoPrimeiraCota { get; set; }
        [Index(40), Type(TipoRegistro.C), Length(14)]
        public string NR_FontePrincipal { get; set; } /* Verificado na versão 2020 */
        [Index(41), Type(TipoRegistro.C), Length(10)]
        public string NR_ReciboUltimaDecAnoAnterior { get; set; }
        [Index(42), Type(TipoRegistro.C), Length(1)]
        public string IN_TipoDeclaracao { get; set; }
        [Index(43), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpfprocurador { get; set; }
        [Index(44), Type(TipoRegistro.C), Length(20)]
        public string NR_Registroprofissional { get; set; }
        [Index(45), Type(TipoRegistro.C), Length(2)]
        public string NR_DDDCelular { get; set; }
        [Index(46), Type(TipoRegistro.C), Length(9)]
        public string NR_Celular { get; set; }
        [Index(47), Type(TipoRegistro.C), Length(1)]
        public string IN_Conjugue { get; set; }
        [Index(48), Type(TipoRegistro.C), Length(11)]
        public string NR_Telefone { get; set; }
        [Index(49), Type(TipoRegistro.C), Length(10)]
        public string NR_Controle { get; set; } /* Verificado na versão 2020 */

        public bool ehDoencaDeficiencia()
        {
            // Usar o mesmo do Header.ehRetificadora
            return IN_Completa == "1";
        }
        public bool ehConjugue()
        {
            // Usar o mesmo do Header.ehRetificadora
            return IN_Conjugue == "1";
        }
        public bool ehMudouEndereco()
        {
            // Usar o mesmo do Header.ehRetificadora
            return IN_Endereco == "1";
            // Repete no Header
        }
    }
}
