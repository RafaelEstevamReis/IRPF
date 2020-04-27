using System.Xml.Serialization;

namespace IRPF.Lib.Declaracao
{
    [XmlRoot("classe", Namespace = "http://www.receita.fazenda.gov.br/declaracao")]
    public partial class DeclaracaoIRPF : IRPFBase
    {
        // Para desserialziar:
        //  var declaracao = Serializer.DeserializeXmlFile<DeclaracaoIRPF>(caminhoArquivo);

        public DeclaracaoIRPF() { } // Serialização
        public DeclaracaoIRPF(Identificador id)
        {
            this.IdentificadorDeclaracao = id;

            instanciaAtributos();
        }
        private void instanciaAtributos()
        {
            this.Contribuinte = new Contribuinte(IdentificadorDeclaracao);
            this.Pagamentos = new Pagamentos();
            this.RendPJ = new RendimentosPJ();
            this.RendPJComExigibilidade = new RendimentosPJComExigibilidade(IdentificadorDeclaracao);
            this.Espolio = new Espolio(IdentificadorDeclaracao);
            this.ImpostoPago = new ImpostoPago();
            this.Dependentes = new Dependentes();
            this.RendaVariavel = new RendaVariavel();
            this.Alimentandos = new Alimentandos();
            this.Bens = new Bens();
            this.Dividas = new Dividas();
            this.AtividadeRural = new AtividadeRural();
            this.GanhosDeCapital = new GanhosCapital();
            this.MoedaEstrangeira = new MoedaEstrangeira();
            this.RendPFTitular = new RendimentosPF();
            this.RendPFDependente = new RendimentosPFDependente();
            this.RendIsentos = new RendimentosIsentos();
            this.RendTributacaoExclusiva = new RendimentosTributacaoExclusiva();
            this.Comparativo = new Comparativo();
            this.Resumo = new Resumo(IdentificadorDeclaracao, Contribuinte);
            this.Doacoes = new Doacoes();
            this.ModeloSimplificada = new ModeloSimplificada();
            this.ModeloCompleta = new ModeloCompleta();
            this.ModeloBase = ModeloCompleta;
        }

        [XmlElement("copiaIdentificador")]
        public Identificador IdentificadorDeclaracao { get; set; }
        [XmlElement("contribuinte")]
        public Contribuinte Contribuinte { get; set; }
        [XmlElement("pagamentos")]
        public Pagamentos Pagamentos { get; set; }
        [XmlElement("rendPJ")]
        public RendimentosPJ RendPJ { get; set; }
        public RendimentosPJComExigibilidade RendPJComExigibilidade { get; set; }
        public Espolio Espolio { get; set; }
        public ImpostoPago ImpostoPago { get; set; }
        [XmlElement("dependentes")]
        public Dependentes Dependentes { get; set; }
        public RendaVariavel RendaVariavel { get; set; }
        [XmlElement("alimentandos")]
        public Alimentandos Alimentandos { get; set; }
        [XmlElement("bens")]
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
        [XmlElement("doacoesEleitorais")]
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

    }
}