using IRPF.Lib.Helpers;
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
        [XmlIgnore]
        public DateTime DataNascimento { get; set; }
        [XmlAttribute("dataNascimento")]
        public string XML_DataNascimento
        {
            get { return ConversoesXML.Datas_Get(DataNascimento); }
            set { DataNascimento = ConversoesXML.Datas_Set(value); }
        }

        [XmlAttribute("tituloEleitor")]
        public string TituloEleitor { get; set; }
        [XmlIgnore]
        public bool DoencaDeficiencia { get; set; }
        [XmlAttribute("deficiente")]
        public string XML_DoencaDeficiencia
        {
            get { return ConversoesXML.BoolT_Get(DoencaDeficiencia); }
            set { DoencaDeficiencia = ConversoesXML.BoolT_Set(value); }
        }
        [XmlIgnore]
        public bool ConjugueCompanheiro { get; set; }
        [XmlAttribute("conjuge")]
        public string XML_ConjugueCompanheiro
        {
            get { return ConversoesXML.BoolN_Get(ConjugueCompanheiro); }
            set { ConjugueCompanheiro = ConversoesXML.BoolN_Set(value); }
        }
        [XmlAttribute("cpfConjuge")]
        public string CpfConjuge { get; set; }
        // Alteração de endereço já está no HEADER da declaração
        // Bools precisam de tratamento
        public bool Exterior { get; set; } // não sei qual é o campo
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
        public string NitPisPasep { get; set; } // Não achei
        [XmlAttribute("naturezaOcupacao")]
        public int NaturezaOcupacao { get; set; }
        [XmlAttribute("ocupacaoPrincipal")]
        public int OcupacaoPrincipal { get; set; }
        [XmlAttribute("registroProfissional")]
        public string RegistroProfissional { get; set; }

    }
}