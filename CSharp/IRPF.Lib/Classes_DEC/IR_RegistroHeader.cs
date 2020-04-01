using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class IR_RegistroHeader : IFixedLenLine
    {
        public enum CodigoReceitaNet
        {
            Ajuste = 2900,
            Saida = 2920,
            Unkown = 3000,
        }
        public enum ResultadoImposto
        {
            SemImposto = 0,
            ComImpostoPagar = 1,
            ComImpostoRestituir = 2,
            ComImpostoPagarDebitoAutomatico = 3,
        }
        public enum PlataformaPgd
        {
            IRPF_Windows = 1,
            IRPF_Java = 2,
            Retificadora = 3,
            M_IRPF = 4,
            IRPF_ONLINE = 5
        }
        public enum Seguranca
        {
            Retificadora = 0,
            OriginalSemNumero = 1,
            OriginalComNumero = 2,
            CertificadaDigitalmente = 3,
        }
        public enum OpcaoTributacaoRRA
        {
            Ajsute = 0,
            Exclusiva = 1
        }
        public enum InicioDeclaracao
        {
            PGD = 1,
            M_IRPF = 2,
            M_IRPF_OnlineECac = 3,
            Retificadora = 4,
            IRPF_Online_SemECac = 5,
            IRPF_Online_Certificado = 6,
            IRPF_Online_CodigoAcesso = 7,
            IRPF_Online_ECac_Certificado = 8,
            IRPF_Online_ECac_CodigoAcesso = 9,
        }

        [Index(1), Type(TipoRegistro.C), Length(8)]
        public string Sistema { get; set; }
        [Index(2), Type(TipoRegistro.N), Length(4)]
        public int Exercicio { get; set; }
        [Index(3), Type(TipoRegistro.N), Length(4)]
        public int AnoBase { get; set; }
        [Index(4), Type(TipoRegistro.N), Length(4)]
        public CodigoReceitaNet Codigo_ReceitaNet { get; set; }
        [Index(5), Type(TipoRegistro.C), Length(1)]
        public string IN_Retificadora { get; set; }
        [Index(6), Type(TipoRegistro.C), Length(11)]
        public string CPF_Contribuinte { get; set; }
        [Index(7), Type(TipoRegistro.C), Length(3)]
        public string FILLER0 { get; set; }
        [Index(8), Type(TipoRegistro.N), Length(1)]
        public int TipoNI { get; set; }
        [Index(9), Type(TipoRegistro.N), Length(3)]
        public int NR_Versao { get; set; }
        [Index(10), Type(TipoRegistro.C), Length(60)]
        public string NN_Nome { get; set; }
        [Index(11), Type(TipoRegistro.C), Length(2)]
        public string SG_UF { get; set; }
        [Index(12), Type(TipoRegistro.C), Length(10)]
        public string NR_Hash { get; set; }
        [Index(13), Type(TipoRegistro.N), Length(1)]
        public bool Certificavel { get; set; }
        [Index(14), Type(TipoRegistro.N), Length(8)]
        public string DT_Nasc { get; set; }
        [Index(15), Type(TipoRegistro.C), Length(1)]
        public string IN_Completa { get; set; }
        [Index(16), Type(TipoRegistro.N), Length(1)]
        public ResultadoImposto IN_ResultadoImposto { get; set; }
        [Index(17), Type(TipoRegistro.C), Length(1)]
        public string IN_Gerada { get; set; }
        [Index(18), Type(TipoRegistro.C), Length(10)]
        public string NR_ReciboUltimaDecExAtual { get; set; }
        [Index(19), Type(TipoRegistro.N), Length(1)]
        public PlataformaPgd IN_PlataformaPgd { get; set; }
        [Index(20), Type(TipoRegistro.C), Length(14)]
        public string Nome_SO { get; set; }
        [Index(21), Type(TipoRegistro.C), Length(7)]
        public string Versao_SO { get; set; }
        [Index(22), Type(TipoRegistro.C), Length(9)]
        public string Versao_JVM { get; set; }
        [Index(23), Type(TipoRegistro.C), Length(10)]
        public string NR_ReciboDeclaracaoTransmitida { get; set; }
        [Index(24), Type(TipoRegistro.N), Length(4)]
        public int Cod_Municipio { get; set; }
        [Index(25), Type(TipoRegistro.C), Length(11)]
        public string NR_Conj { get; set; }
        [Index(26), Type(TipoRegistro.N), Length(1)]
        public bool IN_EntregaObrigatoria { get; set; }
        [Index(27), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ImpDevido { get; set; }
        [Index(28), Type(TipoRegistro.C), Length(10)]
        public string NR_ReciboUltimaDecExAnterior { get; set; }
        [Index(29), Type(TipoRegistro.N), Length(1)]
        public Seguranca IN_Seguranca { get; set; }
        [Index(30), Type(TipoRegistro.N), Length(2)]
        public string IN_ImpostoPago_8 { get; set; } // Não faço ideia do que seja
        [Index(31), Type(TipoRegistro.N), Length(1)]
        public int IN_ImpostoAntecipado_11 { get; set; } // Não faço ideia do que seja
        [Index(32), Type(TipoRegistro.N), Length(1)]
        public bool IN_MudaEndereco { get; set; }
        [Index(33), Type(TipoRegistro.C), Length(8)]
        public string NR_CEP { get; set; }
        [Index(34), Type(TipoRegistro.N), Length(1)]
        public bool IN_DebitoPrimeiraCota { get; set; }
        [Index(35), Type(TipoRegistro.N), Length(3)]
        public int NR_Banco { get; set; }
        [Index(36), Type(TipoRegistro.N), Length(4)]
        public int NR_Agencia { get; set; }
        [Index(37), Type(TipoRegistro.C), Length(1)]
        public string FILLER1 { get; set; }
        [Index(38), Type(TipoRegistro.N), Length(8)]
        public string DataTransitoJulgadoLavratura { get; set; }
        [Index(39), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_SomaImpostoPagar { get; set; }

        [Index(40), Type(TipoRegistro.N), Length(1)]
        public OpcaoTributacaoRRA IN_OpcaoAjusteBeneficiarioUmRRA { get; set; }
        [Index(41), Type(TipoRegistro.C), Length(11)]
        public string CPF_BeneficiarioUmRRA { get; set; }
        [Index(42), Type(TipoRegistro.N), Length(1)]
        public OpcaoTributacaoRRA IN_OpcaoAjusteBeneficiarioDoisRRA { get; set; }
        [Index(43), Type(TipoRegistro.C), Length(11)]
        public string CPF_BeneficiarioDoisRRA { get; set; }
        [Index(44), Type(TipoRegistro.N), Length(1)]
        public OpcaoTributacaoRRA IN_OpcaoAjusteBeneficiarioTresRRA { get; set; }
        [Index(45), Type(TipoRegistro.C), Length(11)]
        public string CPF_BeneficiarioTresRRA { get; set; }
        [Index(46), Type(TipoRegistro.N), Length(1)]
        public OpcaoTributacaoRRA IN_OpcaoAjusteBeneficiarioQuatroRRA { get; set; }
        [Index(47), Type(TipoRegistro.C), Length(11)]
        public string CPF_BeneficiarioQuatroRRA { get; set; }

        [Index(48), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_DoacaoECA { get; set; }
        [Index(49), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_DoacaoIdoso { get; set; }

        [Index(50), Type(TipoRegistro.C), Length(14)]
        public string NR_BaseFonteMaior { get; set; }
        [Index(51), Type(TipoRegistro.C), Length(14)]
        public string NR_BaseFonteDois { get; set; }
        [Index(52), Type(TipoRegistro.C), Length(14)]
        public string NR_BaseFonteTres { get; set; }
        [Index(53), Type(TipoRegistro.C), Length(14)]
        public string NR_BaseFonteQuatro { get; set; }

        [Index(54), Type(TipoRegistro.C), Length(11)]
        public string NR_CPFDepeRendMaior { get; set; }
        [Index(55), Type(TipoRegistro.N), Length(8)]
        public string DT_NasDepeRendMaior { get; set; }
        [Index(56), Type(TipoRegistro.C), Length(11)]
        public string NR_CPFDepeRendDois { get; set; }
        [Index(57), Type(TipoRegistro.N), Length(8)]
        public string DT_NasDepeRendDois { get; set; }
        [Index(58), Type(TipoRegistro.C), Length(11)]
        public string NR_CPFDepeRendTres { get; set; }
        [Index(59), Type(TipoRegistro.N), Length(8)]
        public string DT_NasDepeRendTres { get; set; }
        [Index(60), Type(TipoRegistro.C), Length(11)]
        public string NR_CPFDepeRendQuatro { get; set; }
        [Index(61), Type(TipoRegistro.N), Length(8)]
        public string DT_NasDepeRendQuatro { get; set; }
        [Index(62), Type(TipoRegistro.C), Length(11)]
        public string NR_CPFDepeRendCinco { get; set; }
        [Index(63), Type(TipoRegistro.N), Length(8)]
        public string DT_NasDepeRendCinco { get; set; }
        [Index(64), Type(TipoRegistro.C), Length(11)]
        public string NR_CPFDepeRendSeis { get; set; }
        [Index(65), Type(TipoRegistro.N), Length(8)]
        public string DT_NasDepeRendSeis { get; set; }

        [Index(66), Type(TipoRegistro.C), Length(14)]
        public string NR_BaseBenefDespMedMaior { get; set; }
        [Index(67), Type(TipoRegistro.C), Length(14)]
        public string NR_BaseBenefDespMedDois { get; set; }
        [Index(68), Type(TipoRegistro.C), Length(11)]
        public string NR_CPFDestPensaoAlimentMaior { get; set; }
        [Index(69), Type(TipoRegistro.C), Length(11)]
        public string NR_CPFInventariante { get; set; }
        [Index(70), Type(TipoRegistro.C), Length(40)]
        public string NM_Municipio { get; set; }
        [Index(71), Type(TipoRegistro.C), Length(60)]
        public string NR_Contribuinte { get; set; }
        [Index(72), Type(TipoRegistro.C), Length(11)]
        public string FILLER2 { get; set; }
        [Index(73), Type(TipoRegistro.C), Length(12)]
        public string ENDERECO_MAC { get; set; } // Verificado e bate na versão 2020
        [Index(74), Type(TipoRegistro.C), Length(8)]
        public string DT_CondNaoResidente { get; set; }
        [Index(75), Type(TipoRegistro.C), Length(11)]
        public string NR_CpfProcurador { get; set; }
        [Index(76), Type(TipoRegistro.N), Length(3)]
        public int IN_CritObrigat { get; set; }
        [Index(77), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalRendTribPfPjTitDep { get; set; } // Verificado e bate na versão 2020
        [Index(78), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_PrevComplementar1 { get; set; }
        [Index(79), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_PrevComplementar2 { get; set; }
        [Index(80), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalIsentos { get; set; }
        [Index(81), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalExclusivo { get; set; }
        [Index(82), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalPagamentos { get; set; }  // Verificado e bate na versão 2020
        [Index(83), Type(TipoRegistro.C), Length(13)]
        public string NR_Conta { get; set; }
        [Index(84), Type(TipoRegistro.C), Length(2)]
        public string NR_DVConta { get; set; }
        [Index(85), Type(TipoRegistro.N), Length(1)]
        public bool IN_DVContaRevalidar { get; set; }
        [Index(86), Type(TipoRegistro.N), Length(2)]
        public int CD_NaturezaOcupacao { get; set; }  // Verificado e bate na versão 2020
        [Index(87), Type(TipoRegistro.C), Length(11)]
        public string NR_CpfEmpregadaDomesticaMaior { get; set; }
        [Index(88), Type(TipoRegistro.C), Length(11)]
        public string NR_NitEmpregadaDomesticaMaior { get; set; }
        [Index(89), Type(TipoRegistro.C), Length(11)]
        public string NR_CpfEmpregadaDomesticaDois { get; set; }
        [Index(90), Type(TipoRegistro.C), Length(11)]
        public string NR_NitEmpregadaDomesticaDois { get; set; }
        [Index(91), Type(TipoRegistro.C), Length(11)]
        public string NR_CpfEmpregadaDomesticaTres { get; set; }
        [Index(92), Type(TipoRegistro.C), Length(11)]
        public string NR_NitEmpregadaDomesticaTres { get; set; }
        [Index(93), Type(TipoRegistro.N), Length(1)]
        public InicioDeclaracao TP_Iniciada { get; set; }
        [Index(94), Type(TipoRegistro.N), Length(1)]
        public bool IN_UtilizouPGD { get; set; }
        [Index(95), Type(TipoRegistro.N), Length(1)]
        public bool IN_UtilizouAPP { get; set; }
        [Index(96), Type(TipoRegistro.N), Length(1)]
        public bool IN_UtilizouOnline { get; set; }
        [Index(97), Type(TipoRegistro.N), Length(1)]
        public bool IN_UtilizouRascunho { get; set; }
        [Index(98), Type(TipoRegistro.N), Length(1)]
        public bool IN_UtilizouPrePreenchida { get; set; }
        [Index(99), Type(TipoRegistro.N), Length(1)]
        public bool IN_UtilizouAssistidaFontePagadora { get; set; }
        [Index(100), Type(TipoRegistro.N), Length(1)]
        public bool IN_UtilizouAssistidaPlanoSaude { get; set; }
        [Index(101), Type(TipoRegistro.N), Length(1)]
        public bool IN_UtilizouSalvarRecuperarOnline { get; set; }
        [Index(102), Type(TipoRegistro.N), Length(1)]
        public bool IN_UtilizouTransmitida { get; set; }
        [Index(103), Type(TipoRegistro.C), Length(14)]
        public string NR_PagamentoDedutivelMaiorUm { get; set; }
        [Index(104), Type(TipoRegistro.C), Length(14)]
        public string NR_PagamentoDedutivelMaiorDois { get; set; }
        [Index(105), Type(TipoRegistro.C), Length(14)]
        public string NR_PagamentoDedutivelMaiorTres { get; set; }
        [Index(106), Type(TipoRegistro.C), Length(14)]
        public string NR_PagamentoDedutivelMaiorQuatro { get; set; }
        [Index(107), Type(TipoRegistro.C), Length(14)]
        public string NR_PagamentoDedutivelMaiorCinco { get; set; }
        [Index(108), Type(TipoRegistro.C), Length(14)]
        public string NR_PagamentoDedutivelMaiorSeis { get; set; }
        [Index(109), Type(TipoRegistro.C), Length(14)]
        public string NR_PagamentoFUNPRESP { get; set; }
        [Index(110), Type(TipoRegistro.C), Length(3)]
        public string VersaoTestePGD { get; set; }
        [Index(111), Type(TipoRegistro.C), Length(13)]
        public string NR_TituloEleitor { get; set; }
        [Index(112), Type(TipoRegistro.C), Length(10)]
        public string NR_Controle { get; set; }
        
        public string GerarNomeArquivo(bool ehBackup)
        {
            // Exemplo de Nome:
            // 11111111030-IRPF-A-2020-2019-ORIGI.DBK
            // 1: CPF
            // 2: IRPF (fixo ?)
            // 3: "A"  (fixo ?)
            // 4: Exercício
            // 5: Ano base
            // Se é retificadora ou é a original
            StringBuilder sb = new StringBuilder();

            sb.Append(CPF_Contribuinte );
            sb.Append("-IRPF-A-" ); // ??
            sb.AppendFormat("{0:0000}-{1:0000}-", Exercicio, AnoBase);

            if(ehRetificadora())
                sb.Append( "RETIF");
            else
                sb.Append("ORIGI");

            if (ehBackup)
                sb.Append( ".DBK" );
            else
                sb.Append(".DEC");

            return sb.ToString();
        }

        public bool ehCompleta()
        {
            // Usar o mesmo do ehRetificadora
            return IN_Completa == "1";
        }
        public bool ehRetificadora()
        {
            // " " é false (verificado IRPF 2020)
            // "1" é true  (verificado IRPF 2020)

            // Vou presumir que "0" é false e usar o "1" como TRUE

            return IN_Retificadora == "1";
        }
    }
}