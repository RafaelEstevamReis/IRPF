using System;
using System.Xml.Serialization;

namespace IRPF.Lib.Declaracao
{
    public class Contribuinte : IRPFBase
    {
        private Identificador IdentificadorDeclaracao;

        public Contribuinte() { } // Serialização
        public Contribuinte(Identificador IdentificadorDeclaracao)
        {
            this.IdentificadorDeclaracao = IdentificadorDeclaracao;
        }

        // Nome e CPF já estão no HEADER da declaração
        // Dados da Primeira aba
        //[XmlAttribute("dataNascimento")] // Precisará de tratamento
        public DateTime DataNascimento { get; set; }
        [XmlAttribute("tituloEleitor")]
        public string TituloEleitor { get; set; }
        // Bools precisam de tratamento
        public bool DoencaDeficiencia { get; set; }
        // Bools precisam de tratamento
        public bool ConjugueCompanheiro { get; set; }
        [XmlAttribute("cpfConjuge")]
        public string CpfConjuge { get; set; }
        // Alteração de endereço já está no HEADER da declaração
        // Bools precisam de tratamento
        public bool Exterior { get; set; }
        // Exterior: Não
        [XmlAttribute("tipoLogradouro")]
        public string TipoLogradouro { get; set; } // Tabela
        [XmlAttribute("logradouro")]
        public string Logradouro { get; set; }
        [XmlAttribute("numero")]
        public string Numero { get; set; }
        [XmlAttribute("complemento")]
        public string Complemento { get; set; }
        [XmlAttribute("bairro")]
        public string Bairro { get; set; }
        public int UF { get; set; }
        [XmlAttribute("municipio")]
        public int Municipio { get; set; }
        [XmlAttribute("cep")]
        public string Cep { get; set; }
        [XmlAttribute("ddd")]
        public string DDD { get; set; }
        [XmlAttribute("telefone")]
        public string Telefone { get; set; }
        [XmlAttribute("dddCelular")]
        public string DDDCelular { get; set; }
        [XmlAttribute("celular")]
        public string Celular { get; set; }

        // Exterior: Sim
        public string LogradouroExt { get; set; }
        public string NumeroExt { get; set; }
        public string ComplementoExt { get; set; }
        public string BairroExt { get; set; }
        [XmlAttribute("cidade")]
        public string CidadeExt { get; set; }
        public int CodigoExterior { get; set; }
        public int Pais { get; set; }
        public string CepExt { get; set; }
        [XmlAttribute("email")]
        public string EMail { get; set; } // É o mesmo campo pros dois
        [XmlIgnore]
        public string NitPisPasep { get; set; }
        [XmlAttribute("naturezaOcupacao")]
        public int NaturezaOcupacao { get; set; }
        [XmlAttribute("ocupacaoPrincipal")]
        public int OcupacaoPrincipal { get; set; }
        [XmlAttribute("registroProfissional")]
        public string RegistroProfissional { get; set; }

    }
}