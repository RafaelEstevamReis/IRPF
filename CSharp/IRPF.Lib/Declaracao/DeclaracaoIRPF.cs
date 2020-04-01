﻿
using IRPF.Lib.Helpers;
using System;
namespace IRPF.Lib.Declaracao
{
    public class DeclaracaoIRPF : IRPFBase
    {
        public DeclaracaoIRPF() { } // Serialização
        public DeclaracaoIRPF(Identificador id)
        {
            this.IdentificadorDeclaracao = id;
            this.CopiaIdentificador = id;

            instanciaAtributos();
        }
        private void instanciaAtributos()
        {
            this.Contribuinte = new Contribuinte(IdentificadorDeclaracao);
            this.Pagamentos = new Pagamentos(this);
            this.RendPJ = new RendimentosPJ(IdentificadorDeclaracao);
            this.RendPJComExigibilidade = new RendimentosPJComExigibilidade(IdentificadorDeclaracao);
            this.Espolio = new Espolio(IdentificadorDeclaracao);
            this.ImpostoPago = new ImpostoPago();
            this.Dependentes = new Dependentes(Contribuinte);
            this.RendaVariavel = new RendaVariavel();
            this.Alimentandos = new Alimentandos();
            this.Bens = new Bens();
            this.Dividas = new Dividas();
            this.AtividadeRural = new AtividadeRural();
            this.GanhosDeCapital = new GanhosCapital();
            this.MoedaEstrangeira = new MoedaEstrangeira();
            this.RendPFTitular = new RendimentosPF();
            this.RendPFDependente = new RendimentosPFDependente();
            this.RendIsentos = new RendimentosIsentos(this);
            this.RendTributacaoExclusiva = new RendimentosTributacaoExclusiva(this);
            this.Comparativo = new Comparativo();
            this.Resumo = new Resumo(IdentificadorDeclaracao, Contribuinte);
            this.Doacoes = new Doacoes();
            this.ModeloSimplificada = new ModeloSimplificada(this);
            this.ModeloCompleta = new ModeloCompleta(this);
            this.ModeloBase = ModeloCompleta;
        }

        public Identificador IdentificadorDeclaracao { get; set; }
        public Identificador CopiaIdentificador { get; set; }
        public Contribuinte Contribuinte { get; set; }
        public Pagamentos Pagamentos { get; set; }
        public RendimentosPJ RendPJ { get; set; }
        public RendimentosPJComExigibilidade RendPJComExigibilidade { get; set; }
        public Espolio Espolio { get; set; }
        public ImpostoPago ImpostoPago { get; set; }
        public Dependentes Dependentes { get; set; }
        public RendaVariavel RendaVariavel { get; set; }
        public Alimentandos Alimentandos { get; set; }
        public Bens Bens { get; set; }
        public Dividas Dividas { get; set; }
        public AtividadeRural AtividadeRural { get; set; }
        public GanhosCapital GanhosDeCapital { get; set; }
        public MoedaEstrangeira MoedaEstrangeira { get; set; }
        public RendimentosPF RendPFTitular { get; set; }
        public RendimentosPFDependente RendPFDependente { get; set; }
        public RendimentosIsentos RendIsentos { get; set; }
        public RendimentosTributacaoExclusiva RendTributacaoExclusiva { get; set; }
        public Comparativo Comparativo { get; set; }
        public Resumo Resumo { get; set; }
        public Doacoes Doacoes { get; set; }

        public ModeloSimplificada ModeloSimplificada
        {
            get
            {
                return ModeloBase as ModeloSimplificada; // NULL se não for
            }
            set
            {
                ModeloBase = value;
            }
        }
        public ModeloCompleta ModeloCompleta
        {
            get
            {
                return ModeloBase as ModeloCompleta; // NULL se não for
            }
            set
            {
                ModeloBase = value;
            }
        }

        public ModeloDeclaracao ModeloBase { get; set; }

