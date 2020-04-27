using System.Xml.Serialization;

namespace IRPF.Lib.Declaracao
{
    public class Bens : IRPFBase
    {
        [XmlElement("item")]
        public BensItens[] Itens { get; set; }

        internal static Bens importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            var bens = new Bens();
            bens.Itens = new BensItens[dec.BensDireitos.Length];
            for (int i = 0; i < dec.BensDireitos.Length; i++)
            {
                bens.Itens[i] = new BensItens()
                {
                    Descricao = dec.BensDireitos[i].TX_BEM,
                    ValorAnterior = dec.BensDireitos[i].VR_ANTER,
                    ValorAtual = dec.BensDireitos[i].VR_ATUAL,
                    CodigoBem = dec.BensDireitos[i].CD_BEM,
                    Pais = dec.BensDireitos[i].IN_Exterior ? dec.BensDireitos[i].CD_PAIS : 105,
                    // Não sei o que fazer com os outros dados de bens (RENAVAN, Registrod de imóvel, etc..)
                };
            }
            return bens;
        }
    }
}
