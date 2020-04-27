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
        [XmlIgnore]
        public bool Retificadora { get; set; }
        [XmlAttribute("declaracaoRetificadora")]
        public string _XML_Retificadora
        {
            get { return Helpers.ConversoesXML.BoolN_Get(Retificadora); }
            set { Retificadora = Helpers.ConversoesXML.BoolN_Set(value); }
        }

        [XmlAttribute("numReciboDecRetif")]
        public string NumeroReciboRetificadora { get; set; }
        [XmlAttribute("numeroReciboDecAnterior")]
        public string NumeroReciboAnterior { get; set; }
        [XmlIgnore]
        public bool EnderecoDiferente { get; set; }
        [XmlAttribute("enderecoDiferente")]
        public string _XML_EnderecoDiferente
        {
            get { return Helpers.ConversoesXML.BoolN_Get(EnderecoDiferente); }
            set { EnderecoDiferente = Helpers.ConversoesXML.BoolN_Set(value); }
        }
        [XmlIgnore] // Parece não ter no XML
        public string EnderecoMACRede { get; set; }

    }
}