        public static DeclaracaoIRPF fromArquivoDEC(Files.DEC_Intermediate dec)
        {
            #region Identificador
            var ide = new Identificador()
            {
                CPF = dec.Header.CPF_Contribuinte,
                Retificadora = dec.Header.ehRetificadora(),
                Nome = dec.Header.NR_Contribuinte,
                Exercicio = dec.Header.Exercicio,
                Tipo = dec.Header.ehCompleta() ? Identificador.TipoDeclaracao.Completa : Identificador.TipoDeclaracao.Simplificada,
                EnderecoDiferente = dec.Header.IN_MudaEndereco,
                EnderecoMACRede = dec.Header.ENDERECO_MAC,
                NumeroReciboAnterior = dec.Header.NR_ReciboUltimaDecExAnterior,
                NumeroReciboRetificadora = dec.Header.NR_ReciboUltimaDecExAtual // Não tenho certeza
            };
            #endregion
            var irpf = new DeclaracaoIRPF(ide);
            #region Contribuinte
            irpf.Contribuinte = new Contribuinte()
            {
                DataNascimento = Datas.Parse(dec.Declarante.DT_Nascim),
                TituloEleitor = dec.Declarante.NR_TituloEleitor,
                DoencaDeficiencia = dec.Declarante.ehDoencaDeficiencia(),
                ConjugueCompanheiro = dec.Declarante.ehConjugue(),
                CpfConjuge = dec.Declarante.NR_CpfConjugue,
                Exterior = dec.Declarante.CD_EX != "",
                TipoLogradouro = 0, // Lookup por nome
                Logradouro = dec.Declarante.NM_Logradouro,
                Numero = dec.Declarante.NR_Numero,
                Complemento = dec.Declarante.NM_Complemento,
                Bairro = dec.Declarante.NM_Bairro,
                UF = 0,  // Lookup dec.Declarante.SG_UF
                Municipio = Convert.ToInt32(dec.Declarante.COD_Municipio),
                Cidade = dec.Declarante.NM_Municipio,
                Cep = dec.Declarante.NR_CEP,
                DDD = dec.Declarante.NR_DDDTelefone,
                Telefone = dec.Declarante.NR_Telefone,
                DDDCelular = dec.Declarante.NR_DDDCelular,
                Celular = dec.Declarante.NR_Celular,
                LogradouroExt = "",
                NumeroExt = "",
                ComplementoExt = "",
                BairroExt = "",
                CidadeExt = "",
                CodigoExterior = 0,// "",
                Pais = Convert.ToInt32(dec.Declarante.CD_Pais),
                CepExt = "",

                EMail = dec.Declarante.NM_EMail,
                NitPisPasep = dec.Declarante.NR_NitPisPasep,
                NaturezaOcupacao = Convert.ToInt32(dec.Declarante.CD_Natur),
                OcupacaoPrincipal = Convert.ToInt32(dec.Declarante.CD_Ocup),
                RegistroProfissional = dec.Declarante.NR_Registroprofissional,
            };
            #endregion
            #region Modelo Declaracao
            if (ide.Tipo == Identificador.TipoDeclaracao.Simplificada)
            {
                irpf.ModeloSimplificada = new ModeloSimplificada(irpf)
                {
                    // Base
                    ImpostoDevido = dec.TotaisDeclaracaoSimplificada.VR_ImpDevido,
                    BaseCalculo = dec.TotaisDeclaracaoSimplificada.VR_BaseCalc,
                    SaldoImpostoPagar = dec.TotaisDeclaracaoSimplificada.VR_ImpPagar,
                    ImpostoRestituir = dec.TotaisDeclaracaoSimplificada.VR_ImpRestit,
                    RendRecebidoExterior = 0,//R22.VR_EXTER ?
                    TotalRendRecebidosMaisExterior = 0, // ?
                    TotalLivroCaixa = 0,// ?
                    TotalDoacoesCampanhasEleitorais = dec.TotaisDeclaracaoSimplificada.VR_DoacoesCampanha,
                    // Simples
                    RendRecebidoPJTitular = dec.TotaisDeclaracaoSimplificada.VR_TotRendTribPJTitular,
                    RendRecebidoPJDependentes = dec.TotaisDeclaracaoSimplificada.VR_RendTribDependente,
                    RendRecebidoPFEXT_TIT = dec.TotaisDeclaracaoSimplificada.VR_RendPFExt,
                    RendRecebidoPFEXT_DEP = dec.TotaisDeclaracaoSimplificada.VR_RendPFExtDepen,
                    ResultadoTributavelAR = dec.TotaisDeclaracaoSimplificada.VR_ResNaoTrib_AR,
                    TotalResultadosTributaveis = 0, // ?
                    DescontoSimplificado = dec.TotaisDeclaracaoSimplificada.VR_DescImp, // ? Sei não...
                    ImpostoRetidoFonteTitular = dec.TotaisDeclaracaoSimplificada.VR_TotFonteTitular,
                    ImpostoRetidoFonteDependentes = dec.TotaisDeclaracaoSimplificada.VR_ImpostoDependente,
                    CarneLeao = dec.TotaisDeclaracaoSimplificada.VR_Leao,
                    ImpostoComplementar = dec.TotaisDeclaracaoSimplificada.VR_ImpComp,
                    ImpostoRetidoFonteLei11033 = dec.TotaisDeclaracaoSimplificada.VR_IRFonteLei11033,
                    RendIsentosNaoTributaveis = dec.TotaisDeclaracaoSimplificada.VR_TotIsento,
                    RendSujeitoTribExclusiva = dec.TotaisDeclaracaoSimplificada.VR_TotRendExclusTitular,
                    BensDireitosExercicioAnterior = dec.TotaisDeclaracaoSimplificada.VR_TotBensAnoBaseAnterior,
                    BensDireitosExercicioAtual = dec.TotaisDeclaracaoSimplificada.VR_TotBensAnoBase,
                    DividasExercicioAnterior = dec.TotaisDeclaracaoSimplificada.VR_TotDividaAnoBaseAnterior,
                    DividasExercicioAtual = dec.TotaisDeclaracaoSimplificada.VR_TotDividaAnoBase,
                    TotalImpostoRetidoNaFonte = dec.TotaisDeclaracaoSimplificada.VR_Imposto,
                };
            }
            else
            {
                irpf.ModeloCompleta= new ModeloCompleta(irpf)
                   {
                       // Base
                       ImpostoDevido = dec.TotaisDeclaracao.VR_ImpDev,
                       BaseCalculo = dec.TotaisDeclaracao.VR_BaseCalc,
                       SaldoImpostoPagar = dec.TotaisDeclaracao.VR_ImpPagar,
                       ImpostoRestituir = dec.TotaisDeclaracao.VR_ImpRest,
                       RendRecebidoExterior = 0,// ?
                       TotalRendRecebidosMaisExterior = 0, // ?
                       TotalLivroCaixa = dec.TotaisDeclaracao.VR_LivCaix, // ?
                       TotalDoacoesCampanhasEleitorais = dec.TotaisDeclaracao.VR_DoacoesCampanha,
                       // Completa
                   };
            }
            #endregion

            return irpf;
        }
    }
}
