using IRPF.Lib.Helpers;
using System;

namespace IRPF.Lib.Declaracao
{
    partial class DeclaracaoIRPF
    {
        public static DeclaracaoIRPF fromArquivoDEC(Files.DEC_Intermediate dec)
        {
            #region Identificador
            var ide = new Identificador()
            {
                CPF = dec.Header.CPF_Contribuinte,
                Retificadora = dec.Header.ehRetificadora(),
                Nome = dec.Header.NR_Contribuinte,
                Exercicio = dec.Header.Exercicio,
                Tipo = dec.Header.ehCompleta() ? Identificador.TipoDeclaracao.Completa : Identificador.TipoDeclaracao.Simplificada,
                EnderecoDiferente = dec.Header.IN_MudaEndereco,
                EnderecoMACRede = dec.Header.ENDERECO_MAC,
                NumeroReciboAnterior = dec.Header.NR_ReciboUltimaDecExAnterior,
                NumeroReciboRetificadora = dec.Header.NR_ReciboUltimaDecExAtual // Não tenho certeza
            };
            #endregion
            var irpf = new DeclaracaoIRPF(ide);
            #region Contribuinte
            bool isUfEx = dec.Declarante.SG_UF.Equals("EX", StringComparison.CurrentCultureIgnoreCase);
            irpf.Contribuinte = new Contribuinte()
            {
                DataNascimento = Datas.Parse(dec.Declarante.DT_Nascim),
                TituloEleitor = dec.Declarante.NR_TituloEleitor,
                DoencaDeficiencia = dec.Declarante.ehDoencaDeficiencia(),
                ConjugueCompanheiro = dec.Declarante.ehConjugue(),
                CpfConjuge = dec.Declarante.NR_CpfConjugue,
                Exterior = isUfEx,
                TipoLogradouro = dec.Declarante.TIP_Logradouro,
                Logradouro = isUfEx ? "" : dec.Declarante.NM_Logradouro,
                Numero = isUfEx ? "" : dec.Declarante.NR_Numero,
                Complemento = isUfEx ? "" : dec.Declarante.NM_Complemento,
                Bairro = isUfEx ? "" : dec.Declarante.NM_Bairro,
                UF = 0,  // Lookup dec.Declarante.SG_UF
                Municipio = Convert.ToInt32(dec.Declarante.COD_Municipio),
                Cep = dec.Declarante.NR_CEP,
                DDD = dec.Declarante.NR_DDDTelefone,
                Telefone = dec.Declarante.NR_Telefone,
                DDDCelular = dec.Declarante.NR_DDDCelular,
                Celular = dec.Declarante.NR_Celular,
                LogradouroExt = isUfEx ? dec.Declarante.NM_Logradouro : "",
                NumeroExt = isUfEx ? dec.Declarante.NR_Numero : "",
                ComplementoExt = isUfEx ? dec.Declarante.NM_Complemento : "",
                BairroExt = isUfEx ? dec.Declarante.NM_Bairro : "",
                CidadeExt = isUfEx ? dec.Declarante.NM_Municipio : "",
                CodigoExterior = Numeros.Inteiro(dec.Declarante.CD_EX),// "",
                Pais = isUfEx ? Convert.ToInt32(dec.Declarante.CD_Pais) : 105, // 105 => BR
                CepExt = "",

                EMail = dec.Declarante.NM_EMail,
                NitPisPasep = dec.Declarante.NR_NitPisPasep,
                NaturezaOcupacao = Numeros.Inteiro(dec.Declarante.CD_Natur),
                OcupacaoPrincipal = Convert.ToInt32(dec.Declarante.CD_Ocup),
                RegistroProfissional = dec.Declarante.NR_Registroprofissional,
            };
            #endregion

            if (ide.Tipo == Identificador.TipoDeclaracao.Simplificada)
            {
                irpf.ModeloSimplificada = ModeloSimplificada.importarDec(ide, dec);
            }
            else
            {
                irpf.ModeloCompleta = ModeloCompleta.importarDec(ide, dec);
            }

            irpf.Pagamentos = Pagamentos.importarDec(ide, dec);
            irpf.RendPJ = RendimentosPJ.importarDec(ide, dec);
            irpf.RendPJComExigibilidade = RendimentosPJComExigibilidade.importarDec(ide, dec);
            irpf.Espolio = Espolio.importarDec(ide, dec);
            irpf.ImpostoPago = ImpostoPago.importarDec(ide, dec);
            irpf.Dependentes = Dependentes.importarDec(ide, dec);
            irpf.RendaVariavel = RendaVariavel.importarDec(ide, dec);
            irpf.Alimentandos = Alimentandos.importarDec(ide, dec);
            irpf.Bens = Bens.importarDec(ide, dec);
            irpf.Dividas = Dividas.importarDec(ide, dec);
            irpf.AtividadeRural = AtividadeRural.importarDec(ide, dec);
            irpf.GanhosDeCapital = GanhosCapital.importarDec(ide, dec);
            irpf.MoedaEstrangeira = MoedaEstrangeira.importarDec(ide, dec);
            irpf.RendPFTitular = RendimentosPF.importarDec(ide, dec);
            irpf.RendPFDependente = RendimentosPFDependente.importarDec(ide, dec);
            irpf.RendIsentos = RendimentosIsentos.importarDec(ide, dec);
            irpf.RendTributacaoExclusiva = RendimentosTributacaoExclusiva.importarDec(ide, dec);
            irpf.Comparativo = Comparativo.importarDec(ide, dec);
            irpf.Resumo = Resumo.importarDec(ide, dec);
            irpf.Doacoes = Doacoes.importarDec(ide, dec);

            return irpf;
        }
    }
}
