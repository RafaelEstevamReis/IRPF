
namespace IRPF.Lib.Declaracao
{
    public class Doacoes : IRPFBase
    {
        //[XmlAttribute("totalDoacoes")] // Dá treta com formato PT-BR
        public decimal TotalDoacoes { get; set; }

        internal static Doacoes importarDec(Identificador ide, Files.DEC_Intermediate dec)
        {
            throw new System.NotImplementedException();
        }
    }
}
