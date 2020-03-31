
namespace IRPF.Lib.Declaracao
{
    public class DeclaracaoIRPF
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
        public ModeloSimplificada ModeloSimplificada { get; set; }
        public ModeloCompleta ModeloCompleta { get; set; }

    }
}
