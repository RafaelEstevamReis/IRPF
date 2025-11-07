using IRPF.Lib.Serialization;
using System;
using System.Text;

namespace IRPF.Lib.IRPF2025.Classes_DEC
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
        [Index(19), Type(TipoRegistro.C), Length(1)]
        public string FILLER1 { get; set; }
        [Index(20), Type(TipoRegistro.C), Length(14)]
        public string Nome_SO { get; set; }
        [Index(21), Type(TipoRegistro.C), Length(7)]
        public string Versao_SO { get; set; }
        [Index(22), Type(TipoRegistro.C), Length(9)] // Verificado e bate na versão 2025
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
        public string IN_ImpostoPago { get; set; } // Indicador se teve imposto pago
        [Index(31), Type(TipoRegistro.N), Length(1)]
        public int IN_ImpostoAntecipado { get; set; } // Indicador se teve imposto antecipado
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
        public string IN_SOBREPARTILHA { get; set; }
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
        public string ENDERECO_MAC { get; set; } // Verificado e bate na versão 2025
        [Index(74), Type(TipoRegistro.C), Length(8)]
        public string DT_CondNaoResidente { get; set; }
        [Index(75), Type(TipoRegistro.C), Length(11)]
        public string NR_CpfProcurador { get; set; }
        [Index(76), Type(TipoRegistro.N), Length(3)]
        public int IN_CritObrigat { get; set; }
        [Index(77), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalRendTribPfPjTitDep { get; set; }

        [Index(78), Type(TipoRegistro.C), Length(11)]
        public string FILLER3 { get; set; }
        [Index(79), Type(TipoRegistro.C), Length(1)]
        public string IN_CONFIABILIDADE { get; set; }
        [Index(80), Type(TipoRegistro.N), Length(2)]
        public int TP_INICIADA { get; set; }
        [Index(82), Type(TipoRegistro.N), Length(2)]
        public int TP_TRANSMITIDA { get; set; }
        [Index(83), Type(TipoRegistro.C), Length(11)]
        public string NR_CPF_TRANSMISSAO { get; set; }
        [Index(84), Type(TipoRegistro.N), Length(1)]
        public int IN_CPF_TRANSMISSAO_PERFIL { get; set; }

        [Index(85), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalIsentos { get; set; }
        [Index(86), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalExclusivo { get; set; }
        [Index(87), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_TotalPagamentos { get; set; }
        [Index(88), Type(TipoRegistro.C), Length(1)]
        public string IN_PROCESSO_ATUALIZACAO_BEM { get; set; }
        [Index(89), Type(TipoRegistro.C), Length(12)]
        public string FILLER4 { get; set; }

        [Index(90), Type(TipoRegistro.C), Length(2)]
        public string NR_DV_CONTA { get; set; }
        [Index(91), Type(TipoRegistro.N), Length(1)]
        public int IN_DV_CONTA { get; set; }
        [Index(92), Type(TipoRegistro.N), Length(2)]
        public int CD_NATUR { get; set; }

        [Index(93), Type(TipoRegistro.C), Length(11)]
        public string NR_CPF_EMPREGADA_DOMESTICA_MAIOR { get; set; }
        [Index(94), Type(TipoRegistro.C), Length(11)]
        public string NR_NIT_EMP_DOM_MAIOR { get; set; }

        [Index(95), Type(TipoRegistro.C), Length(11)]
        public string NR_CPF_EMPREGADA_DOMESTICA_DOIS { get; set; }
        [Index(96), Type(TipoRegistro.C), Length(11)]
        public string NR_NIT_EMP_DOM_DOIS { get; set; }

        [Index(97), Type(TipoRegistro.C), Length(11)]
        public string NR_CPF_EMPREGADA_DOMESTICA_TRES { get; set; }
        [Index(98), Type(TipoRegistro.C), Length(11)]
        public string NR_NIT_EMP_DOM_TRES { get; set; }
        [Index(99), Type(TipoRegistro.C), Length(1)]
        public string FILLER5 { get; set; }

        [Index(100), Type(TipoRegistro.C), Length(1)]
        public string IN_UTILIZOU_PGD { get; set; }
        [Index(101), Type(TipoRegistro.C), Length(1)]
        public string IN_UTILIZOU_APP { get; set; }
        [Index(102), Type(TipoRegistro.C), Length(1)]
        public string IN_UTILIZOU_ONLINE { get; set; }
        [Index(103), Type(TipoRegistro.C), Length(1)]
        public string IN_UTILIZOU_RASCUNHO { get; set; }
        [Index(104), Type(TipoRegistro.C), Length(1)]
        public string IN_UTILIZOU_PRE_PREENCHIDA { get; set; }
        [Index(105), Type(TipoRegistro.C), Length(1)]
        public string IN_UTILIZOU_ASSISTIDA_FONTE_PAGADORA { get; set; }
        [Index(106), Type(TipoRegistro.C), Length(1)]
        public string IN_UTILIZOU_ASSISTIDA_PLANO_SAUDE { get; set; }
        [Index(107), Type(TipoRegistro.C), Length(1)]
        public string IN_UTILIZOU_SALVAR_RECUPERAR_ONLINE { get; set; }
        [Index(108), Type(TipoRegistro.C), Length(1)]
        public string FILLER6 { get; set; }

        [Index(110), Type(TipoRegistro.C), Length(14)]
        public string NR_PAGAMENTO_DEDUTIVEL_MAIOR_UM { get; set; }
        [Index(111), Type(TipoRegistro.C), Length(14)]
        public string NR_PAGAMENTO_DEDUTIVEL_MAIOR_DOIS { get; set; }
        [Index(112), Type(TipoRegistro.C), Length(14)]
        public string NR_PAGAMENTO_DEDUTIVEL_MAIOR_TRES { get; set; }
        [Index(113), Type(TipoRegistro.C), Length(14)]
        public string NR_PAGAMENTO_DEDUTIVEL_MAIOR_QUATRO { get; set; }
        [Index(114), Type(TipoRegistro.C), Length(14)]
        public string NR_PAGAMENTO_DEDUTIVEL_MAIOR_CINCO { get; set; }
        [Index(115), Type(TipoRegistro.C), Length(14)]
        public string NR_PAGAMENTO_DEDUTIVEL_MAIOR_SEIS { get; set; }
        [Index(116), Type(TipoRegistro.C), Length(27)]
        public string FILLER { get; set; }

        [Index(118), Type(TipoRegistro.C), Length(1)]
        public string IN_TIPO_CONTA { get; set; }
        [Index(119), Type(TipoRegistro.C), Length(20)]
        public string NR_CONTA { get; set; }

        [Index(120), Type(TipoRegistro.C), Length(1)]
        public string IN_SOCIAL { get; set; }
        [Index(121), Type(TipoRegistro.C), Length(1)]
        public string IN_CLWEB { get; set; }
        [Index(122), Type(TipoRegistro.C), Length(1)]
        public string IN_ISENCAO_GCAP_TITULAR { get; set; }
        [Index(123), Type(TipoRegistro.C), Length(1)]
        public string IN_ISENCAO_GCAP_MAIOR { get; set; }
        [Index(124), Type(TipoRegistro.C), Length(1)]
        public string IN_ISENCAO_GCAP_DOIS { get; set; }
        [Index(125), Type(TipoRegistro.C), Length(1)]
        public string IN_ISENCAO_GCAP_TRES { get; set; }
        [Index(126), Type(TipoRegistro.C), Length(1)]
        public string IN_ISENCAO_GCAP_QUATRO { get; set; }
        [Index(127), Type(TipoRegistro.C), Length(1)]
        public string IN_ISENCAO_GCAP_CINCO { get; set; }
        [Index(128), Type(TipoRegistro.C), Length(1)]
        public string IN_ISENCAO_GCAP_SEIS { get; set; }
        [Index(130), Type(TipoRegistro.C), Length(2)]
        public string IN_FICHA_1 { get; set; }
        [Index(131), Type(TipoRegistro.C), Length(2)]
        public string IN_COD_FICHA_1 { get; set; }
        [Index(132), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_MAIOR_VALOR_1 { get; set; }
        [Index(133), Type(TipoRegistro.C), Length(2)]
        public string IN_FICHA_2 { get; set; }
        [Index(134), Type(TipoRegistro.C), Length(2)]
        public string IN_COD_FICHA_2 { get; set; }
        [Index(135), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_MAIOR_VALOR_2 { get; set; }
        [Index(136), Type(TipoRegistro.C), Length(2)]
        public string IN_FICHA_3 { get; set; }
        [Index(137), Type(TipoRegistro.C), Length(2)]
        public string IN_COD_FICHA_3 { get; set; }
        [Index(138), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_MAIOR_VALOR_3 { get; set; }
        [Index(139), Type(TipoRegistro.C), Length(2)]
        public string IN_FICHA_4 { get; set; }
        [Index(140), Type(TipoRegistro.C), Length(2)]
        public string IN_COD_FICHA_4 { get; set; }
        [Index(141), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_MAIOR_VALOR_4 { get; set; }
        [Index(142), Type(TipoRegistro.C), Length(2)]
        public string IN_FICHA_5 { get; set; }
        [Index(143), Type(TipoRegistro.C), Length(2)]
        public string IN_COD_FICHA_5 { get; set; }
        [Index(144), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_MAIOR_VALOR_5 { get; set; }
        [Index(145), Type(TipoRegistro.C), Length(2)]
        public string IN_FICHA_6 { get; set; }
        [Index(146), Type(TipoRegistro.C), Length(2)]
        public string IN_COD_FICHA_6 { get; set; }
        [Index(147), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_MAIOR_VALOR_6 { get; set; }
        [Index(148), Type(TipoRegistro.C), Length(2)]
        public string IN_FICHA_7 { get; set; }
        [Index(149), Type(TipoRegistro.C), Length(2)]
        public string IN_COD_FICHA_7 { get; set; }
        [Index(151), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_MAIOR_VALOR_7 { get; set; }
        [Index(152), Type(TipoRegistro.C), Length(2)]
        public string IN_FICHA_8 { get; set; }
        [Index(153), Type(TipoRegistro.C), Length(2)]
        public string IN_COD_FICHA_8 { get; set; }
        [Index(154), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_MAIOR_VALOR_8 { get; set; }
        [Index(155), Type(TipoRegistro.C), Length(2)]
        public string IN_FICHA_9 { get; set; }
        [Index(156), Type(TipoRegistro.C), Length(2)]
        public string IN_COD_FICHA_9 { get; set; }
        [Index(157), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_MAIOR_VALOR_9 { get; set; }
        [Index(158), Type(TipoRegistro.C), Length(2)]
        public string IN_FICHA_10 { get; set; }
        [Index(159), Type(TipoRegistro.C), Length(2)]
        public string IN_COD_FICHA_10 { get; set; }
        [Index(160), Type(TipoRegistro.C), Length(14)]
        public string CNPJ_MAIOR_VALOR_10 { get; set; }

        [Index(161), Type(TipoRegistro.C), Length(8)]
        public string DT_RETORNO_PAIS { get; set; }

        [Index(162), Type(TipoRegistro.C), Length(17)]
        public string NR_PROCESSO_ATUALIZACAO_BEM { get; set; }
        [Index(163), Type(TipoRegistro.C), Length(8)]
        public string NR_PROCESSO_ATUALIZACAO_BEM_FILLER { get; set; }
        [Index(164), Type(TipoRegistro.C), Length(3)]
        public string VERSAOTESTEPGD { get; set; }

        [Index(165), Type(TipoRegistro.C), Length(10)]
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

            sb.Append(CPF_Contribuinte);
            sb.Append("-IRPF-A-"); // ??
            sb.AppendFormat("{0:0000}-{1:0000}-", Exercicio, AnoBase);

            if (ehRetificadora())
                sb.Append("RETIF");
            else
                sb.Append("ORIGI");

            if (ehBackup)
                sb.Append(".DBK");
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