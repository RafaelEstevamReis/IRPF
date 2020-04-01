
namespace IRPF.Lib.Declaracao
{
    public class ModeloSimplificada : ModeloDeclaracao
    {
        private DeclaracaoIRPF declaracaoIRPF;
        public ModeloSimplificada() { } // Serialização
        public ModeloSimplificada(DeclaracaoIRPF declaracaoIRPF)
        {
            this.declaracaoIRPF = declaracaoIRPF;
        }
        
        public decimal RendRecebidoPJTitular { get; set; }
        public decimal RendRecebidoPJDependentes { get; set; }
        public decimal RendRecebidoPFEXT_TIT { get; set; }
        public decimal RendRecebidoPFEXT_DEP { get; set; }
        public decimal ResultadoTributavelAR { get; set; }
        public decimal TotalResultadosTributaveis { get; set; }
        public decimal DescontoSimplificado { get; set; }
        public decimal ImpostoRetidoFonteTitular { get; set; }
        public decimal ImpostoRetidoFonteDependentes { get; set; }
        public decimal CarneLeao { get; set; }
        public decimal ImpostoComplementar { get; set; }
        public decimal ImpostoRetidoFonteLei11033 { get; set; }
        public decimal RendIsentosNaoTributaveis { get; set; }
        public decimal RendSujeitoTribExclusiva { get; set; }
        public decimal BensDireitosExercicioAnterior { get; set; }
        public decimal BensDireitosExercicioAtual { get; set; }
        public decimal DividasExercicioAnterior { get; set; }
        public decimal DividasExercicioAtual { get; set; }
        public decimal TotalImpostoRetidoNaFonte { get; set; }
    }
}