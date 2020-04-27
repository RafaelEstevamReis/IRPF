using System.Xml.Serialization;

namespace IRPF.Lib.Declaracao
{
    public class RendimentosPJ : IRPFBase
    {
        public RendimentosPJ() { } // Serialização
        public RendimentosPJItem[] RendimentosTitular { get; set; }
        public RendimentosPJItem[] RendimentosDependente { get; set; }
        
        internal static RendimentosPJ importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            var RendPJ = new RendimentosPJ();
            RendPJ.RendimentosTitular = new RendimentosPJItem[dec.RendimentosPJ.Length];
            for (int i = 0; i < dec.RendimentosPJ.Length; i++)
            {
                RendPJ.RendimentosTitular[i] = new RendimentosPJItem()
                {
                    NomeFontePagadora = dec.RendimentosPJ[i].NM_Pagador,
                    NIFontePagadora = dec.RendimentosPJ[i].NR_Pagador,
                    rendRecebidoPJ = dec.RendimentosPJ[i].VR_Rendto,
                    contribuicaoPrevOficial = dec.RendimentosPJ[i].VR_Contrib,
                    impostoRetidoFonte = dec.RendimentosPJ[i].VR_Imposto,
                    decimoTerceiro = dec.RendimentosPJ[i].VR_DecTerc,
                    IRRFDecimoTerceiro = dec.RendimentosPJ[i].VR_IRRF13Salario
                };
            }
            return RendPJ;
        }
    }
}
