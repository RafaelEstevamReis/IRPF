namespace IRPF.Lib.Declaracao
{
    public class ModeloSimplificada : ModeloDeclaracao
    {
        public ModeloSimplificada() { } // Serialização
        
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

        internal static ModeloSimplificada importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            return new ModeloSimplificada()
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
                DescontoSimplificado = dec.TotaisDeclaracaoSimplificada.VR_DescImp,
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
    }
}