using System;

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
        public DateTime DataNascimento { get; set; }
        public string TituloEleitor { get; set; }
        public bool DoencaDeficiencia { get; set; }

        public bool ConjugueCompanheiro { get; set; }
        public string CpfConjuge { get; set; }

        public bool Exterior { get; set; }
        // Exterior: Não
        public int TipoLogradouro { get; set; } // Tabela
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int UF { get; set; }
        public int Municipio { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string DDDCelular { get; set; }
        public string Celular { get; set; }

        // Exterior: Sim
        public string LogradouroExt { get; set; }
        public string NumeroExt { get; set; }
        public string ComplementoExt { get; set; }
        public string BairroExt { get; set; }
        public string CidadeExt { get; set; }
        public int CodigoExterior { get; set; }
        public int Pais { get; set; }
        public string CepExt { get; set; }

        public string EMail { get; set; } // É o mesmo campo pros dois

        public string NitPisPasep { get; set; }
        public int NaturezaOcupacao { get; set; }
        public int OcupacaoPrincipal { get; set; }
        public string RegistroProfissional { get; set; }

    }
}