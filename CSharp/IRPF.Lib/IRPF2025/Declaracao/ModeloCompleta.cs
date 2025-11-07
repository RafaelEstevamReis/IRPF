namespace IRPF.Lib.IRPF2025.Declaracao
{
    public class ModeloCompleta : ModeloDeclaracao
    {
        public ModeloCompleta() { } // Serialização

        internal static ModeloCompleta importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            return new ModeloCompleta()
            {
                // Base
                ImpostoDevido = dec.TotaisDeclaracao.VR_ImpDev1,
                BaseCalculo = dec.TotaisDeclaracao.VR_BaseCalc,
                SaldoImpostoPagar = dec.TotaisDeclaracao.VR_ImpPagar,
                ImpostoRestituir = dec.TotaisDeclaracao.VR_ImpRest,
                RendRecebidoExterior = 0,// ?
                TotalRendRecebidosMaisExterior = 0, // ?
                TotalLivroCaixa = dec.TotaisDeclaracao.VR_LivCaix, // ?
                TotalDoacoesCampanhasEleitorais = dec.TotaisDeclaracao.VR_DoacoesCampanha,
                // Completa
                // TODO terminar
            };
        }
    }
}
