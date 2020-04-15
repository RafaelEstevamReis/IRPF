
using System.Xml.Serialization;
namespace IRPF.Lib.Declaracao
{
    public class Identificador : IRPFBase
    {
        public enum TipoDeclaracao
        {
            [XmlEnum("0")]
            Completa = 0,
            [XmlEnum("1")]
            Simplificada = 1,
        }

        public Identificador() { } // Serializar

        [XmlAttribute("tipoDeclaracao")]
        public TipoDeclaracao Tipo { get; set; }
        [XmlAttribute("cpf")]
        public string CPF { get; set; }
        [XmlAttribute("nome")]
        public string Nome { get; set; }
        [XmlAttribute("exercicio")]
        public int Exercicio { get; set; }
        //[XmlAttribute("declaracaoRetificadora")] // Conversão de Bool ficou estranho, vai precisar de ajuste
        public bool Retificadora { get; set; }
        [XmlAttribute("numReciboDecRetif")]
        public string NumeroReciboRetificadora { get; set; }
        [XmlAttribute("numeroReciboDecAnterior")]
        public string NumeroReciboAnterior { get; set; }
        //[XmlAttribute("enderecoDiferente")] // Conversão de Bool ficou estranho, vai precisar de ajuste
        public bool EnderecoDiferente { get; set; }
        [XmlIgnore] // Parece não ter no XML
        public string EnderecoMACRede { get; set; }

    }
}
