
- Tabela de Conteúdo
  - [Índice](#índice)
  - [Registros da Declaração](#registros-da-declaração)
    - [Header](#header)
    - [Lotes 1X](#lotes-1x)
    - [Lotes 2X](#lotes-2x)
    - [Lotes 3X](#lotes-3x)
    - [Lotes 4X](#lotes-4x)
    - [Lotes 5X](#lotes-5x)
    - [Lotes 6X](#lotes-6x)
    - [Lotes 7X](#lotes-7x)
    - [Lotes 8X](#lotes-8x)
    - [Lotes 9X](#lotes-9x)
    - [Lote Trailer](#lote-trailer)
  - [Registros do Recibo](#registros-do-recibo)
  - [Registros de Complemento de Recibo](#registros-de-complemento-de-recibo)

# Leiate DIRPF 2025

Leiaute criado de acordo com LeiauteDadosDIRPF2025.xml

## Índice

| Registros |  |  | |  |
|----------|----------|----------|----------|----------|
| [Tipo: IR](#tipo-ir) | | | | |
| [Tipo: 16](#tipo-16) | [Tipo: 17](#tipo-17) | [Tipo: 18](#tipo-18) | [Tipo: 19](#tipo-19) | |
| [Tipo: 20](#tipo-20) | [Tipo: 21](#tipo-21) | [Tipo: 22](#tipo-22) | [Tipo: 23](#tipo-23) | [Tipo: 24](#tipo-24) |
| [Tipo: 25](#tipo-25) | [Tipo: 26](#tipo-26) | [Tipo: 27](#tipo-27) | [Tipo: 28](#tipo-28) | [Tipo: 29](#tipo-29) |
| [Tipo: 30](#tipo-30) | [Tipo: 31](#tipo-31) | [Tipo: 32](#tipo-32) | [Tipo: 33](#tipo-33) | [Tipo: 34](#tipo-34) |
| [Tipo: 35](#tipo-35) | [Tipo: 36](#tipo-36) | [Tipo: 37](#tipo-37) | [Tipo: 38](#tipo-38) | [Tipo: 39](#tipo-39) |
| [Tipo: 40](#tipo-40) | [Tipo: 41](#tipo-41) | [Tipo: 42](#tipo-42) | [Tipo: 43](#tipo-43) | [Tipo: 45](#tipo-45) |
| [Tipo: 46](#tipo-46) | [Tipo: 47](#tipo-47) | [Tipo: 48](#tipo-48) | [Tipo: 49](#tipo-49) | [Tipo: 50](#tipo-50) |
| [Tipo: 51](#tipo-51) | [Tipo: 52](#tipo-52) | [Tipo: 53](#tipo-53) | [Tipo: 54](#tipo-54) | [Tipo: 55](#tipo-55) |
| [Tipo: 56](#tipo-56) | [Tipo: 57](#tipo-57) | [Tipo: 58](#tipo-58) | [Tipo: 59](#tipo-59) | [Tipo: 60](#tipo-60) |
| [Tipo: 61](#tipo-61) | [Tipo: 62](#tipo-62) | [Tipo: 63](#tipo-63) | [Tipo: 64](#tipo-64) | [Tipo: 65](#tipo-65) |
| [Tipo: 66](#tipo-66) | [Tipo: 67](#tipo-67) | [Tipo: 68](#tipo-68) | [Tipo: 69](#tipo-69) | [Tipo: 70](#tipo-70) |
| [Tipo: 71](#tipo-71) | [Tipo: 72](#tipo-72) | [Tipo: 73](#tipo-73) | [Tipo: 74](#tipo-74) | [Tipo: 75](#tipo-75) |
| [Tipo: 76](#tipo-76) | [Tipo: 77](#tipo-77) | [Tipo: 78](#tipo-78) | [Tipo: 80](#tipo-80) | [Tipo: 81](#tipo-81) |
| [Tipo: 82](#tipo-82) | [Tipo: 83](#tipo-83) | [Tipo: 84](#tipo-84) | [Tipo: 85](#tipo-85) | [Tipo: 86](#tipo-86) |
| [Tipo: 87](#tipo-87) | [Tipo: 88](#tipo-88) | [Tipo: 89](#tipo-89) | [Tipo: 90](#tipo-90) | [Tipo: 91](#tipo-91) |
| [Tipo: 92](#tipo-92) | [Tipo: 93](#tipo-93) | [Tipo: 94](#tipo-94) | [Tipo: 95](#tipo-95) | [Tipo: 96](#tipo-96) |
| [Tipo: 97](#tipo-97) | [Tipo: 98](#tipo-98) | [Tipo: 99](#tipo-99) | | |
| [Tipo: FR](#tipo-fr) | [Tipo: T9](#tipo-t9) | [Tipo: HR](#tipo-hr) | [Tipo: DR](#tipo-dr) | [Tipo: R9](#tipo-r9) |
| [Tipo: HC](#tipo-hc) | [Tipo: RC](#tipo-rc) | [Tipo: NC](#tipo-nc) | [Tipo: VC](#tipo-vc) | [Tipo: MC](#tipo-mc) |
| [Tipo: TC](#tipo-tc) | | | | |

## Registros da Declaração 

### Header

#### Tipo:  IR

HEADER - IDENTIFICAÇÃO DA DECLARAÇÂO

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| SISTEMA | C | 8 | Identificador do Sistema - IRPF - Pessoa Física, com 4 espaços em branco na frente. |
| EXERCICIO | N | 4 | Exercicio do PGD |
| ANO_BASE | N | 4 | Ano calendario |
| CODIGO_RECNET | N | 4 | Código interno da declaração no sistema Receitanet: (2600) - Ajuste (2621) - Espólio (2620 ) - Saída |
| IN_RETIFICADORA | C | 1 | Indicador se declaracao retificadora |
| NR_CPF | C | 11 | CPF do contribuinte |
| FILLER | C | 3 | Filler |
| TIPO_NI | N | 1 | Indica o tipo de NI: 1 Pessoa Fisica (CPF) |
| NR_VERSAO | N | 3 | Versao do Programa Gerador da declaracao: 100 (primeira versão) |
| NM_NOME | A | 60 | nome do contribuinte |
| SG_UF | A | 2 | UF - Domicilio do Contribuinte |
| NR_HASH | N | 10 | Hash calculado sobre todos os registros da declaracao,exceto o Header da declaracao e todos os registros do recibo(Nr. Controle SRF) |
| IN_CERTIFICAVEL | N | 1 | Indicativo se declaracao eh certificavel |
| DT_NASCIM | N | 8 | Data de Nascimento (DDMMAAAA) |
| IN_COMPLETA | C | 1 | Indicativo se declaracao completa |
| IN_RESULTADO_IMPOSTO | C | 1 | Indicativo de resultado do imposto |
| IN_GERADA | C | 1 | Indicativo se declaracao gerada |
| NR_RECIBO_ULTIMA_DEC_EX_ATUAL | C | 10 | Número do recibo da declaração original ou retificadora do exercicio atual a ser retificada |
| FILLER | C | 1 | Espaço em branco |
| nome_SO | C | 14 | nome do Sistema Operacional |
| VERSAO_SO | C | 7 | Numero da versao do Sistema Operacional(SO) |
| VERSAO_JVM | C | 9 | Numero da versao do Java |
| NR_RECIBO_DECLARACAO_TRANSMITIDA | C | 10 | Numero do recibo da última declaracao transmitida |
| CD_MUNICIP | C | 4 | Codigo do municipio |
| NR_CONJ | C | 11 | CPF do cônjuge |
| IN_OBRIGAT_ENTREGA | C | 1 | Indicador de Obrigatoriedade de Entrega |
| VR_IMPDEVIDO | N | 13 | Valor do Carnê-leão e Imposto Complementar dos dependentes. |
| NR_RECIBO_ULTIMA_DEC_EX_ANTERIOR | C | 10 | Numero do recibo da última do ano anterior |
| IN_SEGURANCA | C | 1 | Indicador de segurança da declaração |
| IN_IMPOSTO_PAGO | N | 2 | Indicador se teve imposto pago |
| IN_IMPOSTO_ANTECIPADO | N | 1 | Indicador se teve imposto antecipado |
| IN_MUDA_ENDERECO | N | 1 | Indicador de Mudança de Endereço |
| NR_CEP | N | 8 | Número do CEP informado |
| IN_DEBITO_PRIMEIRA_QUOTA | N | 1 | Indicador de Débito Automático da 1ª quota |
| NR_BANCO | N | 3 | Número do Banco Informado |
| NR_AGENCIA | N | 4 | Número da Agência Informada |
| IN_SOBREPARTILHA | C | 1 | Ocorreu partilha |
| DATA_TRANSITO_JULGADO_LAVRATURA | N | 8 | Somente será gravada se a declaração for de espólio:No caso de decisão judicial, grava a data de trânsito julgado se esta for >= 01/03/[Ano Exercício] (formato AAAAMMDD) No caso de escrituração pública, grava a data de lavratura se esta for >= 01/03/[Ano Exercício] (formato AAAAMMDD) |
| VR_SOMA_IMPOSTO_PAGAR | N | 13 | Valor do imposto a pagar(somatório do imposto a pagar da declaração + GCAP + Renda Variável + GCME Bens, Direitos e Aplic. Financeiras + GCME Espécie) |
| IN_OPCAO_TRIBUTACAO_BENEFICIARIO_UM_RRA | C | 1 | Opção de tributação da maior fonte pagadora de RRA |
| CPF_BENEFICIARIO_UM_RRA | C | 11 | CPF do maior beneficiário de RRA |
| IN_OPCAO_TRIBUTACAO_BENEFICIARIO_DOIS_RRA | C | 1 | Opção de tributação da segunda maior fonte pagadora de RRA |
| CPF_BENEFICIARIO_DOIS_RRA | C | 11 | CPF do segundo maior beneficiário de RRA |
| IN_OPCAO_TRIBUTACAO_BENEFICIARIO_TRES_RRA | C | 1 | Opção de tributação da terceira maior fonte pagadora de RRA |
| CPF_BENEFICIARIO_TRES_RRA | C | 11 | CPF do terceiro maior beneficiário de RRA |
| IN_OPCAO_TRIBUTACAO_BENEFICIARIO_QUATRO_RRA | C | 1 | Opção de tributação do quarto maior beneficiário de RRA |
| CPF_BENEFICIARIO_QUATRO_RRA | C | 11 | CPF do quarto maior beneficiário de RRA |
| VR_DOACAO_ECA | N | 13 | Valor total das doações na declaração a fundos de Estatuto da Criança e do Adolescente |
| VR_DOACAO_IDOSO | N | 13 | Valor total das doações na declaração a fundos de Estatuto do Idoso |
| NR_BASE_FONTE_MAIOR | C | 14 | CPF/CNPJ Base da Maior Fonte Pagadora |
| NR_BASE_FONTE_DOIS | C | 14 | CPF/CNPJ Base da 2a Maior Fonte Pagadora |
| NR_BASE_FONTE_TRES | C | 14 | CPF/CNPJ Base da 3a Maior Fonte Pagadora |
| NR_BASE_FONTE_QUATRO | C | 14 | CPF/CNPJ Base da 4a Maior Fonte Pagadora |
| NR_CPF_DEPE_REND_MAIOR | C | 11 | CPF de Dependente com maior Rend. Tributavel de PJ |
| DT_NASC_DEPE_REND_MAIOR | C | 8 | Data Nascimento de Dependente com maior Rend. Tributável de PJ (DDMMAAAA) |
| NR_CPF_DEPE_REND_DOIS | C | 11 | CPF de Dependente com 2a maior Rend. Tributavel de PJ |
| DT_NASC_DEPE_REND_DOIS | C | 8 | Data Nascimento de Dependente com 2o maior Rend. Tributável de PJ (DDMMAAAA) |
| NR_CPF_DEPE_REND_TRES | C | 11 | CPF de Dependente com 3a maior Rend. Tributavel de PJ |
| DT_NASC_DEPE_REND_TRES | C | 8 | Data Nascimento de Dependente com 3o maior Rend. Tributável de PJ (DDMMAAAA) |
| NR_CPF_DEPE_REND_QUATRO | C | 11 | CPF de Dependente com 4a maior Rend. Tributavel de PJ |
| DT_NASC_DEPE_REND_QUATRO | C | 8 | Data Nascimento de Dependente com 4o maior Rend. Tributável de PJ (DDMMAAAA) |
| NR_CPF_DEPE_REND_CINCO | C | 11 | CPF de Dependente com 5a maior Rend. Tributavel de PJ |
| DT_NASC_DEPE_REND_CINCO | C | 8 | Data Nascimento de Dependente com 5o maior Rend. Tributável de PJ (DDMMAAAA) |
| NR_CPF_DEPE_REND_SEIS | C | 11 | CPF de Dependente com 6a maior Rend. Tributavel de PJ |
| DT_NASC_DEPE_REND_SEIS | C | 8 | Data Nascimento de Dependente com 6o maior Rend. Tributável de PJ (DDMMAAAA) |
| NR_BASE_BENEF_DESP_MED_MAIOR | C | 14 | CPF/CNPJ Base do maior beneficiário de Despesas Médicas |
| NR_BASE_BENEF_DESP_MED_DOIS | C | 14 | CPF/CNPJ Base do 2o maior beneficiário de Despesas Médicas |
| NR_CPF_DEST_PENSAO_ALIMENT_MAIOR | C | 11 | CPF de destinatário com maior pensão alimentícia |
| NR_CPF_INVENTARIANTE | C | 11 | CPF do inventariante |
| NM_MUNICIPIO | A | 40 | nome do Município do Contribuinte |
| NM_CONTRIBUINTE | A | 60 | nome do Contribuinte |
| FILLER | A | 11 | Espaços em branco |
| ENDERECO_MAC | C | 12 | Endereço físico da estação |
| DT_COND_NAO_RESIDENTE | N | 8 | Data da condição de Não-Residente informada na ficha de Saída (formato AAAAMMDD) |
| NR_CPF_PROCURADOR | C | 11 | CPF do Procurador - informado na ficha saída |
| IN_CRIT_OBRIGAT | N | 3 | Critérios de obrigatoriedade nos quais incidiram a declaração |
| VR_TOTAL_RENDTRIB_PFPJ_TITDEP | N | 13 | Valor total dos rendimentos tributáveis recebidos de pessoa jurídica e de pessoa física pelo titular e dependentes |
| FILLER | C | 11 | Espaços em branco |
| IN_CONFIABILIDADE | C | 1 |  |
| TP_INICIADA | C | 2 | de foi iniciada a declaração: 1-PGD; 2-m-IRPF ; 3-m-IRPF OnLine ; 4-Retificadora OnLine |
| TP_TRANSMITIDA | C | 2 | Em qual aplicativo foi realizada a transmissão: 1-PGD; 2-m-IRPF ; 3-m-IRPF OnLine; 4-Retificadora OnLine |
| NR_CPF_TRANSMISSAO | C | 11 | CPF logado no momento da transmissão. |
| IN_CPF_TRANSMISSAO_PERFIL | C | 1 | Perfil/Papel do CPF no momento da transmissão: 0-Não definido, 1-Próprio, 2- Procurador, 3-Autorizado |
| VR_TOTISENTOS | N | 13 | Valor total de rendimentos isentos |
| VR_TOTEXCLUSIVO | N | 13 | Valor total de rendimentos sujeitos a tributação exclusiva |
| VR_TOTAL_PAGAMENTOS | N | 13 | Valor total de pagamentos (somatório de todos os valores da ficha pagamentos) |
| IN_PROCESSO_ATUALIZACAO_BEM | C | 1 | O contribuinte fez atualização de algum bem de acordo com a Lei 14973 DE 16/09/2024 0-Não (padrão) 1-Sim |
| FILLER | C | 12 | Espaços em branco. |
| NR_DV_CONTA | C | 2 | Numero do Digito Verificador da Conta Corrente |
| IN_DV_CONTA | N | 1 | Indicador para revalidar DV de conta corrente. 0 - Não revalidar; 1 - Revalidar |
| CD_NATUR | N | 2 | Código da natureza da ocupação |
| NR_CPF_EMPREGADA_DOMESTICA_MAIOR | A | 11 | CPF da Empregada Doméstica com maior contribuição patronal |
| NR_NIT_EMP_DOM_MAIOR | A | 11 | NIT do empregado doméstico com maior contruibuição |
| NR_CPF_EMPREGADA_DOMESTICA_DOIS | A | 11 | CPF da Empregada Doméstica com segunda maior contribuição patronal |
| NR_NIT_EMP_DOM_DOIS | A | 11 | NIT do empregado doméstico com segunda maior contruibuição |
| NR_CPF_EMPREGADA_DOMESTICA_TRES | A | 11 | CPF da Empregada Doméstica com terceira maior contribuição patronal |
| NR_NIT_EMP_DOM_TRES | A | 11 | NIT do empregado doméstico com terceira maior contruibuição |
| FILLER | C | 1 | Espaços em branco |
| IN_UTILIZOU_PGD | C | 1 | Utilizou o PGD:0-Não ; 1-Sim |
| IN_UTILIZOU_APP | C | 1 | Utilizou o m-IRPF APP:0-Não ; 1-Sim |
| IN_UTILIZOU_ONLINE | C | 1 | Utilizou o m-IRPF Online:0-Não ; 1-Sim |
| IN_UTILIZOU_RASCUNHO | C | 1 | Utilizou o Rascunho IRPF:0-Não ; 1-Sim |
| IN_UTILIZOU_PRE_PREENCHIDA | C | 1 | Utilizou a Pré-Preenchida:0-Não ; 1-Sim |
| IN_UTILIZOU_ASSISTIDA_FONTE_PAGADORA | C | 1 | Utilizou a Assistida das Fontes Pagadoras:0-Não ; 1-Sim |
| IN_UTILIZOU_ASSISTIDA_PLANO_SAUDE | C | 1 | Utilizou a Assistida dos Planos de Saúde:0-Não ; 1-Sim |
| IN_UTILIZOU_SALVAR_RECUPERAR_ONLINE | C | 1 | Utilizou o Salvar / Recuperar Online:0-Não ; 1-Sim |
| FILLER | C | 1 | Espaços em branco |
| NR_PAGAMENTO_DEDUTIVEL_MAIOR_UM | C | 14 | CPF-CNPJ do maior pagamento dedutível (cod 01; 10 ; 11; 12; 13; 14; 21; 26; 30; 33; 36; 37; 38; 50) |
| NR_PAGAMENTO_DEDUTIVEL_MAIOR_DOIS | C | 14 | CPF-CNPJ do 2 maior pagamento dedutível (cod 01; 10 ; 11; 12; 13; 14; 21; 26; 30; 33; 36; 37; 38; 50) |
| NR_PAGAMENTO_DEDUTIVEL_MAIOR_TRES | C | 14 | CPF-CNPJ do 3 maior pagamento dedutível (cod 01; 10 ; 11; 12; 13; 14; 21; 26; 30; 33; 36; 37; 38; 50) |
| NR_PAGAMENTO_DEDUTIVEL_MAIOR_QUATRO | C | 14 | CPF-CNPJ do 4 maior pagamento dedutível (cod 01; 10 ; 11; 12; 13; 14; 21; 26; 30; 33; 36; 37; 38; 50) |
| NR_PAGAMENTO_DEDUTIVEL_MAIOR_CINCO | C | 14 | CPF-CNPJ do 5 maior pagamento dedutível (cod 01; 10 ; 11; 12; 13; 14; 21; 26; 30; 33; 36; 37; 38; 50) |
| NR_PAGAMENTO_DEDUTIVEL_MAIOR_SEIS | C | 14 | CPF-CNPJ do 6 maior pagamento dedutível (cod 01; 10 ; 11; 12; 13; 14; 21; 26; 30; 33; 36; 37; 38; 50) |
| FILLER | C | 27 | Espaços em branco |
| IN_TIPO_CONTA | C | 1 | 0-Conta corrente 1-Conta Poupança 2-Conta pagamento |
| NR_CONTA | C | 20 | Numero da conta corrente para débito automático |
| IN_SOCIAL | C | 1 | Indicador de que deve devolver o auxilio emergencial 0-Não 1-Sim |
| IN_CLWEB | C | 1 |  |
| IN_ISENCAO_GCAP_TITULAR | C | 1 | 0-Não (padrão), 1-Não possui Isenção, 2-180 Dias, 3-Único Imovel, 4- 180 dias e Único Imovel |
| IN_ISENCAO_GCAP_MAIOR | C | 1 | 0-Não (padrão), 1-Não possui Isenção, 2-180 Dias, 3-Único Imovel, 4- 180 dias e Único Imovel |
| IN_ISENCAO_GCAP_DOIS | C | 1 | 0-Não (padrão), 1-Não possui Isenção, 2-180 Dias, 3-Único Imovel, 4- 180 dias e Único Imovel |
| IN_ISENCAO_GCAP_TRES | C | 1 | 0-Não (padrão), 1-Não possui Isenção, 2-180 Dias, 3-Único Imovel, 4- 180 dias e Único Imovel |
| IN_ISENCAO_GCAP_QUATRO | C | 1 | 0-Não (padrão), 1-Não possui Isenção, 2-180 Dias, 3-Único Imovel, 4- 180 dias e Único Imovel |
| IN_ISENCAO_GCAP_CINCO | C | 1 | 0-Não (padrão), 1-Não possui Isenção, 2-180 Dias, 3-Único Imovel, 4- 180 dias e Único Imovel |
| IN_ISENCAO_GCAP_SEIS | C | 1 | 0-Não (padrão), 1-Não possui Isenção, 2-180 Dias, 3-Único Imovel, 4- 180 dias e Único Imovel |
| IN_FICHA_1 | C | 2 |  |
| IN_COD_FICHA_1 | C | 2 |  |
| CNPJ_MAIOR_VALOR_1 | C | 14 |  |
| IN_FICHA_2 | C | 2 |  |
| IN_COD_FICHA_2 | C | 2 |  |
| CNPJ_MAIOR_VALOR_2 | C | 14 |  |
| IN_FICHA_3 | C | 2 |  |
| IN_COD_FICHA_3 | C | 2 |  |
| CNPJ_MAIOR_VALOR_3 | C | 14 |  |
| IN_FICHA_4 | C | 2 |  |
| IN_COD_FICHA_4 | C | 2 |  |
| CNPJ_MAIOR_VALOR_4 | C | 14 |  |
| IN_FICHA_5 | C | 2 |  |
| IN_COD_FICHA_5 | C | 2 |  |
| CNPJ_MAIOR_VALOR_5 | C | 14 |  |
| IN_FICHA_6 | C | 2 |  |
| IN_COD_FICHA_6 | C | 2 |  |
| CNPJ_MAIOR_VALOR_6 | C | 14 |  |
| IN_FICHA_7 | C | 2 |  |
| IN_COD_FICHA_7 | C | 2 |  |
| CNPJ_MAIOR_VALOR_7 | C | 14 |  |
| IN_FICHA_8 | C | 2 |  |
| IN_COD_FICHA_8 | C | 2 |  |
| CNPJ_MAIOR_VALOR_8 | C | 14 |  |
| IN_FICHA_9 | C | 2 |  |
| IN_COD_FICHA_9 | C | 2 |  |
| CNPJ_MAIOR_VALOR_9 | C | 14 |  |
| IN_FICHA_10 | C | 2 |  |
| IN_COD_FICHA_10 | C | 2 |  |
| CNPJ_MAIOR_VALOR_10 | C | 14 |  |
| DT_RETORNO_PAIS | C | 8 | Data de retorno ao pais, para quem estava morando no exterior. |
| NR_PROCESSO_ATUALIZACAO_BEM | C | 17 | Número do processo em que foi formalizada a opção pela Lei 14973 DE 16/09/2024 |
| NR_PROCESSO_ATUALIZACAO_BEM_FILLER | C | 8 | Filler de resto do processo que teria 25 caracteres e passo a ter apenas 17 |
| VERSAOTESTEPGD | C | 3 | Numero da versao de desenvolvimento do PGD. Esse campo irá compor o campo FILLER2, quando da versão final. |
| NR_CONTROLE | N | 10 | Número de controle |

### Lotes 1X

#### Tipo:  16

IDENTIFICAÇÃO DO DECLARANTE

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NM_NOME | A | 60 | nome do contribuinte |
| TIP_LOGRA | A | 15 | formato do Logradouro |
| NM_LOGRA | C | 40 | Endereço contribuinte: logradouro |
| NR_NUMERO | C | 6 | Endereço contribuinte: número |
| NM_COMPLEM | C | 21 | Endereço contribuinte: complemento |
| NM_BAIRRO | C | 19 | Endereço contribuinte: bairro |
| NR_CEP | C | 9 | Endereço contribuinte: CEP ou ZIPExterior |
| CD_MUNICIP | N | 4 | Endereço contribuinte: código do município |
| NM_MUNICIP | C | 40 | Endereço contribuinte: município |
| SG_UF | A | 2 | Endereço contribuinte: UF |
| CD_EX | C | 3 | Código do Exterior |
| CD_PAIS | C | 3 | Código do país |
| NM_PAIS | C | 40 | nome do país |
| NM_EMAIL | C | 90 | Email - Correio Eletrônico |
| NR_NITPISPASEP | C | 11 | informação do NIT/PIS/PASEP informação constante na ficha de Pessoa Fisica no Exterior. Sem valor informado campo em branco. |
| NR_CPF_CONJUGE | C | 11 | CPF do conjuge |
| NR_DDD_TELEFONE | C | 4 | Endereço contribuinte: Cod. área do telefone-DDI |
| FILLER1 | A | 9 | Espaços em branco |
| DT_NASCIM | N | 8 | Data nascimento do contribuinte DD-MM-AAAA |
| VR_PREJUIZO_ANO_ANTERIOR_LEI_14754 | N | 13 | Prejuízo acumulado no ano anterior com aplicações financeiras no exterior. |
| CD_OCUP | A | 3 | Código de ocupação |
| NM_OCUP | C | 150 |  |
| CD_NAT_OCUP | A | 2 | Código natureza ocupação |
| NM_NAT_OCUP | C | 130 |  |
| NR_QUOTAS | N | 1 | Quantidades de quotas |
| IN_COMPLETA | C | 1 | Indicativo se declaração completa S - sim N - não |
| IN_RETIFICADORA | C | 1 | Indicativo se declaração retificadora S - sim N - não |
| IN_GERADO | C | 1 | Indicativo se a declaração foi gerada S - sim N - não |
| IN_ENDERECO | C | 1 | Indicativo se houve mudança de endereço S - sim N - não |
| NR_CONTROLE_ORIGINAL | C | 12 | Número do recibo da declaração original |
| NR_BANCO | N | 3 | Código do Banco para restituição ou débito |
| NR_AGENCIA | N | 4 | Número da Agência Bancária para restituição ou débito |
| IN_DOENCA_DEFICIENCIA | C | 1 | Indicativo se um dos declarantes(titular ou dependentes) é pessoa com doença grave ou portadora de deficiência física ou mental (Valor 'S' ou 'N') |
| IN_PREPREENCHIDA | C | 1 | Filler |
| DT_DIA_UTIL_RECIBO | N | 8 | 1o dia util pos entrega |
| FILLER | C | 4 | filler |
| IN_PROCESSO_ATUALIZACAO_BEM | N | 1 | O contribuinte fez atualização de algum bem de acordo com a Lei 14973 de 16/09/2024: 0-Não (padrão) 1-Sim |
| NR_DV_CONTA | C | 2 | Número do Dígito Verificador da Conta Corrente para restituição ou débito |
| IN_DEBITO_AUTOM | A | 1 | Indicativo se o contribuinte autoriza o débito automático das quotas do imposto devido em sua conta corrente. S - sim N -não |
| IN_DEBITO_PRIMEIRA_QUOTA | N | 1 | Indicativo se o débito automático é a partir da 1 Quota ou quota única - 1 - sim 0 -não |
| NR_FONTE_PRINCIPAL | C | 14 | CPF-CNPJ da principal Fonte Pagadora |
| NR_RECIBO_ULTIMA_DEC_ANO_ANTERIOR | C | 10 | Número do recibo da última declaração transmitida no ano anterior |
| IN_TIPODECLARACAO | C | 1 | Indica se a declaração é do tipo Ajuste, Espólio ou Saída |
| NR_CPF_PROCURADOR | C | 11 | CPF do procurador, caso a declaração seja de ajuste e o endereço no exterior |
| NR_REGISTRO_PROFISSIONAL | A | 20 | Numero do registro profissional |
| NR_DDD_CELULAR | C | 2 | Zeros - DDD do celular |
| NR_CELULAR | C | 9 | Zeros - Celular |
| IN_CONJUGE | C | 1 | S-Sim ; N-Não |
| NR_TELEFONE | C | 11 | Endereço contribuinte: telefone |
| IN_TIPO_CONTA | C | 1 | 0-Conta corrente 1-Conta Poupança 2-Conta pagamento |
| NR_CONTA | C | 20 | Numero da conta corrente para depósito de IAR |
| NR_NUMERO_PROCESSO | C | 17 | Numero do processo digital |
| CPF_RESPONSAVEL | C | 11 | CPF do Responsável declaração.  |
| NR_DATA_HORA_ORIGINAL_RETIFICADORA | N | 14 | CPF do Responsável declaração.  |
| TX_MENSAGEM_RECIBO | C | 300 | CPF do Responsável declaração.  |
| IN_RETORNO_PAIS | C | 1 | 0-Nao (padrao) 1-Sim |
| DT_RETORNO_PAIS | C | 8 | Data de retorno ao pais, para quem estava morando no exterior. |
| NR_PROCESSO_ATUALIZACAO_BEM | C | 17 | Número do processo em que foi formalizada a opção pela Lei 14973 DE 16/09/2024 |
| NR_PROCESSO_ATUALIZACAO_BEM_FILLER | C | 8 | Filler de resto do processo que teria 25 caracteres e passo a ter apenas 17 |
| NR_CONTROLE | N | 10 | Número de controle |

#### Tipo:  17

DEMAIS RENDIMENTOS E IMPOSTO PAGO(DESCONTO SIMPLIFICADO)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| VR_IMPCOMP | N | 13 | Valor do Imposto Complementar do titular |
| VR_LUCROSTIT | N | 13 | Lucros e Dividendos recebidos pelo Titular |
| VR_ISENTOS | N | 13 | Demais Rendimentos isentos e não-tributáveis do titular exceto ativ. Rural, GC e GCME |
| VR_EXCLUSIVOS | N | 13 | Valor dos Rendimentos sujeitos à  tributação exclusiva Exceto 13 salário,Renda Variável, GC e GCME do titular |
| VR_TOTAL13 | N | 13 | Valor do 13o. do Titular |
| VR_IRFONTELEI11033 | N | 13 | Valor Retido na Fonte Lei n 11.033-2004 |
| VR_TOTAL13DEPEND | N | 13 | Valor do 13o. do Dependente |
| VR_LUCROSDEPEND | N | 13 | Lucros e Dividendos recebidos pelos Dependentes |
| VR_ISENTOSDEPEND | N | 13 | Demais Rendimentos isentos e não-tributáveis dos dependentes |
| VR_EXCLUSIVOSDEPEND | N | 13 | Valor dos Rendimentos sujeitos à  tributação exclusiva dos dependentes Exceto 13 salário |
| FILLER1 | A | 13 | Espaços em branco |
| FILLER2 | A | 13 | Espaços em branco |
| VR_RENDPF_TIT | N | 13 | Total de Rendimentos Recebidos de PF pelo titular |
| VR_RENDPF_DEPEND | N | 13 | Total de Rendimentos Recebidos de PF pelos dependentes |
| VR_RENDEXT_TIT | N | 13 | Total de Rendimentos Recebidos do exterior pelo titular |
| VR_RENDEXT_DEPEND | N | 13 | Total de Rendimentos Recebidos do exterior pelos dependentes |
| VR_CARNELEAO_TIT | N | 13 | Valor pago Carnê-LeãoTitular |
| VR_CARNELEAO_DEPEND | N | 13 | Valor pago Carnê-LeãoDependentes |
| VR_DEPEN | N | 13 | Dedução com dependentes (Ficha Dependentes) |
| VR_TOT_PREVOFC_AC_TIT | N | 13 | Total previdência oficial RRA - pelo titular (Ficha RRA - Titular - opção de tributação ajuste anual) |
| VR_TOT_PREVOFC_AC_DEP | N | 13 | Total previdência oficial RRA - pelos dependentes (Ficha RRA - Dependentes - opção de tributação ajuste anual) |
| VR_TOT_PENSALI_AC_TIT | N | 13 | Total Pensão Alimentícia RRA - pelo titular (Ficha RRA - Titular - opção de tributação ajuste anual) |
| VR_TOT_PENSALI_AC_DEP | N | 13 | Total Pensão Alimentícia RRA - pelos dependentes (Ficha RRA - Dependentes - opção de tributação ajuste anual |
| VR_IMPEXT | N | 13 | Valor do imposto pago exterior |
| VR_IMPDEVIDO_SEM_REND_EXT | N | 13 | Imposto devido sem o rendimento no exterior |
| VR_LIMITE_IMP_PAGO_EXT | N | 13 | Limite do imposto pago no exterior |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  18

TOTAIS CALCULADOS DA DECLARAÇÂO COM DESC. SIMPLIFICADO

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| VR_RENDTRIB | N | 13 | Valor do Rendto+Rendto. Atividade Rural +PF+Exterior do Titular + dependente. |
| VR_DESCSIMP | N | 13 | Desconto Simplificado |
| VR_BASECALC | N | 13 | Base de cálculo do imposto |
| VR_IMPDEVIDO | N | 13 | Total do Imposto devido |
| VR_IMPOSTO | N | 13 | Imposto retido na fonte-Titular e dependente |
| VR_IMPCOMP | N | 13 | Imposto complementar. e pago no exterior-Titular e Dependente |
| VR_LEAO | N | 13 | Carnê-leão, imposto complementar. e pago no exterior-Titular e Dependente |
| VR_IRFONTELEI11033 | N | 13 | Valor Retido na Fonte (Lei Nº 11.033/2004)-Titular e Dependente |
| VR_IMPRESTIT | N | 13 | Saldo do imposto a restituir |
| VR_IMPPAGAR | N | 13 | Saldo do Imposto a pagar |
| NR_QUOTAS | N | 1 | Numero de quotas |
| VR_QUOTA | N | 13 | Valor da quota |
| VR_TOTISENTO | N | 13 | Rendimento Isentos e não tributáveis - Titular e dependente |
| VR_TOTEXCLUSIVO | N | 13 | Rendimento sujeitos a Tributação exclusiva -Titular e dependente |
| FILLER | N | 13 | FILLER |
| VR_RENDTRIBDEPENDENTE | N | 13 | Valor do Rendimento PJ - Dependente |
| VR_IMPOSTODEPENDENTE | N | 13 | Imposto retido na fonte - Dependente |
| VR_IMPPAGARESPECIE | N | 13 | Imposto a Pagar Ganhos de Capital - Moeda em Espécie |
| VR_TOTRENDTRIBPJTITULAR | N | 13 | Total do rendimento Tributável PJ - Titular |
| VR_RENDTRIBARURAL | N | 13 | Total do rendimento AR-Brasil e Ext.(Linha 7 da ficha Apuração do Resultado |
| VR_TOTFONTETITULAR | N | 13 | Total do Imposto Retido na Fonte - Titular |
| VR_TOTBENSANOBASEANTERIOR | N | 13 | Total dos bens do ano anterior ao ano base |
| VR_TOTBENSANOBASE | N | 13 | Total dos bens do ano base |
| VR_RENDISENTOTITULAR | N | 13 | Total Rend. isentos/Não tributáveis - Titular |
| VR_RENDISENTODEPENDENTES | N | 13 | Total Rend. isentos/Não tributáveis - Depend. |
| VR_TOTRENDEXCLUSTITULAR | N | 13 | Total Rend. Tributação Exclusiva - Titular |
| VR_RENDEXCLUSDEPENDENTES | N | 13 | Total Rend. Tributação Exclusiva - Depend. |
| VR_RESNAOTRIB_AR | N | 13 | Total Não Tributável(Linha 11 do Resultado da AR, se Brasil e Linha 10, se Exterior.) |
| VR_TOTDIVIDAANOBASEANTERIOR | N | 13 | Total das dívidas do ano anterior ao ano base |
| VR_TOTDIVIDAANOBASE | N | 13 | Total das dívidas do ano base |
| VR_TOTIRFONTELEI11033 | N | 13 | Valor Retido na Fonte (Lei Nº 11.033/2004) - Titular+Dependente+Renda Variável+Ganho de Capital em PS |
| VR_SUBTOTALISENTOTRANSPORTE | N | 13 | Subtotal dos rendimentos isentos e não tributáveis |
| VR_SUBTOTALEXCLUSIVOTRANSPORTE | N | 13 | Subtotal dos rendimentos sujeitos à  tributação exclusiva |
| VR_GANHOLIQUIDORVTRANSPORTE | N | 13 | Ganhos líquidos em renda variável |
| VR_RENDISENTOGCTRANSPORTE | N | 13 | Parcela isenta proveniente dos Ganhos de Capital |
| VR_RENDPFEXT | N | 13 | Total de Rendimentos Recebidos de PF/exterior pelo titular |
| VR_RENDPFEXTDEPEN | N | 13 | Total de Rendimentos Recebidos de PF/exterior pelos dependentes |
| VR_DOACOESCAMPANHA | N | 13 | Total de Doacoes a Campanha Eleitoral |
| VR_TOTRENDPJ_EXIB_SUSPTITULAR | N | 13 | Total de Rendimentos Recebidos de PF-exigibilidade suspensa pelo titular |
| VR_TOTRENDPJ_EXIB_SUSPDEPEN | N | 13 | Total de Rendimentos Recebidos de PF-exigibilidade suspensa pelo dependente |
| VR_TOTDEPJUDIC_TITULAR | N | 13 | Total de depósitos judiciais-exigibilidade suspensa pelo titular |
| VR_TOTDEPJUDIC_DEPENDEN | N | 13 | Total de depósitos judiciais-exigibilidade suspensa pelos dependentes |
| VR_TOTREND_AC_TIT | N | 13 | Total de Rendimentos Recebidos acumuladamente pelo titular |
| VR_TOT_IRF_AC_TIT | N | 13 | Total IRF RRA - pelo titular |
| VR_TOT_IMPOSTO_RRA_TIT | N | 13 | Total IMPOSTO RRA - pelo titular |
| VR_TOTREND_AC_DEP | N | 13 | Total de Rendimentos Recebidos acumuladamente pelos dependentes |
| VR_TOT_IRF_AC_DEP | N | 13 | Total IRF RRA - pelos dependentes |
| VR_TOT_IMPOSTO_RRA_DEP | N | 13 | Total IMPOSTO RRA - pelos dependentes |
| VR_TOT_IMPOSTO_DEVIDO | N | 13 | Total do Imposto devido (incluindo RRA) |
| VR_IMPOSTO_DIFERIDO_GCAP | N | 13 | Imposto diferido GCAP |
| VR_IMPOSTO_DEVIDO_GCAP | N | 13 | Imposto devido sobre ganho de capital |
| VR_IMPOSTO_GANHOLIQ_RVAR | N | 13 | Imposto devido sobre ganho liquido em renda variável |
| VR_IMPOSTO_DEVIDO_GCME | N | 13 | Imposto devido sobre ganho de capital moeda estrangeira - bens, direitos e aplicações financeiras |
| VR_IMPEXT | N | 13 | Imposto pago no exterior(após cálculo do limite) |
| VR_ALIQUOTA_EFETIVA | N | 5 | Calculo do imposto - valor da aliquota efetiva |
| VR_BASE_CALCULO_LEI_14754 | N | 13 | Base de cálculo final de aplicações financeiras no exterior Obs.: Esse campo pode receber valores negativos. |
| VR_IMPOSTO_DEVIDO_LEI_14754 | N | 13 | Imposto devido final com aplicações financeiras no exterior |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  19

COMPLETA - DECLARAÇÃO COM DESC. CALCULADO

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_FONTE | C | 14 | CNPJ-CPF principal fonte pagadora |
| VR_IMPEXT | N | 13 | Valor do imposto pago exterior |
| VR_IMPCOMP | N | 13 | Valor do imposto complementar pago |
| VR_IRFONTELEI11033 | N | 13 | Valor Retido na Fonte Lei n 11.033-2004 |
| VR_RECEX_TIT | N | 13 | Rendimentos recebidos do ExteriorTitular |
| VR_LIVCAIX_TIT | N | 13 | Livro caixaTitular |
| VR_CARNELEAO_TIT | N | 13 | Valor pago Carnê-LeãoTitular |
| VR_RECEX_DEP | N | 13 | Rendimentos recebidos do ExteriorDependentes |
| VR_LIVCAIX_DEP | N | 13 | Livro caixaDependentes |
| VR_CARNELEAO_DEP | N | 13 | Valor pago Carnê-LeãoDependentes |
| VR_PREVPRIV | N | 13 | Contribuição previdenciária privada |
| VR_FAPI | N | 13 | Contribuição FAPI |
| VR_PREVOFTITULAR | N | 13 | Total da contribuição previdenciária oficial do Titular (Exceto RRA) |
| VR_PREVOFDEPENDENTE | N | 13 | Total da contribuição previdenciária oficial do Dependente (Exceto RRA) |
| VR_TOTAL13TITULAR | N | 13 | Total do décimo terceiro salário do Titular |
| VR_TOTAL13DEPENDENTE | N | 13 | Total do décimo terceiro salário do Dependente |
| NR_DEPENDENTE_DESP_INSTRUCAO | N | 5 | Numero de Dependentes com despesa de instrução |
| NR_ALIMENTANDO_DESP_INSTRUCAO | N | 5 | Numero de Alimentandos com despesa de instrução |
| VR_RENDPF_TIT | N | 13 | Total de Rendimentos Recebidos de PF pelo titular |
| VR_RENDPF_DEPEND | N | 13 | Total de Rendimentos Recebidos de PF pelos dependentes |
| VR_RENDEXT_TIT | N | 13 | Total de Rendimentos Recebidos do exterior pelo titular |
| VR_RENDEXT_DEPEND | N | 13 | Total de Rendimentos Recebidos do exterior pelos dependentes |
| VR_IMPDEVIDO_SEM_REND_EXT | N | 13 | Imposto devido sem o rendimento do exterior |
| VR_LIMITE_IMP_PAGO_EXT | N | 13 | Limite do imposto pago no exterior |
| VR_ATE_LIMITE_FUNPRESP | N | 13 | Valor da FUNPRESP ate o limite do ente patrocionador |
| VR_ACIMA_LIMITE_FUNPRESP | N | 13 | Valor da FUNPRESP acima do limite do ente patrocionador |
| NR_CONTROLE | N | 10 | Número de Controle |

### Lotes 2X

#### Tipo:  20

TOTAIS DA DECLARAÇÂO COM DESC. CALCULADO

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| VR_RENDJUR | N | 13 | Rendimentos recebidos Pessoa JurídicaTitular |
| VR_RENDPFEXT | N | 13 | Total de Rendimentos Recebidos de PF, aluguéis, outros e exterior pelo titular |
| VR_RENDPFEXTDEPEN | N | 13 | Total de Rendimentos Recebidos de PF, aluguéis, outros e exterior pelos dependentes |
| VR_RESAR | N | 13 | Resultado da Atividade Rural |
| VR_TOTTRIB | N | 13 | Total de Rendimentos tributáveis |
| VR_PREVOF_FUNPRESP_LIMITE | N | 13 | Contribuição previdenciária oficial + FUNPRESP (Ate o limite do Ente) |
| VR_TOTPRIVADA_FAPI_FUNPRESP | N | 13 | Previdência privada + FAPI + FUNPRESP (acima do limite do ente) limitada a 12 Rend.Trib. |
| VR_DEPEN | N | 13 | Dedução com dependentes |
| VR_DESPINST | N | 13 | Despesas com instrução |
| VR_DESPMEDIC | N | 13 | Despesas médicas |
| VR_PENSAO | N | 13 | Pensão Alimentícia Judicial |
| VR_PENSAO_CARTORIO | N | 13 | Pensão Alimentícia por escritura pública |
| VR_LIVCAIX | N | 13 | Livro caixaTitular + Dependente |
| VR_DEDUC | N | 13 | Total das deduções |
| VR_BASECALC | N | 13 | Base de cálculo do imposto |
| VR_IMPOSTO | N | 13 | Valor do Imposto |
| VR_DEDIMPOSTO | N | 13 | Dedução do impostodedução de incentivo limitada a 6 do valor do imposto |
| VR_IMPDEV1 | N | 13 | Imposto menos deduções de incentivo. |
| VR_CONTRIBPREV | N | 13 | Contribuição Prev. Social emp. doméstico |
| VR_IMPDEV2 | N | 13 | Imposto devido I menos Contribuição Prev. Social emp. doméstico. |
| VR_IMPDEV3 | N | 13 | Imposto devido 2 mais imposto devido RRA |
| VR_IMPFONTE | N | 13 | Imposto na fonte - Titular |
| VR_CARNELEAO | N | 13 | Valor pago Carnê-LeãoTitular + Dependente |
| VR_IMPCOMPL | N | 13 | Imposto complementar |
| VR_IMPEXT | N | 13 | Imposto pago no exteriorapós cálculo do limite |
| VR_IRFONTELEI11033 | N | 13 | Valor Retido na Fonte Lei n 11.033-2004-Ficha Imposto Pago |
| VR_TOTIMPPAGO | N | 13 | Total do imposto pago |
| VR_IMPREST | N | 13 | Imposto a restituir |
| VR_IMPPAGAR | N | 13 | Imposto a pagar |
| NR_QUOTAS | N | 1 | Quantidade de quotas |
| VR_QUOTA | N | 13 | Valor de cada quota |
| VR_BENSANT | N | 13 | Total de Bens e Direitos do ano anterior |
| VR_BENSATUAL | N | 13 | Total de Bens e Direitos do ano atual |
| VR_DIVIDAANT | N | 13 | Total de Ônus e Dívidas do ano anterior |
| VR_DIVIDAATUAL | N | 13 | Total de Ônus e Dívidas do ano atual |
| FILLER | N | 13 | FILLER |
| VR_TOTISENTOS | N | 13 | Total dos Rendimentos isentos -Titular e Dependente |
| VR_TOTEXCLUS | N | 13 | Total dos Rendimentos exclusivos - Titular e Dependente |
| VR_IMPGC | N | 13 | Imposto sobre Ganhos de Capital |
| VR_TOTIRFONTELEI11033 | N | 13 | Valor Retido na Fonte Lei n 11.033-2004-Ficha Outras InformaçõesImposto Pago + GC em PS + RV |
| VR_IMPRV | N | 13 | Imposto sobre Renda Variável |
| VR_RENDJURDEPENDENTE | N | 13 | Rendimentos recebidos Pessoa Jurídica - Dependente |
| VR_IMPFONTEDEPENDENTE | N | 13 | Imposto na fonte - Dependente |
| VR_IMPPAGOVCBENS | N | 13 | Imposto Pago Moeda Estrangeira-Bens,Dir e Aplic.Fin. |
| VR_IMPPAGOVCESPECIE | N | 13 | Imposto a Pagar Ganhos de Capital - Moeda em Espécie |
| VR_TOTRENDISENTOSITULAR | N | 13 | Total de Rendimentos isentos do Titular |
| VR_TOTRENDISENTOSDEPENDENTE | N | 13 | Total de Rendimentos isentos do Dependente |
| VR_TOTRENDEXCLTITULAR | N | 13 | Total de Rendimentos exclusivos do Titular |
| VR_TOTRENDEXCLDEPENDENTE | N | 13 | Total de Rendimentos exclusivos do Dependente |
| VR_TOTDOACOESCAMPANHA | N | 13 | Total de doações da campanha eleitoral |
| VR_TOTRENDPJ_EXIB_SUSPTITULAR | N | 13 | Total de Rendimentos Recebidos de PJ-exigibilidade suspensa pelo titular |
| VR_TOTRENDPJ_EXIB_SUSPDEPENDEN | N | 13 | Total de Rendimentos Recebidos de PJ-exigibilidade suspensa pelos dependentes |
| VR_TOTDEPJUDIC_TITULAR | N | 13 | Total de depósitos judiciais-exigibilidade suspensa pelo titular |
| VR_TOTDEPJUDIC_DEPENDEN | N | 13 | Total de depósitos judiciais-exigibilidade suspensa pelos dependentes |
| VR_TOTREND_AC_TIT | N | 13 | Total de Rendimentos Recebidos acumuladamente pelo titular |
| VR_TOT_PREVOFC_AC_TIT | N | 13 | Total previdência oficial RRA - pelo titular |
| VR_TOT_PENSALI_AC_TIT | N | 13 | Total Pensão Alimentícia RRA - pelo titular |
| VR_TOT_IRF_AC_TIT | N | 13 | Total IRF RRA - pelo titular |
| VR_TOT_IMPOSTO_RRA_TIT | N | 13 | Total IMPOSTO RRA - pelo titular |
| VR_TOTREND_AC_DEP | N | 13 | Total de Rendimentos Recebidos acumuladamente pelos dependentes |
| VR_TOT_PREVOFC_AC_DEP | N | 13 | Total previdência oficial RRA - pelos dependentes |
| VR_TOT_PENSALI_AC_DEP | N | 13 | Total Pensão Alimentícia RRA - pelos dependentes |
| VR_TOT_IRF_AC_DEP | N | 13 | Total IRF RRA - pelos dependentes |
| VR_TOT_IMPOSTO_RRA_DEP | N | 13 | Total IMPOSTO RRA - pelos dependentes |
| VR_IMPOSTO_DIFERIDO_GCAP | N | 13 | Imposto diferido GCAP |
| VR_IMPOSTO_DEVIDO_GCAP | N | 13 | Imposto devido sobre ganho de capital |
| VR_IMPOSTO_GANHOLIQ_RVAR | N | 13 | Imposto devido sobre ganho liquido em renda variável |
| VR_IMPOSTO_DEVIDO_GCME | N | 13 | Imposto devido sobre ganho de capital moeda estrangeira - bens, direitos e aplicações financeiras |
| VR_ALIQUOTA_EFETIVA | N | 5 | Calculo do imposto - valor da aliquota efetiva |
| VR_BASE_CALCULO_LEI_14754 | N | 13 | Base de cálculo final de aplicações financeiras no exterior Obs.: Esse campo pode receber valores negativos. |
| VR_IMPOSTO_DEVIDO_LEI_14754 | N | 13 | Imposto devido final com aplicações financeiras no exterior |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  21

RENDIMENTOS TRIBUTÁVEIS RECEBIDOS DE PESSOAS JURÍDICAS

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_PAGADOR | N | 14 | CNPJ fonte pagadora |
| NM_PAGADOR | N | 60 | nome fonte pagadora |
| VR_RENDTO | C | 13 | Valor rendimento recebido |
| VR_CONTRIB | A | 13 | Valor contribuição previdenciária oficial |
| VR_DECTERC | N | 13 | Valor décimo terceiro salário |
| VR_IMPOSTO | N | 13 | Valor imposto retido na fonte |
| DT_COMUNICACAO_SAIDA | C | 8 | Data da comunicação de saída à  fonte pagadora |
| VR_IRRF13SALARIO | N | 13 | Valor imposto retido na fonte sobre o 13 salario |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  22

REND. TRIB. RECEBIDOS DE PESSOAS FÍSICAS,EXTERIOR E (CARNÊ-LEÃO)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| E_DEPENDENTE | I | 1 | Indicativo se registro de dependenteS ou TitularN |
| NR_CPF_DEPEN | C | 11 | CPF do Dependente |
| NR_MES | N | 2 | Mês de ocorrência |
| VR_RENDTO | N | 13 | Valor rendimentos recebidos |
| VR_ALUGUEIS | N | 13 | Valor rendimentos recebidos de alugueis |
| VR_OUTROS | N | 13 | Valor rendimentos recebidos outros |
| VR_EXTER | N | 13 | Valor rendimento recebido no exterior |
| VR_LIVCAIX | N | 13 | Valor dedução livro-caixa |
| VR_ALIMENT | N | 13 | Valor dedução com pensão alimentícia |
| VR_DEDUC | N | 13 | Valor dedução com dependente |
| VR_PREVID | N | 13 | Valor pago previdência |
| VR_BASECALCULO | N | 13 | Valor Base de cálculo rendimentos - deduções |
| VR_IMPOSTO | N | 13 | Valor imposto pagoCarnê-Leão |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  23

RENDIMENTOS ISENTOS E NÃO TRIBUTÁVEIS

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_COD_ISENTO | N | 4 | Código do rendimento isento e não tributavel |
| VR_VALOR | N | 13 | Valor do rendimento |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  24

RENDIMENTOS SUJEITOS A TRIBUTAÇÂO EXCLUSIVA

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_COD_EXCLUSIVO | N | 4 | Código do rendimento de tributação exclusivo |
| VR_VALOR | N | 13 | Valor do rendimento |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  25

DEPENDENTES

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Numero de chave do dependente |
| CD_DEPEND | C | 2 | Código da relação de dependência |
| NM_DEPEND | A | 60 | nome do dependente |
| DT_NASCIM | N | 8 | Data de nascimento DDMMAAAA |
| NI_DEPEND | C | 11 | CPF do dependente |
| IN_SAIDA | N | 1 | Indicador de saída junto com o declarante |
| NR_NITPISPASEP | C | 11 | informação do NIT/PIS/PASEP informação constante na ficha de Pessoa Fisica no Exterior. Sem valor informado campo em branco. |
| IN_ENDERECO_TITULAR | C | 1 | Indicativo se dependente mora com o titular (Valor 0 ou 1) |
| NM_EMAIL | C | 90 | Endereço contribuinte: Email - Correio Eletrônico |
| NR_DDD_CELULAR | C | 2 | Numero do ddd do celular |
| NR_CELULAR | C | 9 | Numero do celular |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  26

RELAÇÃO DE PAGAMENTOS EFETUADOS

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CD_PAGTO | N | 2 | Código de doações e pagamentos |
| NR_CHAVE_DEPEND | N | 5 | Numero de chave do dependente |
| NR_BENEF | C | 14 | CNPJ-CPF do beneficiário ou do Emp. Doméstico |
| NM_BENEF | A | 60 | nome do beneficiário |
| NR_NIT_EMP_DOM | N | 11 | NIT do empregado doméstico |
| VR_PAGTO | N | 13 | Valor do pagamento ou doação |
| VR_REDUC | N | 13 | Valor da parcela não dedutível ou reembolsada |
| VR_EFPC | N | 13 | Contribuição EFPC |
| IN_TIPO_CPF_CNPJ | N | 1 | Indicador se CPF ou CNPJ |
| IN_TIPO_PGTO | C | 1 | formato de pagamento: T - Titular, D - Dependente, A - Alimentando |
| NM_DESCRICAO | C | 512 | Descrição do pagamento |
| CD_PAIS | N | 3 | Código do País, se bem no Exterior |
| NM_PAIS | C | 40 | nome do País |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  27

DECLARAÇÃO DE BENS E DIREITOS

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CD_BEM | N | 2 | formato do bem ou direito |
| IN_EXTERIOR | N | 1 | 0 se imóvel no Brasil 1 se imóvel no Exterior |
| CD_PAIS | N | 3 | Código do País, se bem no Exterior |
| NM_PAIS | C | 40 | nome do País |
| TX_BEM | C | 512 | Descrição do bem |
| VR_ANTER | N | 13 | Valor em 31 de dezembro de 2009 |
| VR_ATUAL | N | 13 | Valor em 31 de dezembro de 2010 |
| NM_LOGRA | C | 40 | Endereço contribuinte: logradouro |
| NR_NUMERO | C | 6 | Endereço contribuinte: número |
| NM_COMPLEM | C | 40 | Endereço contribuinte: complemento |
| NM_BAIRRO | C | 40 | Endereço contribuinte: bairro |
| NR_CEP | C | 9 | Endereço contribuinte: CEP ou ZIP Exterior |
| SG_UF | C | 2 | Endereço contribuinte: UF |
| CD_MUNICIP | N | 4 | Endereço contribuinte: código do município |
| NM_MUNICIP | C | 40 | Endereço contribuinte: município |
| NM_IND_REG_IMOV | N | 1 | Indicador do tipo de imóveis |
| MATRIC_IMOV | A | 40 | Matrícula do imóvel |
| FILLER1 | A | 40 | tipo do imóvel |
| AREA | N | 11 | ?ea do imóvel |
| NM_UNID | N | 1 | Unidade de medida |
| NM_CARTORIO | A | 60 | nome do cartorio |
| NR_CHAVE_BEM | N | 5 | Chave de identificação do bem |
| DT_AQUISICAO | N | 8 |  |
| FILLER2 | C | 20 |  |
| FILLER3 | C | 7 |  |
| FILLER | C | 1 | filler |
| NR_RENAVAN | C | 30 |  |
| NR_DEP_AVIACAO_CIVIL | C | 30 |  |
| NR_CAPITANIA_PORTOS | C | 30 |  |
| NR_AGENCIA | N | 4 |  |
| FILLER4 | C | 13 |  |
| NR_DV_CONTA | C | 2 |  |
| NM_CPFCNPJ | C | 14 |  |
| NR_IPTU | C | 30 |  |
| NR_BANCO | N | 3 | Codigo do Banco |
| IN_TIPO_BENEFIC | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| CD_GRUPO_BEM | C | 2 | Grupo do Bem |
| IN_BEM_INVENTARIAR | N | 1 | Indicador de bem a inventariar |
| NR_CONTA | C | 20 | Número da conta bancária |
| NR_CIB | C | 8 | Número do cib |
| NR_CEI_CNO | N | 12 | Némro do cei cno |
| IN_BOLSA | N | 1 | Negociado em bolsa 0-Não(Padrão) 1-Sim |
| NR_COD_NEGOCIACAO_BOLSA | A | 20 |  |
| IN_CUSTODIANTE | N | 1 | 0- Nao (padrao) 1- Sim |
| COD_ALTCOIN | C | 10 |  |
| COD_STABLECOIN | C | 10 |  |
| VR_LUCRO_PREJUIZO_APLICACAO_FINANCEIRA | N | 13 | Lucro ou prejuízo de aplicação financeira no exterior |
| VR_IMPOSTO_PAGO_EXTERIOR_APLICACAO_FINANCEIRA | N | 13 | Imposto pago sobre aplicação financeira no exterior |
| VR_RECEBIDO_LUCROS_DIVIDENDOS | N | 13 | Valor recebido sobre lucros e dividendos |
| VR_IMPOSTO_PAGO_EXTERIOR_LUCROS_DIVIDENDOS | N | 13 | Imposto pago no exterior sobre lucros e dividendos |
| IN_CONTA_PAGAMENTO | N | 1 | Indicador se conta pagamento |
| IN_RECLASSIFICAR | N | 1 | Indicador de necessidade de reclassificação de tipo de bem de um ano para o outro. Este campo não exibido para o usuário. |
| IN_PROCESSO_ATUALIZACAO_BEM | C | 1 | O contribuinte fez atualização de algum bem de acordo com a Lei 14973 DE 16/09/2024 0-Não (padrão) 1-Sim |
| NR_CONTROLE | N | 10 | no de Controle |

#### Tipo:  28

DÍVIDAS E ÔNUS REAIS

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CD_DIV | N | 2 | formato da dívida |
| TX_DIV | C | 512 | Descrição da dívida |
| VR_ANTER | N | 13 | Valor em 31 de dezembro de 2009 |
| VR_ATUAL | N | 13 | Valor em 31 de dezembro de 2010 |
| VR_PAGAMENTOANUAL | N | 13 | Valor do pagamento anual |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  29

Registro 29 não Presente na documentação

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CONJ | C | 11 | CPF do cônjuge |
| VR_BASE | N | 13 | Base de cálculo |
| VR_IMPOSTO | N | 13 | Total do imposto |
| VR_ISENTO | N | 13 | Rend. Isentos e não tributáveis |
| VR_EXCLUSIVO | N | 13 | Rend. Tribut. Exclusivo Fonte |
| VR_RENDPJ_EXIB_SUSP | N | 13 | Resultado dos (Rendimentos Recebidos de PJ [Imposto com Exigibilidade Suspensa] - Depósitos Judiciais do Imposto) do titular e dos dependentes |
| VR_TOTALCONJ | N | 13 | Resultado total do cônjuge |
| IN_ENTREGOU | C | 1 | Indicativo o cônjuge entregou S ou Não N declaração no periodo |
| NR_CONTROLE | N | 10 | Número de Controle |

### Lotes 3X

#### Tipo:  30

INFORMAÇÕES DO INVENTARIANTE (SOMENTE SE DECLARAÇÃO FOR DE AJUSTE ANUAL)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_INVENT | C | 11 | CPF do inventariante |
| NM_INVENT | C | 60 | nome do inventariante |
| FILLER | C | 69 | FILLER |
| IN_SOBREPARTILHA | C | 1 | Indicador de sobrepartilha |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  31

Registro 31 não Presente na documentação

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Chave de identificação da pensão, proventos de aposentadoria ou reforma por moléstia grave ou aposentadoria ou reforma por acidente em serviço |
| IN_TIPO | C | 1 | Indicador se o registro é do Titular ou do Dependente |
| NR_PAGADORA | C | 14 | CPF/CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_RECEB | N | 13 | Valor do recebimento |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| VR_13SALARIO | N | 13 | Valor do 13 Salario |
| VR_IRRF | N | 13 | Valor do IRRF |
| VR_IRRF13SALARIO | N | 13 | Valor do IRRF sobre 13 Salario |
| VR_PREVIDENCIA | N | 13 | valor da previdência oficial |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  32

REND. TRIB. RECEBIDOS DE PESSOAS JURÍDICAS DOS DEPENDENTES

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CPF_BENEF | C | 11 | CPF do Dependente |
| NR_PAGADOR | C | 14 | CNPJ da fonte pagadora |
| NM_PAGADOR | C | 60 | nome da fonte pagadora |
| VR_RENDTO | N | 13 | Valor do rendimento recebido |
| VR_CONTRIB | N | 13 | Valor contribuição previdenciária oficial |
| VR_DECTERC | N | 13 | Valor décimo terceiro salário |
| VR_IMPOSTO | N | 13 | Valor do imposto retido na fonte |
| DT_COMUNICACAO_SAIDA | C | 8 | Data da comunicação de saída à  fonte pagadora |
| VR_IRRF13SALARIO | N | 13 | Valor imposto retido na fonte sobre o 13 salario |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  33

Registro 33 não Presente na documentação

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Chave de identificação do Lucro |
| IN_TIPO | C | 1 | Indicador se o registro é do Titular ou do Dependente |
| NR_PAGADORA | C | 14 | CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_LUCRO | N | 13 | Valor do Lucro ou Dividendo recebido |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  34

DOAÇÕES A PARTIDOS

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_PARTIDO | C | 14 | CNPJ do Partido ou Candidato |
| NM_PARTIDO | C | 60 | nome do Partido ou Candidato |
| VR_DOACAO | N | 13 | Valor da doação |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  35

ALIMENTANDO

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| INDICADOR_RESIDENCIA | C | 1 | Indicador de residência do alimentando: 0-Brasil 1-Exterior |
| NR_CHAVE | N | 5 | Identificador do alimentando |
| NM_NOME | C | 60 | nome do alimentando |
| DT_NASCIM | C | 8 | Data de nascimento DDMMAAAA |
| NI_ALIMENTANDO | C | 11 | CPF do alimentando |
| NR_CPF_VINCULADO | C | 11 | CPF vinculado |
| IN_TIPO_PROCESSO | C | 1 | Tipo de processo: J - Judicial, C – Cartorio,  A – Ambos |
| NR_PROCESSOJUDICIAL | C | 25 | Número do processo judicial |
| NR_IDENTIFICACAOVARACIVIL | C | 4 | Identificação da vara civil |
| NM_COMARCA | C | 30 | Nome da Comarca |
| DT_DECJUDICIAL | C | 8 | Data da decisão judicial |
| SG_UFCOMARCA | C | 2 | UF da Comarca |
| NR_CNPJ_CARTORIO | C | 14 | CNPJ do Cartório |
| NM_CARTORIO | C | 60 | Nome do Cartório |
| DT_LAVRATURA | C | 8 | Data da lavratura |
| NM_LIVRO | C | 7 | Número do Livro de Registro |
| NM_FOLHA | C | 7 | Folhas do Livro de Registro |
| CD_MUNICIP | C | 4 | Endereço contribuinte: código do município |
| NM_MUNICIPIO | C | 40 | Nome do município do Cartório |
| SG_UFCARTORIO | C | 2 | UF do Cartório |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  36

Registro 36 não Presente na documentação

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE_BEM | N | 5 | Chave de identificação do bem |
| NR_CPF_CNPJ | C | 14 | CPF/CNPJ Proprietário/Usufrutuário |
| CD_GRUPO_BEM | C | 2 | Grupo do Bem |
| CD_BEM | N | 2 | Tipo do bem ou direito |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  37

Registro 37 não Presente na documentação

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE_BEM | N | 5 | Chave de identificação do bem |
| NR_ORDEM | N | 5 | Número da linha da tabela do demonstrativo |
| TIPO | N | 1 | Tipo de Rendimento 1 = Aplicações Financeiras 2 = Lucros e Dividendos |
| VR_GANHO_PREJUIZO | N | 13 | Valor recebido informado no bem Obs.: Esse campo pode receber valores negativos. |
| VR_IMPOSTO_DEVIDO | N | 13 | 15% do Ganho. Apenas se o valor do campo VR_GANHO_PREJUIZO for positivo |
| VR_IMPOSTO_PAGO_EXTERIOR_BRASIL | N | 13 | Valor informado no bem |
| VR_BASE_CALCULO | N | 13 | Base de Cálculo |
| VR_SALDO | N | 13 | Somar o valor da Base de Cálculo se positivo ou compensá-lo se negativo. Obs.: Esse campo pode receber valores negativos. |
| CD_GRUPO_BEM | C | 2 | Grupo do Bem |
| CD_BEM | N | 2 | Tipo do bem ou direito |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  38

FINAL DE ESPOLIO (SOMENTE SE DECLARAÇÃO FOR DE ESPÓLIO)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_ANOOBITO | N | 4 | Ano do óbito |
| FILLER | C | 11 | FILLER |
| NR_CPF_INVENT | C | 11 | CPF do inventariante |
| NM_INVENT | C | 60 | nome do inventariante |
| FILLER | C | 68 | FILLER |
| IN_SOBREPARTILHA | C | 1 | Indicador de sobrepartilha |
| IN_STATUS_SOBREPARTILHA | C | 1 | Indicador do status da sobrepartilha |
| IN_TIPO_PROCESSO | C | 1 | formato de processo: J - Judicial, C - Cartorio |
| NR_PROCESSOJUDICIAL | C | 25 | Número do processo judicial |
| NR_VARACIVIL | C | 4 | Identificação da vara civil |
| NM_COMARCA | C | 30 | nome da Comarca |
| DT_DECJUDICIALPARTILHA | N | 8 | Data da decisão judicial da partilha |
| DT_TRANSITOJULGADO | N | 8 | Data do trânsito em julgado da decisão judicial da partilha |
| SG_UFCOMARCA | C | 2 | UF da Comarca |
| NR_CNPJ_CARTORIO | C | 14 | CNPJ do Cartório |
| NM_CARTORIO | C | 60 | nome do Cartório |
| NM_LIVRO | C | 7 | Número do Livro de tipo |
| NM_FOLHA | C | 7 | Folhas do Livro de tipo |
| NM_MUNICIPIO | C | 40 | nome do município do Cartório |
| SG_UFCARTORIO | C | 2 | UF do Cartório |
| DT_LAVRATURA | N | 8 | Data da lavratura da partilha |
| IN_MORTEAMBOSCONJUGES | C | 1 | Morte de ambos os cônjuges e inventário único: 0 - Não, 1 - Sim, 2 - Não é morte de ambos |
| NM_CONJUGE | A | 60 | nome do cônjuge ou companheiro |
| IN_BENS_INVENTARIAR | C | 1 | Bens a iventariar: Sim - 1, Não - 0 |
| FILLER | C | 9 | (CPF do cônjuge ou companheiro) informação constará apenas no registro de identificação REG 16 |
| IN_MEEIRO | C | 1 | indicador se meeiro 0 - Não, 1 - Sim |
| IN_INVENTARIOCONJUNTO | C | 1 | Inventário único: 0 - Não, 1 - Sim |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  39

SAÍDA DEFINITIVA (SOMENTE SE DECLARACAO DE SAIDA DEFINITIVA)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_PROCURADOR | C | 11 | CPF do Procurador |
| NM_PROCURADOR | A | 60 | nome do Procurador |
| NM_END_PROCURADOR | C | 80 | Endereço completo do Procurador |
| DT_NAORESIDENTE | N | 8 | Data da caracterização da condição de não-residente |
| DT_RESIDENTE | N | 8 | Data da caracterização da condição de residente no país |
| CD_NOVO_PAIS_RESIDENCIA | N | 3 | Novo país de residência |
| NM_PAIS | C | 40 | nome do País |
| NR_CONTROLE | N | 10 | Número de Controle |

### Lotes 4X

#### Tipo:  40

RENDA VARIÁVEL RESUMO DA APURAÇÃO DE GANHOS (Mensal)(valores detalhados por CPF)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| RV_MES | N | 2 | Mês da operação |
| GC_COMUM_MVISTA_ACOES | N | 13 | Operações Comuns - Mercado à  Vista - Ações |
| GC_COMUM_MVISTA_OURO | N | 13 | Operações Comuns - Mercado à  Vista - Ouro |
| GC_COMUM_MVISTA_OUROFORA | N | 13 | Operações Comuns - Mercado à  Vista - Ouro fora da bolsa |
| GC_COMUM_MOPC_ACOES | N | 13 | Operações Comuns - Mercado do Opções - Ações |
| GC_COMUM_MOPC_OURO | N | 13 | Operações Comuns - Mercado de Opções - Ouro |
| GC_COMUM_MOPC_OUROFORA | N | 13 | Operações Comuns - Mercado de Opções - Ouro fora da bolsa |
| GC_COMUM_MOPC_OUTROS | N | 13 | Operações Comuns - Mercado de Opções - Outros |
| GC_COMUM_MFUT_DOLAR | N | 13 | Operações Comuns - Mercado Futuro - Dólar dos EUA |
| GC_COMUM_MFUT_INDICES | N | 13 | Operações Comuns - Mercado Futuro - �?ndices |
| GC_COMUM_MFUT_JUROS | N | 13 | Operações Comuns - Mercado Futuro - Juros |
| GC_COMUM_MFUT_OUTROS | N | 13 | Operações Comuns - Mercado Futuro - Outros |
| GC_COMUM_MTERMO_ACOESOURO | N | 13 | Operações Comuns - Mercado a Termo - Ações-Ouro |
| GC_COMUM_MTERMO_OUTROS | N | 13 | Operações Comuns - Mercado a Termo - Outros |
| GC_DAYTR_MVISTA_ACOES | N | 13 | Operações Day-Trade - Mercado à  Vista - Ações |
| GC_DAYTR_MVISTA_OURO | N | 13 | Operações Day-Trade - Mercado à  Vista - Ouro |
| GC_DAYTR_MVISTA_OUROFORA | N | 13 | Operações Day-Trade - Mercado à  Vista - Ouro fora da bolsa |
| GC_DAYTR_MOPC_ACOES | N | 13 | Operações Day-Trade - Mercado do Opções - Ações |
| GC_DAYTR_MOPC_OURO | N | 13 | Operações Day-Trade - Mercado de Opções - Ouro |
| GC_DAYTR_MOPC_OUROFORA | N | 13 | Operações Day-Trade - Mercado de Opções - Ouro fora da bolsa |
| GC_DAYTR_MOPC_OUTROS | N | 13 | Operações Day-Trade - Mercado de Opções - Outros |
| GC_DAYTR_MFUT_DOLAR | N | 13 | Operações Day-Trade - Mercado Futuro - Dólar dos EUA |
| GC_DAYTR_MFUT_INDICES | N | 13 | Operações Day-Trade - Mercado Futuro - �?ndices |
| GC_DAYTR_MFUT_JUROS | N | 13 | Operações Day-Trade - Mercado Futuro - Juros |
| GC_DAYTR_MFUT_OUTROS | N | 13 | Operações Day-Trade - Mercado Futuro - Outros |
| GC_DAYTR_MTERMO_ACOESOURO | N | 13 | Operações Day-Trade - Mercado à  Termo - Ações-Ouro |
| GC_DAYTR_MTERMO_OUTROS | N | 13 | Operações Day-Trade - Mercado à  Termo - Outros |
| VR_FONTE_DAYTRADE | N | 13 | IR fonte de Day-Trade no mês |
| VR_IMPOSTOPAGO | N | 13 | Valor do imposto pago |
| VR_IMPRENDAFONTE | N | 13 | Valor Retido na Fonte Lei n 11.033-2004 |
| VRRESULT_NEG_MESANT_COMUM | N | 13 | Resultado negativo até o mês anterior-Comuns |
| VRRESULT_NEG_MESANT_DAYTR | N | 13 | Resultado negativo até o mês anterior-Day-Trade |
| VR_FONTE_DAYTRADEANTERIORJANEIRO | N | 13 | IR fonte de Day-Trade-Esse campo só existe no mês de janeiro |
| VR_RESLIQUIDO_MES_OPCOMUNS | N | 13 | Resultado Líquido do mês, para as operações comuns |
| VR_RESLIQUIDO_MES_DAYTRADE | N | 13 | Resultado Líquido do mês, para as operações day-trade |
| VR_BASECALCULO_MES_OPCOMUNS | N | 13 | Base de Cálculo do Imposto, para as operações comuns |
| VR_BASECALCULO_MES_DAYTRADE | N | 13 | Base de Cálculo do Imposto, para as operações day-trade |
| VR_PREJACOMPENSAR_MES_OPCOMUNS | N | 13 | Prejuízo a Compensar, para as operações comuns |
| VR_PREJACOMPENSAR_MES_DAYTRADE | N | 13 | Prejuízo a Compensar, para as operações day-trade |
| VR_ALIQUOTA_IMPOSTO_OPCOMUNS | N | 3 | Valor da alíquota15 |
| VR_ALIQUOTA_IMPOSTO_DAYTRADE | N | 3 | Valor da alíquota20 |
| VR_IMPOSTODEVIDO_MES_OPCOMUNS | N | 13 | Imposto Devido, para as operações comuns |
| VR_IMPOSTODEVIDO_MES_DAYTRADE | N | 13 | Imposto Devido, para as operações day-trade |
| VR_TOTAL_IMPDEVIDO | N | 13 | Total do Imposto Devido |
| VR_IRFONTE_MESESANT_DAYTRADE | N | 13 | IR Fonte de Day-trade meses anteriores |
| VR_IRFONTE_DAYTRADE_ACOMPENSAR | N | 13 | IR Fonte de Day-trade a Compensar |
| VR_IMPOSTOAPAGAR | N | 13 | Imposto a Pagar |
| VR_IRF_MESESANT | N | 13 | Valor Retido na Fonte Lei n 11.033-2004 meses anteriores |
| VR_IRF_COMPENSAR | N | 13 | Valor Retido na Fonte Lei n 11.033-2004 meses anteriores |
| E_DEPENDENTE | I | 1 | Indicativo se registro de dependente(S) ou Titular(N) |
| NR_CPF_DEPEN | C | 11 | CPF do dependente |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  41

RENDAVAR - TOTAIS DE ALGUNS CAMPOS-RENDA VARIÁVELCOMUNS E DAYTRADE( Anual)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| VR_TOTALANUALRESULTADOLIQUIDOSRENDAVARIAVEL_COMUNSDT | N | 13 | Resultado Líquido do mês, para as operações comuns e day-trade nos meses de jan a dez |
| VR_TOTALANUALRESULTADONEGATIVOMESANTERIOR_COMUNSDT | N | 13 | Resultado negativo até o mês anterior, para as operações comuns e day-trade do mês de Dezembro |
| VR_TOTALANUALBASECALCULOIMPOSTO_COMUNSDT | N | 13 | Base de Cálculo do Imposto, para as operações comuns e day-trade nos meses de jan a dez |
| VR_TOTALANUALPREJUIZOCOMPENSAR_COMUNSDT | N | 13 | Prejuízo a Compensar, para as operações comuns e day-trade do mês de Dezembro |
| VR_TOTALANUALIMPOSTODEVIDO_CCOMUNSDT | N | 13 | Imposto Devido, para as operações comuns e day-trade nos meses de jan a dez |
| VR_TOTALANUALIMPOSTODEVIDOCONSOLIDACAO | N | 13 | Total do Imposto Devido nos meses de jan a dez |
| VR_TOTALANUALFONTEDAYTRADEMESESANTERIOR | N | 13 | IR Fonte de Day-trade meses anteriores do mês de Dezembro |
| VR_TOTALANUALFONTEDAYTRADECOMPENSAR | N | 13 | IR Fonte de Day-trade a Compensar do mês de Dezembro |
| VR_TOTALANUALIRFONTELEI11033 | N | 13 | Imposto Retido na Fonte Lei 11.033 nos meses de jan a dez |
| VR_TOTALANUALIMPOSTOPAGAR | N | 13 | Imposto a Pagar nos meses de jan a dez |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  42

RENDA VARIÁVEL – FUNDOS DE INVESTIMENTO IMOBILIÁRIO (Mensal)(Valores detalhados por CPF)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_MES | N | 2 | Mês da operação |
| VR_RESLIQUIDO_MES | N | 13 | Resultado Líquido do mês |
| VRRESULT_NEG_MESANT | N | 13 | Resultado negativo até o mês anterior |
| VR_BASECALCULO_MES | N | 13 | Base de Cálculo do Imposto |
| VR_PREJACOMPENSAR_MES_OPCOMUNS | N | 13 | Prejuízo a Compensar |
| VR_ALIQUOTA_IMPOSTO_OPCOMUNS | N | 3 | Valor da alíquota20 |
| VR_IMPOSTODEVIDO_MES_OPCOMUNS | N | 13 | Imposto Devido |
| VR_IMPOSTO_RETIDO_MESES_ANTERIORES | N | 13 | Valor do Imposto Retido meses anteriores |
| VR_IMPOSTO_RETIDO_FONTE | N | 13 | Valor do Imposto Retido no mês |
| VR_IMPOSTO_RETIDO_COMPENSAR | N | 13 | Valor do Imposto a Compensar (Lei 11.033/2004) |
| VR_IMPOSTO_PAGAR | N | 13 | Valor do Imposto a Pagar |
| VR_IMPOSTOPAGO | N | 13 | Valor do imposto pago |
| E_DEPENDENTE | I | 1 | Indicativo se registro de dependente(S) ou Titular(N) |
| NR_CPF_DEPEN | C | 11 | CPF do dependente |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  43

RENDAVAR - TOTAIS DE ALGUNS CAMPOS-RENDA VARIÁVEL - FII( Anual)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| VR_TOTALANUALRESULTADOLIQUIDOSRENDAVARIAVEL_FII | N | 13 | Resultado Líquido do mês, para as operações FII nos meses de jan a dez |
| VR_TOTALANUALRESULTADONEGATIVOMESANTERIOR_FII | N | 13 | Resultado negativo até o mês anterior, para as operações FII do mês de Dezembro |
| VR_TOTALANUALBASECALCULOIMPOSTO_FII | N | 13 | Base de Cálculo do Imposto, para as operações FII nos meses de jan a dez |
| VR_TOTALANUALPREJUIZOCOMPENSAR_FII | N | 13 | Prejuízo a Compensar, para as operações FII do mês de Dezembro |
| VR_TOTALANUALIMPOSTODEVIDO_FII | N | 13 | Imposto Devido, para as operações FII nos meses de jan a dez |
| VR_TOTALANUALIMPOSTOPAGAR | N | 13 | Imposto a pagar para as operações FII nos meses de jan a dez |
| VR_TOTALANUALIMPOSTORETIDONAFONTE_FII | N | 13 | Imposto retido lei 11033/2004 para as operações FII nos meses de jan a dez |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  45

REND RECEBIDOS ACUMULADAMENTE TITULAR 

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CD_RRA_TITULAR | N | 2 | Código de RRA Titular |
| NR_PAGADOR | C | 14 | CPF ou CNPJ da fonte pagadora |
| NM_PAGADOR | C | 60 | nome fonte pagadora |
| VR_RENDTO | N | 13 | Valor rendimento recebido |
| VR_CONTRIB | N | 13 | Valor contribuição previdenciária oficial |
| VR_PENSAO | N | 13 | Valor da pensão alimenticia |
| VR_IMPOSTO | N | 13 | Valor imposto retido na fonte |
| NR_MES_RECEBIMENTO | N | 2 | Mês do recebimento |
| FILLER | C | 6 | Espaços em branco |
| OPCAO_TRIBUTACAO | N | 1 | Opção de tributação escolhida |
| NUM_MESES | N | 4 | Numero de meses |
| IMPOSTO_RRA | N | 13 | Imposto RRA |
| VR_ISENTO_65 | N | 13 | Valor isento de 65 anos |
| VR_VALOR_TRIBUTAVEL | N | 13 | Valor tributável |
| VR_JUROS | N | 13 | Valor do pagamento de juros |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  46

RELAÇÃO DE PENSAO RRA TITULAR

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CD_RRA_TITULAR | N | 2 | Código de RRA Titular |
| NR_CHAVE_ALIMENT | N | 5 | Numero de chave do alimentando |
| VR_PAGTO | N | 13 | Valor do pagamento de pensão |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  47

REND RECEBIDOS ACUMULADAMENTE DEPENDENTE

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CD_RRA_DEPENDENTE | N | 2 | Código de RRA Dependente |
| CPF_BENEF | C | 11 | CPF do Dependente |
| NR_PAGADOR | C | 14 | CPF ou CNPJ da fonte pagadora |
| NM_PAGADOR | C | 60 | nome fonte pagadora |
| VR_RENDTO | N | 13 | Valor rendimento recebido |
| VR_CONTRIB | N | 13 | Valor contribuição previdenciária oficial |
| VR_PENSAO | N | 13 | Valor da pensão alimenticia |
| VR_IMPOSTO | N | 13 | Valor imposto retido na fonte |
| NR_MES_RECEBIMENTO | N | 2 | Mês do recebimento |
| FILLER | C | 6 | Espaços em branco |
| OPCAO_TRIBUTACAO | N | 1 | Opção de tributação escolhida |
| NUM_MESES | N | 4 | Numero de meses |
| IMPOSTO_RRA | N | 13 | Imposto RRA |
| VR_ISENTO_65 | N | 13 | Valor isento de 65 anos |
| VR_VALOR_TRIBUTAVEL | N | 13 | Valor tributável |
| VR_JUROS | N | 13 | Valor do pagamento de juros |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  48

RELAÇÃO DE PENSAO RRA DEPENDENTE

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CD_RRA_DEPENDENTE | N | 2 | Código de RRA Dependente |
| NR_CHAVE_ALIMENT | N | 5 | Numero de chave do alimentando |
| VR_PAGTO | N | 13 | Valor do pagamento de pensão |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  49

LANÇAMENTOS PESSOAS FÍSICAS E EXTERIOR (CARNÊ-LEÃO)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF_TITULAR | C | 11 | CPF contribuinte |
| NR_CPF_DEPENDENTE | C | 11 | CPF dependente |
| NR_MES | N | 2 | Mês de ocorrência |
| NR_CPF_TITULAR_PAGAMENTO | C | 11 | CPF do titular do pagamento |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_VALOR | N | 13 | valor do pagamento |
| NR_CONTROLE | N | 10 | Número de Controle |

### Lotes 5X

#### Tipo:  50

ANEXO DA ATIVIDADE RURAL - IDENTIFICAÇÃO DO CONTRIBUINTE

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_EXTERIOR | N | 1 | 0 se imóvel no Brasil - 1 se imóvel no Exterior |
| FILLER | C | 8 | filler |
| NM_IMOVEL | C | 60 | nome do imóvel |
| NM_LOCAL | C | 55 | Localização do imóvel |
| QT_AREA | N | 10 | Área do imóvel ha |
| PC_PARTIC | N | 5 | Percentual de participação no imóvel |
| CD_EXPLOR | C | 1 | Código da condição de exploração |
| CD_ATIV | C | 2 | Código atividade Rural Agricultura, pecuária , etc |
| NR_INCRA | C | 8 | Número do Imóvel na SRF |
| NR_CHAVE_AR | N | 5 | chave para associar participantes |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  51

ANEXO DA ATIVIDADE RURAL - RECEITAS E DESPESAS - BRASIL

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_EXTERIOR | N | 1 | Somente'0' - imóvel no Brasil |
| NR_MES | N | 2 | Mês de ocorrência |
| VR_DESP | N | 13 | Valor das despesas |
| VR_REC | N | 13 | Valor das receitas |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  52

ANEXO DA ATIVIDADE RURAL - APURAÇÃO DO RESULTADO TRIBUTÁVEL

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_EXTERIOR | N | 1 | 0 se imóvel no Brasil - 1 se imóvel no Exterior |
| VR_RECTOTAL | N | 13 | Receita Bruta Total (L01-Ficha Apuração Resultado Tributável).Se imóvel no Exterior(1),será zerado. |
| VR_DESPTOTAL | N | 13 | Despesas de custeio e investimento (L02). Se imóvel no Exterior(1),será zerado. |
| VR_RES1REAL | N | 13 | Resultado 1 (L03 = L01 - L02) |
| VR_PREJEXERCANT | N | 13 | Prejuízo do exercício anterior (L04) |
| VR_COMP_PREJ_EXERC_ANT | N | 13 | Compensação de prejuízo(s) de exercício(s) anteriores (L05) |
| VR_OPCAO | N | 13 | Limite de 20% sobre Rec. Bruta (L06) |
| VR_RESTRIB | N | 13 | Resultado Tributável (L07) |
| VR_PREJUIZO | N | 13 | Prejuízo a compensar (L08) |
| VR_RECVENDAFUTURA | N | 13 | Receita recebida por conta de venda para entrega futura (L09) |
| VR_ADIANT | N | 13 | Valor do adiantamento até 2002 referentes aos produtos entregues em 2004 do quadro apuração do resultado (L10 do programa) |
| VR_RESNAOTRIBAR | N | 13 | Apuração do resultado da Ativ. Rural (L11 do programa e L10 do formulário) |
| VR_RES1DOLAR | N | 13 | Resultado I - US$-Linha 01 da ficha Apuração do Resultado da A.R. no Exterior.(Quando imóvel no Brasil, será zerado). |
| IN_OPC_APURRESTRIB | N | 1 | Opção pela forma de apuração de resultado tributável. |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  53

ANEXO DA ATIVIDADE RURAL - MOVIMENTAÇÃO DO REBANHO

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_EXTERIOR | N | 1 | 0 se imóvel no Brasil - 1 se imóvel no Exterior |
| CD_ESPEC | N | 1 | Código da espécie 1 a 5, sendo 5 = outros |
| QT_INIC | N | 10 | Estoque Inicial |
| QT_COMPRA | N | 10 | Compras |
| QT_NASCIM | N | 10 | Nascimentos |
| QT_PERDA | N | 10 | Perdas e consumo |
| QT_VENDA | N | 10 | Vendas |
| QT_ESTFINAL | N | 10 | Estoque final |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  54

ANEXO DA ATIVIDADE RURAL - BENS

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_EXTERIOR | N | 1 | 0 se imovel no Brasil 1 se imovel no Exterior |
| CD_PAIS | N | 3 | Codigo do Pais |
| NM_PAIS | C | 40 | nome do Pais se bem no Exterior |
| CD_BEMAR | N | 2 | formato do bem ou direito |
| TX_BEM | C | 512 | obs do bem |
| VR_BEM | N | 13 | Valor atual do bem |
| VR_BEM_ANTERIOR | N | 13 | Valor anterior do bem |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  55

ANEXO DA ATIVIDADE RURAL - DÍVIDAS

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_EXTERIOR | C | 1 | 0 se imóvel no Brasil - 1 se imóvel no Exterior |
| TX_DIVIDA | C | 512 | Discriminação da dívida |
| VR_DIVATE | N | 13 | Valor da dívida até o ano anterior |
| VR_DIVATU | N | 13 | Valor da dívida do ano-calendário |
| VR_PAGAMENTOANUAL | N | 13 | Valor do pagamento anual |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  56

ANEXO DA ATIVIDADE RURAL – RECEITAS E DESPESAS - EXTERIOR

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CD_PAIS | N | 3 | Código do País |
| NM_PAIS | C | 40 | nome do País |
| RECBRUTA | N | 13 | Receita Bruta Anual - Moeda Original |
| DESPCUSTEIO | N | 13 | Despesas de Custeio-Investimento- Moeda Original |
| RESORIGINAL | N | 13 | Resultado I - Moeda original |
| RESDOLAR | N | 13 | Resultado I - US$ |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  57

ANEXO DA ATIVIDADE RURAL – PROPRIETARIO DO IMOVEL RURAL 

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | Tipo do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CPF_CNPJ_PROPRIETARIO | C | 14 | CPF/CNPJ do propretario |
| NM_NOME_PROPRIETARIO | C | 60 | Nome_proprietario imovel Rural |
| IN_EXTERIOR | C | 1 | 0-Não 1-Sim |
| NR_CHAVE_AR | N | 5 | chave para associar participantes |
| NR_CONTROLE | N | 10 | Numero de controle |

#### Tipo:  58

HERDEIROS (SOMENTE SE ESPÓLIO)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE_HERDEIRO | N | 5 | Chave de identificação do herdeiro |
| NM_NOME | C | 60 | nome Herdeiro |
| NR_CPF_CNPJ | C | 14 | CPF/CNPJ Herdeiro |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  59

PERCENTUAL DO BEM (SOMENTE SE ESPÓLIO)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE_BEM | N | 5 | Chave de identificação do bem |
| NR_CHAVE_HERDEIRO | N | 5 | Chave de identificação do herdeiro |
| VR_PERCENTUAL | N | 5 | Percentual |
| NR_CONTROLE | N | 10 | Número de Controle |

### Lotes 6X

#### Tipo:  60

GANHO DE CAPITAL

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CPF_BENEFICIARIO | C | 11 | CPF declarante do GCAP |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| DT_INICIO | N | 8 | Data início permanência (DDMMAAAA) |
| DT_FIM | N | 8 | Data fim permanência(DDMMAAAA) |
| CD_PAIS | N | 3 | Código do país |
| NM_PAIS | C | 60 | Identificação da declaração |
| GC_TRANSP_VR_EXCLUSIVO | N | 13 | Somatório do rendimento sujeito à tributação exclusiva da ficha Cálculo do imposto , à vista e a prazo, de imóvel, móvel e participação societária, importados do Programa Ganhos de Capital. |
| GC_TRANSP_VR_PEQUENO | N | 13 | Este valor e transportado para Rendimento do tipo 5 da ficha Rendimentos Isentos e Não Tributáveis, importado do Programa Ganhos de Capital. |
| GC_TRANSP_VR_UNICOIMOVEL | N | 13 | Este valor e transportado para Rendimento do tipo 6 da ficha Rendimentos Isentos e Não Tributáveis, importado do Programa Ganhos de Capital. |
| GC_TRANSP_VR_REDUCAO | N | 13 | Este valor e transportado para Rendimento do tipo 7 da ficha Rendimentos Isentos e Não Tributáveis, importado do Programa Ganhos de Capital, excluídos os valores referentes ao GCME. |
| GC_TRANSP_VR_IMPOSTOPAGO | N | 13 | Somatório do imposto pago da ficha Cálculo do imposto , à vista e a prazo, de imóvel, móvel e participação societária, importados do Programa Ganhos de Capital. |
| GC_TRANSP_VR_IMPOSTODEVIDO | N | 13 | Somatório do imposto devido de imóvel, móvel e participação societária, importados do Programa Ganhos de Capital. |
| GC_TRANSP_VR_ISENTRIB | N | 13 | Somatório do VR_PEQUENO, VR_ÚNICO_IMOVEL e VR_REDUCAO |
| GC_TRANSP_VR_IMPOSTODIFERIDOANOSPOSTERIORES | N | 13 | Valor do imposto diferido anos posteriores |
| GC_GCAP_MOEDA | N | 13 | Ganho de capital total de moeda especie |
| GC_IMPOSTO_DEVIDO_MOEDA | N | 13 | Valor do imposto devido em moeda |
| GC_MOEDA_ALIQUOTA_MEDIA | N | 9 | Valor da aliquota media em moeda |
| GC_TRANSP_VR_EXCLUSIVO_EXTERIOR | N | 13 | Somatório do rendimento sujeito à tributação exclusiva da ficha 'Consolidado' , à vista e a prazo, de imóvel, móvel, importados do Programa Ganhos de Capital. Apenas Exterior |
| GC_TRANSP_VR_IMPOSTOPAGO_EXTERIOR | N | 13 | Somatório do imposto pago da ficha 'Consolidado' , à vista e a prazo, de imóvel, móvel, importados do Programa Ganhos de Capital. Apenas Exterior |
| GC_TRANSP_VR_ISENTO_EXTERIOR | N | 13 | Somatório do rendimento isento da ficha 'Consolidado', à vista e a prazo, de imóvel, móvel, importados do Programa Ganhos de Capital. Apenas Exterior |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  61

GCAP – BEM IMOVEL

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CPF_BENEFICIARIO | C | 11 | CPF declarante do GCAP |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| IN_BRASIL_EXTERIOR | N | 1 | Indicação de brasil exterior |
| NM_IMOVEL_DESCRICAO | C | 152 | Descrição do bem alienado (Especificação) |
| END_TIPO_LOGRADOURO | C | 15 | Endereço do bem: tipo de logradouro |
| END_LOGRADOURO | C | 40 | Endereço do bem: logradouro |
| END_NUMERO | C | 6 | Endereço do bem: número  |
| END_COMPLEMENTO | C | 21 | Endereço do bem: complemento |
| END_BAIRRO | C | 20 | Endereço do bem: bairro |
| END_CEP | C | 9 | Endereço do bem: CEP (Brasil) ou ZIPExterior (Exterior) |
| END_CD_MUNICIPIO | N | 4 | Endereço do bem: código do município (Brasil) ; Exterior em branco |
| END_MUNICIPIO | C | 40 | Endereço do bem: município (Brasil) ; Cidade (Exterior) |
| END_UF | C | 2 | Endereço do bem: UF (Brasil) ; Exterior em branco |
| END_COD_PAIS | C | 3 | Endereço do bem: (Brasil) em Branco ; Exterior código do país |
| END_NOME_PAIS | C | 60 | Endereço do bem: (Brasil) em Branco ; Exterior nome do país |
| DT_AQUISICAO | N | 8 | Data aquisição |
| VR_AQUISICAO | N | 13 | Valor de aquisição |
| IN_REFORMA | C | 1 | indicador de reforma ou ampliação |
| IN_PEQUENO_VALOR | C | 1 | Perguntas se o bem é maior que 35000,00 |
| IN_PROPR_OUTRO_IMOVEL | C | 1 | Pergunta sobre propriedade de outro imóvel para imóvel com valor de alienação entre 35.000,00 e  440.000,00 |
| IN_OUTRA_ALIENACAO | C | 1 | Indicador de outra alienação nos últimos 05 anos |
| IN_RESIDENCIAL | C | 1 | Se imoveil é residencial ou comercial |
| IN_UTILIZAZAOOUTROIMOVEL | C | 1 | Pergunta se o valor vai ser aplicado na compra do outro imovel. |
| VR_UTILIZAZAOOUTROIMOVEL | N | 13 | Campo de preenchimento para informar valor aplicado em outro imóvel. |
| CD_OPERACAO | N | 2 | Código da Natureza da Operação |
| NM_OPERACAO | C | 70 | Descrição da Natureza da Operação |
| IN_DECISAO_JUDICIAL | C | 1 | indicador de decisão judicial ou escritura publica |
| DT_ALIENACAO | N | 8 | Data de alienação |
| DT_DECISAO_JUDICIAL | N | 8 | Data da decisão judicial |
| DT_LAVRATURA | N | 8 | Data da lavratura |
| DT_TRANSITO_JULGADO | N | 8 | Data do trânsito julgado |
| IN_ALIENPRAZO | C | 1 | Indicador de alienação à prazo |
| VR_OPERACAO | N | 13 | Valor da operação |
| VR_CORRETAGEM | N | 13 | Custo de corretagem |
| VR_TORNA | N | 13 | valor da torna |
| IN_GCAP_ANTERIOR | C | 1 | indicador de alienação parcial anterior |
| VR_GCAP_ANTERIOR | N | 13 | valor da alienação parcial anterior |
| VR_OPERACAO_BRUTO_ANT | N | 13 | (Seção Calculo do imposto) Valor bruto da operação de anos anteriores. |
| VR_CORRETAGEM_ANT | N | 13 | (Seção Calculo do imposto) Valor bruto da corretagem de anos anteriores. |
| VR_GCAP_CI_ANT_LIGUIDO | N | 13 | (Seção Calculo do imposto) Valor Líquido da operação de anos anteriores. |
| VR_GCAP_CI | N | 13 | (Seção Calculo do Imposto) ganho de capital a ser considerado para calculo do imposto. |
| VR_ALIQUOTA_MEDIA_CI | N | 9 | (Seção Calculo do Imposto) A vista: Aliquota Média porcentagem. |
| VR_IMPOSTO_DEVIDO_CI | N | 13 | Imposto devido |
| VR_IMPOSTO_PAGO_CI | N | 13 | imposto pago |
| VR_RECEBIDO_CL | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total Recebido das parcela |
| VR_CORRETAGEM_CL | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total da corretagem das parcelas |
| VR_VALOR_LIQUIDO | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total liquido das parcelas |
| VR_AQUISICAO_PROPORCIONAL_CL | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total aquisição das parcelas |
| VR_DIFERIDO_ANTERIORES_CB | N | 13 | (Seção Consolidação) Valor do imposto diferido de anos anteriores |
| VR_EXERCICIO_CB | N | 13 | (Seção Consolidação) Valor do imposto referente ao exercicio |
| VR_TOTAL_CB | N | 13 | (Seção Consolidação) total do imposto |
| VR_IR_CB | N | 13 | (Seção Consolidação) Ir na fonte Lei 11033/2004 |
| VR_IR_DEVIDO_CB | N | 13 | (Seção Consolidação) imposto devido no exercicio |
| VR_DIFERIDO_POSTERIOR_CB | N | 13 | (Seção Consolidação) Valor do imposto diferido para anos posteriores |
| VR_IMPOSTO_PAGO_CB | N | 13 | (Seção Consolidação) Imposto pago |
| VR_ISENTO_CB | N | 13 | (Seção Consolidação) Rendimento isento e não tributável |
| VR_EXCLUSIVO_CB | N | 13 | (Seção Consolidação)  Rendimento exclusivo e não tributável |
| DT_DATA_DARF_TCM | N | 8 | Data de vencimento do darf quanto se trata de TCM |
| DT_DATA_ULTIMA_PARCELA | N | 8 | Data de vencimento da ultima parcela |
| IND_TER_PARAISO_FISCAL | C | 1 | indicador paraíso fiscal ou território paraíso fiscal |
| CD_PAIS_PARAISO_FISCAL | N | 3 | Código do país que o contribuinte estava no ato da alienação |
| IN_MULTIPLO_IMOVEL | C | 1 |  |
| DT_DATA_MULTIPLO_IMOVEL | N | 8 |  |
| IN_UTILIZACAOOUTROIMOVEL_PARTE2 | C | 1 | Quanto do valor vai ser aplicado na compra do outro imóvel. |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  62

GCAP – BEM MOVEL

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CPF_BENEFICIARIO | C | 11 | CPF declarante do GCAP |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| IN_BRASIL_EXTERIOR | N | 1 | Indicação de brasil exterior |
| NM_MOVEL_DESCRICAO | C | 152 | Descrição do bem alienado (Especificação) |
| IN_REGISTRO_PUBLICO | C | 1 | Indicador de Possui registro público |
| DT_AQUISICAO | N | 8 | Data de aquisição |
| VR_AQUISICAO | N | 13 | Valor de aquisição |
| IN_PEQUENO_VALOR | C | 1 | Indicador  o conjunto de bens ou direitos da mesma natureza alienados é superior a  35.000,00 |
| CD_OPERACAO | N | 2 | Código da Natureza da Operação |
| NM_OPERACAO | C | 70 | Descrição da Natureza da Operação |
| IN_DECISAO_JUDICIAL | C | 1 | indicador de decisão judicial ou escritura publica |
| DT_ALIENACAO | N | 8 | Data de alienação |
| DT_DECISAO_JUDICIAL | N | 8 | Data da decisão judicial |
| DT_LAVRATURA | N | 8 | Data da lavratura |
| DT_TRANSITO_JULGADO | N | 8 | Data do trânsito julgado |
| IN_ALIENPRAZO | C | 1 | Indicador de alienação à prazo |
| VR_OPERACAO | N | 13 | Valor da operação |
| VR_CORRETAGEM | N | 13 | custo de corretagem |
| IN_GCAP_ANTERIOR | C | 1 | Indicador de alienação parcial anterior |
| VR_GCAP_ANTERIOR | N | 13 | valor da alienação parcial anterior |
| VR_OPERACAO_BRUTO_ANT | N | 13 | (Seção Calculo do imposto) Valor bruto da operação de anos anteriores. |
| VR_CORRETAGEM_ANT | N | 13 | (Seção Calculo do imposto) Valor bruto da corretagem de anos anteriores. |
| VR_GCAP_CI_ANT_LIGUIDO | N | 13 | (Seção Calculo do imposto) Valor Líquido da operação de anos anteriores. |
| VR_GCAP_CI | N | 13 | (Seção Calculo do Imposto) ganho de capital a ser considerado para calculo do imposto. |
| VR_ALIQUOTA_MEDIA_CI | N | 9 | (Seção Calculo do Imposto) A vista: Aliquota Média porcentagem. |
| VR_IMPOSTO_DEVIDO_CI | N | 13 | imposto devido |
| VR_IMPOSTO_PAGO_CI | N | 13 | imposto pago |
| VR_RECEBIDO_CL | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total Recebido das parcela |
| VR_CORRETAGEM_CL | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total da corretagem das parcelas |
| VR_VALOR_LIQUIDO | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total liquido das parcelas |
| VR_AQUISICAO_PROPORCIONAL_CL | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total aquisição das parcelas |
| VR_DIFERIDO_ANTERIORES_CB | N | 13 | (Seção Consolidação) Valor do imposto diferido de anos anteriores |
| VR_EXERCICIO_CB | N | 13 | (Seção Consolidação) Valor do imposto referente ao exercicio |
| VR_TOTAL_CB | N | 13 | (Seção Consolidação) total do imposto |
| VR_IR_CB | N | 13 | (Seção Consolidação) Ir na fonte Lei 11033/2004 |
| VR_IR_DEVIDO_CB | N | 13 | (Seção Consolidação) imposto devido no exercicio |
| VR_DIFERIDO_POSTERIOR_CB | N | 13 | (Seção Consolidação) Valor do imposto diferido para anos posteriores |
| VR_IMPOSTO_PAGO_CB | N | 13 | (Seção Consolidação) Imposto pago |
| VR_ISENTO_CB | N | 13 | (Seção Consolidação) Rendimento isento e não tributável |
| VR_EXCLUSIVO_CB | N | 13 | (Seção Consolidação)  Rendimento exclusivo e não tributável |
| DT_DATA_DARF_TCM | N | 8 | Data de vencimento do darf quanto se trata de TCM |
| DT_DATA_ULTIMA_PARCELA | N | 8 | Data de vencimento da ultima parcela |
| IND_TER_PARAISO_FISCAL | C | 1 | indicador paraíso fiscal ou território paraíso fiscal |
| CD_PAIS_PARAISO_FISCAL | N | 3 | Código do país que o contribuinte estava no ato da alienação |
| NR_CONTROLE | N | 10 | Número de controle |

#### Tipo:  63

GCAP - PARTICIPAÇÃO SOCIETARIA

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | Número do registro |
| NR_CPF | N | 11 | cpf do contribuinte |
| NR_CPF_BENEFICIARIO | N | 11 | cpf do declarante do gcap |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| NM_SOCIEDADE | C | 152 | nome da sociedade |
| NR_CNPJ | N | 14 | cnpj da sociedade |
| CD_MUNICIPIO | N | 4 | código do município |
| NM_MUNICIPIO | C | 40 | nome do município |
| NM_UF | C | 2 | UF |
| CD_OPERACAO | N | 2 | Código da natureza |
| NM_OPERACAO | C | 70 | Descrição da natureza |
| CD_ESPECIE | C | 1 | código da espécie de participação |
| NM_ESPECIE | C | 90 | descrição da espécie de participação |
| IN_DECISAO_JUDICIAL | C | 1 | flag que indica se TCM é por decisão judicial |
| DT_ALIENACAO | N | 8 | data de alienação |
| DT_DECISAO_JUDICIAL | N | 8 | data da decisão judicial |
| DT_LAVRATURA | N | 8 | data da lavratura |
| DT_TRANSITO_JULGADO | N | 8 | data do trânsito julgado |
| IN_ALIENPRAZO | C | 1 | flag de alienação a prazo |
| VR_OPERACAO | N | 13 | Valor da operação |
| VR_CORRETAGEM | N | 13 | custo de corretagem |
| IN_PEQUENO_VALOR | C | 1 | Indicador  o conjunto de bens ou direitos da mesma natureza alienados é superior a  20.000,00 |
| IN_GCAP_ANTERIOR | C | 1 | flag de alienação parcial anterior |
| VR_GCAP_ANTERIOR | N | 13 | valor da alienação parcial anterior |
| VR_VALOR_ALIENACAO_AP | N | 13 | Seção Apuração) valor da alienação |
| VR_CUSTO_CORRETAGEM_AP | N | 13 | Seção Apuração) custo de corretagem |
| VR_LIGUIDO_ALIENACAO_AP | N | 13 | Seção Apuração) valor líquido |
| VR_CUSTO_AQUISICAO_AP | N | 13 | Seção Apuração) custo de aquisição |
| VR_GCAP_AP | N | 13 | Seção Apuração) ganho de capital |
| VR_OPERACAO_BRUTO_ANT | N | 13 | (Seção Calculo do imposto) Valor bruto da operação de anos anteriores. |
| VR_CORRETAGEM_ANT | N | 13 | (Seção Calculo do imposto) Valor bruto de corretagem de anos anteriores. |
| VR_GCAP_CI_ANT_LIGUIDO | N | 13 | (Seção Calculo do imposto) Valor líquido da operação de anos anteriores. |
| VR_GCAP_CI | N | 13 | (Seção Calculo do Imposto) ganho de capital |
| VR_ALIQUOTA_MEDIA_CI | N | 9 | (Seção Calculo do Imposto) alíquota média |
| VR_IMPOSTO_DEVIDO_CI | N | 13 | (Seção Calculo do Imposto) imposto devido |
| VR_IRRF_CI | N | 13 | (Seção Calculo do Imposto) imposto retido na fonte |
| VR_IMPOSTO_DEVIDO_APOS_COMPENSACAO_CI | N | 13 | (Seção Calculo do Imposto) imposto devido após compensação |
| VR_IMPOSTO_PAGO_CI | N | 13 | (Seção Calculo do Imposto) imposto pago |
| VR_RECEBIDO_CL | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total Recebido das parcela |
| VR_CORRETAGEM_CL | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total da corretagem das parcelas |
| VR_VALOR_LIQUIDO | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total liquido das parcelas |
| VR_AQUISICAO_PROPORCIONAL_CL | N | 13 | (Seção Calculo do Imposto) A vista: Valor zerado. A prazo:Total aquisição das parcelas |
| VR_DIFERIDO_ANTERIORES_CB | N | 13 | (Seção Consolidação) Valor do imposto diferido de anos anteriores |
| VR_EXERCICIO_CB | N | 13 | (Seção Consolidação) Valor do imposto referente ao exercício |
| VR_TOTAL_CB | N | 13 | (Seção Consolidação) total do imposto |
| VR_IR_CB | N | 13 | (Seção Consolidação) IR na fonte Lei 11033/2004 |
| VR_IR_DEVIDO_CB | N | 13 | (Seção Consolidação) imposto devido no exercício após Lei 11033/2004 |
| VR_DIFERIDO_POSTERIOR_CB | N | 13 | (Seção Consolidação) Valor do imposto diferido para anos posteriores |
| VR_IMPOSTO_PAGO_CB | N | 13 | (Seção Consolidação) Imposto pago |
| VR_ISENTO_CB | N | 13 | (Seção Consolidação) Rendimento isento e não tributável |
| VR_EXCLUSIVO_CB | N | 13 | (Seção Consolidação)  Rendimento exclusivo e tributação definitiva |
| VR_CUSTO_TOTAL_AQUISICAO | N | 13 | (Seção Apuração do custo de aquisição) Valor do custo total consolidado  |
| DT_DATA_DARF_TCM | N | 8 | Data de vencimento do darf quanto se trata de TCM |
| DT_DATA_ULTIMA_PARCELA | N | 8 | Data de vencimento da ultima parcela |
| IND_TER_PARAISO_FISCAL | C | 1 | indicador paraíso fiscal ou território paraíso fiscal |
| CD_PAIS_PARAISO_FISCAL | N | 3 | Código do país que o contribuinte estava no ato da alienação |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  64

GCAP - DECARACAO EXTERIOR

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | Número do registro |
| NR_CPF | N | 11 | cpf do contribuinte |
| NR_CPF_BENEFICIARIO | N | 11 | cpf do declarante do gcap |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| IN_TIPO | C | 1 | flag de alienação a prazo |
| VR_COTACAO_OP | N | 13 | cotaçaõ do dolar na operação |
| VR_OPERACAO_DOLAR | N | 13 | (Seção Operação) Valor nominal da operação |
| VR_CORRETAGEM_DOLAR | N | 13 | (Seção Operação) custo corretagem da operação |
| VR_TORNA_ME_DOLAR | N | 13 | (Seção Operação) Custo de Torna ME |
| VR_TORNA_MN_DOLAR | N | 13 | (Seção Operação) Custo de Torna MN |
| VR_VALOR_ALIENACAO_AP_AMBAS | N | 13 | (Seção Apuração) valor da alienação independente da moeda |
| VR_CUSTO_CORRETAGEM_AP_AMBAS | N | 13 | (Seção Apuração) valor da corretagem independente da moeda |
| VR_LIQUIDO_ALIENACAO_AP_AMBAS | N | 13 | (Seção Apuração) valor da corretagem independente da moeda |
| VR_GCAP_TOTAL_AP_AMBAS | N | 13 | (Seção Apuração) GCAP total em ambas as moedas |
| IN_ORIGEM_REND | C | 1 | flag de alienação a prazo |
| NM_ORIGEM_REND_DESC | C | 60 | nome da origem dos rendimentos |
| VR_COTACAO_AQUISICAO | N | 13 | Seção Aquisição contação do dolar na data de aquisição |
| VR_BEM_AQUISICAO_DOLAR | N | 13 | (Seção Aquisição) sem reforma: Valor em Dolar - com reforma: Totalizador do bem |
| VR_BEM_AQUISICAO_RMN | N | 13 | Seção Aquisição Ambas as moedas - valor total das parcela em moeda nacional  (Dolar) |
| FT_BEM_AQUISICAO_RMN | N | 5 | Seção Aquisição Porcentagem do bem originado de moeda nacional quando ambas as moedas |
| VR_BEM_AQUISICAO_RME | N | 13 | Seção Aquisição Ambas as moedas - valor total das parcela em moeda estrangeira  (Dolar) |
| FT_BEM_AQUISICAO_RME | N | 5 | Seção Aquisição Porcentagem do bem originado de moeda estrangeira quando ambas as moedas |
| COD_PAIS_ACORDO | N | 3 | Código do país |
| NM_COD_PAIS_ACORDO | C | 60 | Identificação da declaração |
| VR_IMPOSTO_REAL_ACORDO | N | 13 | Seção Identificação Valor do imposto acordo em reais |
| VR_GCAP_TOTAL_AJUSTE | N | 13 | (Seção Ajuste) ganho de capital total relativo ao ajuste |
| FT_ALIQUOTA_MEDIA_AJUSTE | N | 9 | (Seção Ajuste) aliquota média do ajuste |
| VR_IMPOSTO_TOTAL_AJUSTE | N | 13 | (Seção Ajuste) imposto total devido |
| VR_IMPOSTO_PAGO_COMPENSACAO | N | 13 | (Seção Ajuste) imposto pago no exterior passivel de compensação |
| VR_SALDO_IMPOSTO_DEVIDO | N | 13 | (Seção Ajuste) saldo do imposto devido no Brasil |
| VR_IMPOSTO_PARCELA_AJUSTE | N | 13 | (Seção Ajuste) Imposto devido relativo as parcelas |
| VR_SALDO_IMPOSTO_AJUSTE | N | 13 | (Seção Ajuste) saldo do imposto devido na ultima parcela |
| VR_IMPOSTO_PAGO_AJUSTE | N | 13 | (Seção Ajuste) imposto pago brasil realtivo ao ajuste |
| IN_COBRANCA | C | 1 | flag de envio de cobrança ao CCPF |
| VR_TOTAL_RECEBIDO_DOLAR | N | 13 | somatório do valor recebido das parcelas em dolar |
| VR_TOTAL_CUSTO_CORRETAGEM_DOLAR | N | 13 | somatório do custo de corretagem das parcelas em dolar |
| VR_TOTAL_LIQUIDO_RECEBIDO_DOLAR | N | 13 | somatório do valor líquido das parcelas em dolar |
| VR_TOTAL_LIQUIDO_RECEBIDO_REAL | N | 13 | somatório do valor líquido das parcelas em real |
| VR_TOTAL_AQUISICAO_DOLAR | N | 13 | somatório do custo de aquisição das parcelas em dolar |
| VR_TOTAL_AQUISICAO_REAL | N | 13 | somatório do custo de aquisição das parcelas em real |
| VR_TOTAL_AQUISICAO_TORNA_DOLAR | N | 13 | somatório do custo de aquisição torna das parcelas em dolar |
| VR_TOTAL_AQUISICAO_TORNA_REAL | N | 13 | somatório do custo de aquisição torna das parcelas em real |
| VR_TOTAL_RESULTADO1 | N | 13 | somatório do ganho 1 das parcelas |
| VR_TOTAL_REDUCAO | N | 13 | somatório do das reduções das parcelas |
| VR_TOTAL_GCAP_DOLAR | N | 13 | somatório do ganho de capital final das parcelas |
| VR_TOTAL_IR | N | 13 | somatório do imposto devido das parcelas |
| VR_TOTAL_IR_PAGO | N | 13 | somatório do imposto pago das parcelas |
| NM_MENSAGEM | C | 200 | Texto. Em branco quando não existe alteração inicial de cobrança/isenção ou de isenção/cobrança. |
| NM_MOEDA_ESTRANGEIRA | C | 40 | Nome da moeda usada na aquisição do bem |
| CD_MOEDA_ESTRANGEIRA | C | 7 | Identifica a moeda usada na aquisição do bem |
| IN_RESIDENTE_BRASIL_APLICACAO_EXTERIOR | C | 1 | Indica a marcação da pergunta para residentes no Brasil com aplicações no exterior, conforme a Lei 14.754/2023 |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  65

GCAP- ADQUIRENTE

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CPF_BENEFICIARIO | C | 11 | CPF do beneficiário seja titular ou dependente |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração.Originado do REG 60 campo NR_IDENTIFICACAO ( Concatenação de dia/ mês dos campos DT_INICIO + DT_FIM ) |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| IN_TIPO | N | 1 | formato do bem: 1-Imovel; 2-Movel; 3-Participação Societaria |
| NR_CPFCNPJ | C | 14 | CPF / CNPJ do adquirente |
| NR_nome | C | 60 | nome do adquirente |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  66

GCAP - AMPLIAÇÃO

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CPF_BENEFICIARIO | C | 11 | CPF do beneficiário seja titular ou dependente |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração.Originado do 'REG 60' campo 'NR_IDENTIFICACAO' ( Concatenação de dia/ mês dos campos DT_INICIO + DT_FIM ) |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| DT_DATA | N | 8 | Data da ampliação /reforma - DD/MM/AAAA |
| VR_VALOR_REAIS | N | 13 | Valor da parcela reais: Brasil -> valor da parcela; Exterior Moeda Nacional - Valor em reais da parcela; Exterior Ambas as Moedas - Valor em reais de RMN |
| VR_PORCENTAGEM_PARCELA | N | 9 | Custo unitario em comparação com o total % |
| VR_VALOR_REDUCAO | N | 13 | Valor passivel de redução |
| VR_PORCENTAGEM_RED7713 | N | 9 | Valor da porcentagem da redução da lei 7.713 |
| VR_PORCENTAGEM_REDFR1 | N | 9 | Valor da porcentagem da redução FR1 |
| VR_PORCENTAGEM_REDFR2 | N | 9 | Valor da porcentagem da redução FR2 |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  67

GCAP - AMPLIAÇÃO EXTERIOR

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CPF_BENEFICIARIO | C | 11 | CPF do beneficiário seja titular ou dependente |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração.Originado do REG 60 campo NR_IDENTIFICACAO (Concatenação de dia/ mês dos campos DT_INICIO + DT_FIM) |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| DT_DATA | N | 8 | Data da ampliação /reforma - DD/MM/AAAA |
| VR_VALOR_RMN_REAIS | N | 13 | Valor da parcela reais: Moeda Nacional (Valor em reais da parcela).  Ambas as Moedas (Valor em reais de RMN) |
| VR_PORCENTAGEM_PARCELA_RMN | N | 9 | Valor em porcentagem, obtido mediante a comparação entre o 'Custo unitario' e o 'Custo total' |
| VR_COTACAO_AMPLIACAO | N | 13 | Cotação do dolar da parcela de ampliação/reforma: Moeda nacional (valor > 0). Moeda Estrangeira (valor = 0). Ambas as Moedas (valor > 0). |
| VR_VALOR_RMN_DOLAR | N | 13 | Valor da parcela de aquisicao para RMN em Dolar: Moeda Nacional (valor em Dolar da parcela). Moeda Estrangeira (valor = 0). Ambas Moedas (valor em dolar da Parcela RMN) |
| VR_VALOR_RME_DOLAR | N | 13 | Valor da parcela de aquisicao para RME em Dolar: Moeda Nacional (valor = 0). Moeda Estrangeira (valor em Dolar da parcela). Ambas Moedas (valor em Dolar da parcela RME). |
| VR_TOTAL_PARCELA_DOLAR | N | 13 | Valor total da parcela de aquisicao em Dolar: Ambas as Moedas (valor =  VR_VALOR_RMN_DOLAR + VR_VALOR_RME_DOLAR). |
| VR_PORCENTAGEM_PARCELA_RME | N | 9 | Valor em porcentagem, obtido mediante a comparação entre o 'Custo unitario' e o 'Custo total' para RME |
| VR_VALOR_REDUCAO_RMN | N | 13 | Valor passivel de redução RMN |
| VR_VALOR_REDUCAO_RME | N | 13 | Valor passivel de redução RME |
| VR_PORCENTAGEM_RED7713 | N | 9 | Valor da porcentagem da redução da lei 7.713 |
| VR_PORCENTAGEM_REDFR1 | N | 9 | Valor da porcentagem da redução FR1 |
| VR_PORCENTAGEM_REDFR2 | N | 9 | Valor da porcentagem da redução FR2 |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  68

GCAP - APURACAO IMOVEL

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | N | 11 | cpf do contribuinte |
| NR_CPF_BENEFICIARIO | N | 11 | cpf do declarante do gcap |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| NR_TIPO_APURACAO | N | 1 | formato de Apuração |
| VR_VALOR | N | 13 | Valor de alienação |
| VR_CORRETAGEM | N | 13 | custo de corretagem |
| VR_LIQUIDO_APURACAO | N | 13 | valor líquido de alienação em reais |
| VR_LIQUIDO_APURACAO_DOLAR | N | 13 | valor líquido de alienação em dólar |
| VR_CUSTO_APURACAO | N | 13 | custo de aquisição |
| VR_RESULTADO_1_APURACAO | N | 13 | ganho de capital 1 em reais |
| VR_RESULTADO_1_APURACAO_DOLAR | N | 13 | ganho de capital 1 em dólar |
| FT_REDUCAO_LEI7713_APURACAO | N | 9 | percentual redução lei 7713 |
| VR_REDUCAO_LEI7713_APURACAO | N | 13 | valor de redução lei 7713 |
| VR_RESULTADO_2_APURACAO | N | 13 | ganho de capital 2 |
| FT_REDUCAO_LEI11196FR1 | N | 9 | percentual redução fr1 |
| VR_REDUCAO_LEI11196FR1 | N | 13 | valor de redução fr1 |
| VR_RESULTADO_3_APURACAO | N | 13 | ganho de capital 3 |
| FT_REDUCAO_LEI11196FR2 | N | 9 | percentual redução fr2 |
| VR_REDUCAO_LEI11196FR2 | N | 13 | valor de redução fr2 |
| VR_RESULTADO_4_APURACAO | N | 13 | ganho de capital 4 |
| FT_APLICA_OUTRO_APURACAO | N | 9 | percentual redução aplicação ontro imóvel |
| VR_APLICA_OUTRO_APURACAO | N | 13 | valor de redução  aplicação ontro imóvel |
| FT_APLICA_PEQUENO_APURACAO | N | 9 | percentual redução pequeno valor |
| VR_APLICA_PEQUENO_APURACAO | N | 13 | valor de redução pequeno valor |
| FT_APLICA_UNICO_APURACAO | N | 9 | percentual redução único imóvel |
| VR_APLICA_UNICO_APURACAO | N | 13 | valor de redução único imóvel |
| VR_RESULTADO_5_APURACAO | N | 13 | ganho de capital 5 |
| VR_COTACAO_APURACAO | N | 13 | cotação do dolar da operação |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  69

GCAP - APURACAO MOVEL

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | N | 11 | cpf do contribuinte |
| NR_CPF_BENEFICIARIO | N | 11 | cpf do declarante do gcap |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| NR_TIPO_APURACAO | N | 1 | formato de Apuração |
| VR_VALOR | N | 13 | Valor de alienação |
| VR_CORRETAGEM | N | 13 | custo de corretagem |
| VR_LIQUIDO_APURACAO | N | 13 | valor líquido de alienação em reais |
| VR_LIQUIDO_APURACAO_DOLAR | N | 13 | valor líquido de alienação em dólar |
| VR_CUSTO_APURACAO | N | 13 | custo de aquisição |
| VR_RESULTADO_1_APURACAO | N | 13 | ganho de capital 1 em reais |
| VR_RESULTADO_1_APURACAO_DOLAR | N | 13 | ganho de capital 1 em dólar |
| VR_COTACAO_APURACAO | N | 13 | cotação do dolar da operação |
| NR_CONTROLE | N | 10 | Número de Controle |

### Lotes 7X

#### Tipo:  70

GCAP - APURACAO AMBAS

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | N | 11 | cpf do contribuinte |
| NR_CPF_BENEFICIARIO | N | 11 | cpf do declarante do gcap |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| IN_TIPO | N | 1 | Indicação se é movel ou imóvel |
| DT_PARCELA | N | 8 | Data da  parcela |
| VR_VALOR | N | 13 | Valor de alienação em dólar |
| VR_CORRETAGEM | N | 13 | custo de corretagem em dólar |
| VR_LIQUIDO | N | 13 | valor líquido de alienação em dólar |
| VR_APLICA_OUTRO_INFORMADO_PARCELA | N | 13 | (Seção Parcela) Valor reaplicado em outro imóvel em reais |
| VR_GCAP_TOTAL | N | 13 | ganho de capital Total em reais |
| VR_IMPOSTO_DEVIDO_PARCELA | N | 13 | Imposto Devido |
| VR_IMPOSTO_PAGO_COMPENSACAO | N | 13 | Imposto pago no exterior parssivel de compensação |
| VR_IMPOSTO_DEVIDO_BRASIL | N | 13 | Imposto devido no brasil |
| VR_IMPOSTO_PAGO_PARCELA_BRASIL | N | 13 | Imposto pago no Brasil |
| VR_TOTAL_REDUCAO | N | 13 | Total do somatório das reduções |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  71

GCAP - PARCELA IMOVEL

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | N | 11 | cpf do contribuinte |
| NR_CPF_BENEFICIARIO | N | 11 | cpf do declarante do gcap |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| NR_TIPO_PARCELA | N | 1 | formato de parcela |
| IN_ULTIMA_PARCELA | C | 1 | indicador de ultima parcela |
| DT_PARCELA | N | 8 | data de recebimento da ultima parcela |
| VR_LIQUIDO_PARCELA_AMBAS | N | 13 | Valor de líquido da parcela somando MN e ME |
| VR_VALOR | N | 13 | Valor de alienação |
| VR_CORRETAGEM | N | 13 | custo de corretagem |
| VR_LIQUIDO_PARCELA | N | 13 | valor líquido da parcela em reais |
| VR_LIQUIDO_PARCELA_DOLAR | N | 13 | valor líquido da parcela em dólar |
| VR_CUSTO_PARCELA | N | 13 | custo de aquisição |
| VR_RESULTADO_1_PARCELA | N | 13 | ganho de capital 1 em reais |
| VR_RESULTADO_1_PARCELA_DOLAR | N | 13 | ganho de capital 1 em dólar |
| FT_REDUCAO_LEI7713_PARCELA | N | 9 | percentual redução lei 7713 |
| VR_REDUCAO_LEI7713_PARCELA | N | 13 | valor de redução lei 7713 |
| VR_RESULTADO_2_PARCELA | N | 13 | ganho de capital 2 |
| FT_REDUCAO_LEI11196FR1 | N | 9 | percentual redução fr1 |
| VR_REDUCAO_LEI11196FR1 | N | 13 | valor de redução fr1 |
| VR_RESULTADO_3_PARCELA | N | 13 | ganho de capital 3 |
| FT_REDUCAO_LEI11196FR2 | N | 9 | percentual redução fr2 |
| VR_REDUCAO_LEI11196FR2 | N | 13 | valor de redução fr2 |
| VR_RESULTADO_4_PARCELA | N | 13 | ganho de capital 4 |
| VR_APLICA_OUTRO_INFORMADO_PARCELA | N | 13 | valor informado de redução aplicação ontro imóvel |
| FT_APLICA_OUTRO_PARCELA | N | 9 | percentual redução aplicação ontro imóvel |
| VR_APLICA_OUTRO_PARCELA | N | 13 | valor de redução  aplicação ontro imóvel |
| FT_APLICA_PEQUENO_PARCELA | N | 9 | percentual redução pequeno valor |
| VR_APLICA_PEQUENO_PARCELA | N | 13 | valor de redução pequeno valor |
| FT_APLICA_UNICO_PARCELA | N | 9 | percentual redução único imóvel |
| VR_APLICA_UNICO_PARCELA | N | 13 | valor de redução único imóvel |
| VR_RESULTADO_5_PARCELA | N | 13 | ganho de capital 5 |
| VR_TOTAL_REDUCAO | N | 13 | somatório das reduções da parcela |
| VR_ALIQUOTA_MEDIA_PARCELA | N | 9 | aliquota de imposto |
| VR_IMPOSTO_DEVIDO_PARCELA | N | 13 | imposto devido total |
| VR_IMPOSTO_PAGO_COMPENSACAO | N | 13 | imposto pago no exterior |
| VR_IMPOSTO_DEVIDO_BRASIL | N | 13 | imposto devido brasil |
| VR_IMPOSTO_PAGO_PARCELA_BRASIL | N | 13 | imposto pago brasil |
| VR_COTACAO_PARCELA | N | 13 | cotação do dolar da operação |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  72

GCAP - PARCELA MOVEL

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | N | 11 | cpf do contribuinte |
| NR_CPF_BENEFICIARIO | N | 11 | cpf do declarante do gcap |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| IN_TIPO | N | 1 | se é móvel ou participação societaria |
| NR_TIPO_PARCELA | N | 1 | formato de parcela |
| IN_ULTIMA_PARCELA | C | 1 | indicador de ultima parcela |
| DT_PARCELA | N | 8 | data de recebimento da ultima parcela |
| VR_LIQUIDO_PARCELA_AMBAS | N | 13 | Valor de líquido da parcela somando MN e ME |
| VR_VALOR | N | 13 | Valor de alienação |
| VR_CORRETAGEM | N | 13 | custo de corretagem |
| VR_LIQUIDO_PARCELA | N | 13 | valor líquido da parcela em reais |
| VR_LIQUIDO_PARCELA_DOLAR | N | 13 | valor líquido da parcela em dólar |
| VR_CUSTO_PARCELA | N | 13 | custo de aquisição |
| VR_RESULTADO_1_PARCELA | N | 13 | ganho de capital 1 em reais |
| VR_RESULTADO_1_PARCELA_DOLAR | N | 13 | ganho de capital 1 em dólar |
| VR_ALIQUOTA_MEDIA_PARCELA | N | 9 | aliquota de imposto |
| VR_IMPOSTO_DEVIDO_PARCELA | N | 13 | imposto devido total |
| VR_IMPOSTO_PAGO_COMPENSACAO | N | 13 | imposto pago no exterior |
| VR_IMPOSTO_DEVIDO_BRASIL | N | 13 | imposto devido brasil |
| VR_IMPOSTO_PAGO_PARCELA_BRASIL | N | 13 | imposto pago brasil |
| VR_COTACAO_PARCELA | N | 13 | cotação do dolar da operação |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  73

GCAP - CUSTO APURACAO ACAO

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CPF_BENEFICIARIO | C | 11 | CPF do beneficiário seja titular ou dependente |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração.Originado do REG 60 campo NR_IDENTIFICACAO ( Concatenação de dia/ mês dos campos DT_INICIO + DT_FIM ) |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| NR_ITEM | C | 4 | Chave de Identificação da operação da ficha apuração do custo |
| IN_ESPECIE | N | 1 | formato da Especie de participação: 1.Ação preferencial nominativa; 2.Ação ordinária nominativa; 3.Quotas; 4.Outras; |
| NM_DESCRICAO_ESPECIE | C | 60 | Descrição da espécie de participação |
| VR_QUANTIDADE_ALIENADA | N | 11 | (Sessão apuração do custo de aquisição) quantidade de itens alienados |
| VR_CUSTO_MEDIO | N | 17 | (Sessão apuração do custo de aquisição) Valor do custo medio ponderado |
| VR_CUSTO_TOTAL | N | 13 | (Sessão apuração do custo de aquisição) Custo Total |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  74

GCAP- ESPECIE

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CPF_BENEFICIARIO | C | 11 | CPF do beneficiário seja titular ou dependente |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração.Originado do REG 60 campo NR_IDENTIFICACAO ( Concatenação de dia/ mês dos campos DT_INICIO + DT_FIM ) |
| NR_ITEM | C | 4 | Chave de Identificação da operação das vendas de moeda |
| CD_MOEDA | C | 7 | Identifica a moeda  |
| NM_MOEDA | C | 40 | nome da moeda alienada |
| TIPO_OPERACAO | C | 1 | Código do tipo de operação. 1- Saldo inicial; 2 - Compra; 3 - Venda |
| NM_OPERACAO | C | 15 | nome do tipo de operação. Saldo inicial; Compra; Venda |
| NM_ADQUIR | C | 60 | nome do adquirente |
| NR_ADQUIR | C | 14 | CNPJ-CPF do adquirente |
| DT_OPERACAO | N | 8 | Data da aquisicao/alienação |
| VR_OPERACAO | N | 13 | Valor da aquisicao/alienação |
| NR_QUANTIDADE | N | 13 | Quantidade de moeda adquirida/alienada |
| VR_CUSTO | N | 17 | Custo médio / cotação média |
| VR_CUSTOTOTAQUIS | N | 13 | Custo total |
| VR_GANHOCAPITAL | N | 13 | Valor do Ganho de Capital |
| VR_SALDO_REAIS | N | 13 | Saldo em  reais |
| VR_SALDO_ME | N | 13 | Saldo em moeda estrangeira |
| VR_COTACAO_MOEDA_ESTRANGEIRA_DOLAR | N | 13 | Cotação da moeda estrangeira em relação ao dólar para definir isenção 5k USD |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  75

GCAP - FAIXA DE GANHO

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | Tipo do registro |
| NR_CPF | N | 11 | cpf do contribuinte |
| NR_CPF_BENEFICIARIO | N | 11 | cpf do declarante do gcap |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração |
| NR_OPERACAO | N | 4 | Chave de Identificação da operação |
| IN_TIPO | N | 1 | se é imóvel, móvel ou participação societaria |
| IN_APURACAO | N | 1 | se é baseado na apuração ou na apuração final |
| VR_FAIXA1_TOTAL | N | 13 | Ganho total tributável da primeira faixa de imposto |
| VR_FAIXA1_ANTERIOR | N | 13 | Ganho anterior tributável da primeira faixa de imposto |
| VR_FAIXA1_ATUAL | N | 13 | Ganho atual tributável da primeira faixa de imposto |
| VR_FAIXA2_TOTAL | N | 13 | Ganho total tributável da segunda faixa de imposto |
| VR_FAIXA2_ANTERIOR | N | 13 | Ganho anterior tributável da segunda faixa de imposto |
| VR_FAIXA2_ATUAL | N | 13 | Ganho atual tributável da segunda faixa de imposto |
| VR_FAIXA3_TOTAL | N | 13 | Ganho total tributável da terceira faixa de imposto |
| VR_FAIXA3_ANTERIOR | N | 13 | Ganho anterior tributável da terceira faixa de imposto |
| VR_FAIXA3_ATUAL | N | 13 | Ganho atual tributável da terceira faixa de imposto |
| VR_FAIXA4_TOTAL | N | 13 | Ganho total tributável da quarta faixa de imposto |
| VR_FAIXA4_ANTERIOR | N | 13 | Ganho anterior tributável da quarta faixa de imposto |
| VR_FAIXA4_ATUAL | N | 13 | Ganho atual tributável da quarta faixa de imposto |
| VR_FAIXAT_TOTAL | N | 13 | Ganho total tributável do quadro de fatiamento de faixas de imposto |
| VR_FAIXAT_ANTERIOR | N | 13 | Ganho anterior tributável do quadro de fatiamento de faixas de imposto |
| VR_FAIXAT_ATUAL | N | 13 | Ganho atual tributável do quadro de fatiamento de faixas de imposto |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  76

Registro 76 não Presente na documentação

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | Tipo do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CPF_BENEFICIARIO | C | 11 | CPF do beneficiário seja titular ou dependente |
| NR_IDENTIFICACAO | N | 8 | Identificação da declaração.Originado do REG 60 campo NR_IDENTIFICACAO( Concatenação de dia/ mês dos campos DT_INICIO + DT_FIM ) |
| NR_MES | N | 2 | Mês de ocorrência |
| VR_ALIENACAO_DOLAR | N | 13 | Total de alienação em dólar por mês |
| VR_ALIENACAO_CONSOLIDADA_DOLAR | N | 13 | Total de alienações em dólar consolidado |
| VR_GANHO_CAPITAL | N | 13 | Total de ganhos de capital no mês (somar apenas valores maiores que zero, pois não compensa prejuízo). |
| VR_GANHO_CAPITAL_TRIBUTAVEL | N | 13 | Ganho de capital tributável. Essa coluna será zero até que o a coluna B seja maior que US$ 5.000,00. No primeiro mês que o valor de B passar de 5.000,00 essa coluna deve somar todos o ganho de capital de todos os meses anteriores. Nos meses subsequentes será o valor do Ganho de Capital do mês. |
| VR_ALIQUOTA_MEDIA | N | 13 | Alíquota de acordo com a tabela progressiva |
| VR_IMPOSTO_DEVIDO | N | 13 | Imposto devido no mês |
| VR_IMPOSTO_PAGO | N | 13 | Imposto pago. Informado pelo contribuinte na tela |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  77

Registro 77 não Presente na documentação

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| FILLER | C | 2 | Filler |
| PAIS_MOEDA | N | 7 | Pais origem da moeda |
| NM_MOEDA | C | 40 | nome da moeda alienada |
| VR_GANHOCAPITAL | N | 13 | Vlr G Capital consolidado das alien. da moeda |
| VR_IMPOSTO | N | 13 | Vlr imposto devido das alien. da moeda |
| NR_ITEM | N | 4 | Numero do item |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  78

Registro 78 não Presente na documentação

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| VR_BENSISENTO | N | 13 | Vlr isentos e não-tributáveis, de bens ou direitos |
| VR_BENSIMPOSTO | N | 13 | Vlr imposto pago, de bens ou direitos |
| VR_BENSEXCLUSIVO | N | 13 | Vlr rend. tributação exclusiva, de bens ou direitos |
| VR_ESPIMPOSTO | N | 13 | Vr imposto devido, de espécie |
| VR_ESPEXCLUSIVO | N | 13 | Vr rend. tributação exclusiva, de espécie |
| TRANSPORTEVC_VR_IMPOSTODEVIDO | N | 13 | Valor do imposto devido |
| NR_CONTROLE | N | 10 | Número de Controle |

### Lotes 8X

#### Tipo:  80

REND TRIBUT RECEBIDOS DE PJ EXIGIBILIDADE SUSPENSA TITULAR

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_PAGADOR | C | 14 | CNPJ fonte pagadora |
| NM_PAGADOR | C | 60 | nome fonte pagadora |
| VR_RENDTO | N | 13 | Valor rendimento recebido |
| VR_DEP_JUDICIAL | N | 13 | Valor depósito judicial |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  81

REND. TRIB. RECEBIDOS DE PJ EXIGIBILIDADE SUSPENSA DEPENDENTES

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CPF_BENEF | C | 11 | CPF do Dependente |
| NR_PAGADOR | C | 14 | CNPJ fonte pagadora |
| NM_PAGADOR | C | 60 | nome fonte pagadora |
| VR_RENDTO | N | 13 | Valor rendimento recebido |
| VR_DEP_JUDICIAL | N | 13 | Valor depósito judicial |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  82

RENDIMENTO ISENTO TIPO DE INFORMAÇÃO 2

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Chave de identificação da transferência patrimonial |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_PAGADORA | C | 14 | CPF/CNPJ do doador/espólio |
| NM_NOME | C | 60 | nome do doador/espólio |
| VR_RECEB | N | 13 | Valor do recebimento |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  83

Detalhes dos Médicos Residentes da ficha Rendimentos Isentos

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_COD | N | 4 |  |
| VR_VALOR | N | 13 | Valor do recebimento |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  84

Detalhes dos Voluntários da Copa da ficha Rendimentos Isentos

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_CPF_BENEFIC | C | 11 | CPF contribuinte |
| NR_COD | N | 4 |  |
| NR_PAGADORA | C | 14 | CPF/CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_VALOR | N | 13 | Valor do recebimento |
| VR_VALOR_13 | N | 13 | Valor recebido de décimo terceiro |
| NR_CHAVE_BEM | N | 5 | chave do bem associado |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  85

Detalhes da Meação e Dissolução da ficha Rendimentos Isentos

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_COD | N | 4 |  |
| NR_PAGADORA | C | 14 | CPF/CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_RECEB | N | 13 | Valor do recebimento |
| VR_13SALARIO | N | 13 | Valor do 13 Salario |
| VR_IRRF | N | 13 | Valor do IRRF |
| VR_IRRF13SALARIO | N | 13 | Valor do IRRF sobre 13 Salario |
| VR_PREVIDENCIA | N | 13 | Contribuição previdenciária oficial |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  86

Detalhes do Ganho com Ações da ficha Rendimentos Isentos

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_COD | N | 4 |  |
| NR_PAGADORA | C | 14 | CPF/CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_VALOR | N | 13 | Valor do recebimento |
| NM_DESCRICAO | C | 60 | Descrição |
| NR_CHAVE_BEM | N | 5 | chave do bem associado |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  87

Detalhes do Ganho com Ouro da ficha Rendimentos Isentos

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_COD | N | 4 |  |
| VR_VALOR | N | 13 | Valor do recebimento |
| VR_VALORGCAP | N | 13 | Valor do recebimento |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  88

Detalhes da Parcela Isenta da Aposentadoria da ficha Rendimentos Isentos

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_COD | N | 4 |  |
| NR_PAGADORA | C | 14 | CPF/CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_VALOR | N | 13 | Valor do recebimento |
| NR_CHAVE_BEM | N | 5 | chave do bem associado |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  89

Detalhes do Rendimento de Sócio ou Titular de Microempresa da ficha Rendimentos Isentos

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_COD | N | 4 |  |
| NR_PAGADORA | C | 14 | CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_VALOR | N | 13 | Valor do recebimento |
| NM_DESCRICAO | C | 60 | nome da fonte pagadora |
| NR_CONTROLE | N | 10 | Número de Controle |

### Lotes 9X

#### Tipo:  90

Relacao de doações efetuadas

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| CD_DOACAO | N | 2 | Codigo de doação |
| NR_BENEF | C | 14 | CNPJ/CPF do beneficiário |
| NM_BENEF | A | 60 | nome do beneficiario |
| VR_DOACAO | N | 13 | Valor da doação |
| VR_PARC_NAO_DEDUT | N | 13 | Valor da parcela não dedutível ou reembolsada |
| IN_TIPO_CPF_CNPJ | N | 1 | Indicador se CPF ou CNPJ |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  91

Relacao de doações na declaração - Estatuto da Criança e do Adolescente

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_TIPO_FUNDO | C | 1 | formato do fundo: (N)acional, (E)stadual ou (M)unicipal |
| SG_UF | C | 2 | Sigla da UF |
| NOME_UF | C | 30 | NOME da UF |
| NOME_MUNICIPIO | A | 40 | nome do município |
| VR_DOACAO | N | 13 | Valor da doação |
| NR_CNPJ_FUNDO | C | 14 | CNPJ do fundo |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  92

Relacao de doações na declaração - Estatuto do Idoso

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| IN_TIPO_FUNDO | C | 1 | formato do fundo: (N)acional, (E)stadual ou (M)unicipal |
| SG_UF | C | 2 | Sigla da UF |
| NOME_UF | C | 30 | NOME da UF |
| NOME_MUNICIPIO | A | 40 | nome do município |
| VR_DOACAO | N | 13 | Valor da doação |
| NR_CNPJ_FUNDO | C | 14 | CNPJ do fundo |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  93

Detalhes de indenizações da ficha Rendimentos Isentos

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Chave de identificação da indenização |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_PAGADORA | C | 14 | CPF/CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_RECEB | N | 13 | Valor do recebimento |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  94

Detalhes de IRRF anos anteriores da ficha Rendimentos Isentos

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Chave de identificação do IRRF ano anterior |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_PAGADORA | C | 14 | CPF/CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_RECEB | N | 13 | Valor do recebimento |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  95

Detalhes de juros sobre capital próprio da ficha Rendimentos com tributação exclusiva

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Chave de identificação do IRRF ano anterior |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_PAGADORA | C | 14 | CPF/CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_RECEB | N | 13 | Valor do recebimento |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  96

Detalhes de participação em lucros e resultados da ficha Rendimentos com tributação exclusiva

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Chave de identificação do IRRF ano anterior |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_PAGADORA | C | 14 | CPF/CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_RECEB | N | 13 | Valor do recebimento |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  97

Detalhes de outros rendimentos das fichas Rendimentos isentos e Rendimentos com tributação exclusiva

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Chave de identificação do rendimento |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_PAGADORA | C | 14 | CPF/CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_RECEB | N | 13 | Valor do recebimento |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| IN_FICHA | C | 1 | Indicador se o registro é da ficha Rend. Isentos (1) ou Rend. Tributação Exclusiva (2) |
| NM_RENDIMENTO | C | 60 | Descrição do rendimento |
| NR_CONTROLE | N | 10 | Número de Controle |

#### Tipo:  98

Detalhes do Rendimento de Caderneta de Poupança e Letras Hipotecárias da ficha Rendimentos Isentos

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Chave de identificação do rendimento de caderneta de poupança e letras hipotecárias |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_PAGADORA | C | 14 | CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_RECEB | N | 13 | Valor do recebimento |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_CONTROLE | N | 10 | Numero de Controle |

#### Tipo:  99

Detalhes dos Rendimentos de Aplicações Financeiras da ficha Rendimentos Suj. Tributação Exclusiva

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| NR_CHAVE | N | 5 | Chave de identificação do rendimento de aplicações financeiras |
| IN_TIPO | C | 1 | Indicador se o registro é do titular ou do dependente |
| NR_PAGADORA | C | 14 | CNPJ da fonte pagadora |
| NM_NOME | C | 60 | nome da fonte pagadora |
| VR_RECEB | N | 13 | Valor do recebimento |
| NR_CPF_BENEFIC | C | 11 | CPF do beneficiário |
| NR_CONTROLE | N | 10 | Numero de Controle |

### Lote Trailer

#### Tipo:  FR

Registro FR não Presente na documentação

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | N | 2 | formato do registro |
| NOME_DEC | C | 5 | nome da declaracao |
| NR_CPF | C | 11 | CPF contribuinte |
| ND_DEC | C | 10 | ND da declaracao |
| DT_ENTREGA | C | 10 | Data da entrega |
| HR_ENTREGA | C | 8 | Hora da entrega |
| MEIO_ENTREGA | C | 10 | Meio de Entrega |
| TIPO_DEC | C | 12 | formato Completa ou Simplificada |
| SIT_DEC | C | 63 | Situacao da declaracao |
| IN_CERT | C | 3 | Indicador Certificado |
| CERT_DEC | C | 14 | Certificado da declaracao |
| OBSERVACAO | C | 86 | Observação |
| TIPO | C | 12 | Original ou Retificadora |
| ND_FAR | C | 10 | ND do FAR |



#### Tipo:  T9

TRAILLER - TOTAIS DE REGISTROS (Atualizado)

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | C | 2 | formato do registro |
| NR_CPF | N | 11 | CPF contribuinte |
| QT_TOTAL | N | 6 | Total de registros |
| QT_R16 | N | 5 | Total de registros tipo 16 |
| QT_R17 | N | 5 | Total de registros tipo 17 |
| QT_R18 | N | 5 | Total de registros tipo 18 |
| QT_R19 | N | 5 | Total de registros tipo 19 |
| QT_R20 | N | 5 | Total de registros tipo 20 |
| QT_R21 | N | 5 | Total de registros tipo 21 |
| QT_R22 | N | 5 | Total de registros tipo 22 |
| QT_R23 | N | 5 | Total de registros tipo 23 |
| QT_R24 | N | 5 | Total de registros tipo 24 |
| QT_R25 | N | 5 | Total de registros tipo 25 |
| QT_R26 | N | 5 | Total de registros tipo 26 |
| QT_R27 | N | 5 | Total de registros tipo 27 |
| QT_R28 | N | 5 | Total de registros tipo 28 |
| Filler | N | 5 | Filler |
| QT_R30 | N | 5 | Total de registros tipo 30 |
| Filler | N | 5 | Filler |
| QT_R32 | N | 5 | Total de registros tipo 32 |
| Filler | C | 5 | Filler |
| QT_R34 | N | 5 | Total de registros tipo 34 |
| QT_R35 | N | 5 | Total de registros tipo 35 |
| Filler | C | 5 | Filler |
| Filler | C | 5 | Filler |
| QT_R38 | N | 5 | Total de registros tipo 38 |
| QT_R39 | N | 5 | Total de registros tipo 39 |
| QT_R40 | N | 5 | Total de registros tipo 40 |
| QT_R41 | N | 5 | Total de registros tipo 41 |
| QT_R42 | N | 5 | Total de registros tipo 42 |
| QT_R43 | N | 5 | Total de registros tipo 43 |
| Filler | C | 5 | Filler |
| QT_R45 | N | 5 | Total de registros tipo 45 |
| QT_R46 | N | 5 | Total de registros tipo 46 |
| QT_R47 | N | 5 | Total de registros tipo 47 |
| QT_R48 | N | 5 | Total de registros tipo 48 |
| QT_R49 | N | 5 | Total de registros tipo 49 |
| QT_R50 | N | 5 | Total de registros tipo 50 |
| QT_R51 | N | 5 | Total de registros tipo 51 |
| QT_R52 | N | 5 | Total de registros tipo 52 |
| QT_R53 | N | 5 | Total de registros tipo 53 |
| QT_R54 | N | 5 | Total de registros tipo 54 |
| QT_R55 | N | 5 | Total de registros tipo 55 |
| QT_R56 | N | 5 | Total de registros tipo 56 |
| QT_R57 | N | 5 | Total de registros tipo 57 |
| QT_R58 | N | 5 | Total de registros tipo 58 |
| QT_R59 | N | 5 | Total de registros tipo 59 |
| QT_R60 | N | 5 | Total de registros tipo 60 |
| QT_R61 | N | 5 | Total de registros tipo 61 |
| QT_R62 | N | 5 | Total de registros tipo 62 |
| QT_R63 | N | 5 | Total de registros tipo 63 |
| QT_R65 | N | 5 | Total de registros tipo 65 |
| QT_R66 | N | 5 | Total de registros tipo 66 |
| QT_R67 | N | 5 | Total de registros tipo 67 |
| QT_R68 | N | 5 | Total de registros tipo 68 |
| QT_R69 | N | 5 | Total de registros tipo 69 |
| QT_R70 | N | 5 | Total de registros tipo 70 |
| QT_R71 | N | 5 | Total de registros tipo 71 |
| QT_R72 | N | 5 | Total de registros tipo 72 |
| QT_R73 | N | 5 | Total de registros tipo 73 |
| QT_R74 | N | 5 | Total de registros tipo 74 |
| QT_R75 | N | 5 | Total de registros tipo 75 |
| QT_R76 | N | 5 | Total de registros tipo 76 |
| Filler | C | 15 | Filler |
| QT_R80 | N | 5 | Total de registros tipo 80 |
| QT_R81 | N | 5 | Total de registros tipo 81 |
| Filler | C | 5 | Filler |
| QT_R83 | N | 5 | Total de registros tipo 83 |
| QT_R84 | N | 5 | Total de registros tipo 84 |
| QT_R85 | N | 5 | Total de registros tipo 85 |
| QT_R86 | N | 5 | Total de registros tipo 86 |
| QT_R87 | N | 5 | Total de registros tipo 87 |
| QT_R88 | N | 5 | Total de registros tipo 88 |
| QT_R89 | N | 5 | Total de registros tipo 89 |
| QT_R90 | N | 5 | Total de registros tipo 90 |
| QT_R91 | N | 5 | Total de registros tipo 91 |
| QT_R92 | N | 5 | Total de registros tipo 92 |
| Filler | C | 5 | Filler |
| Filler | C | 5 | Filler |
| Filler | C | 5 | Filler |
| Filler | C | 5 | Filler |
| Filler | C | 5 | Filler |
| Filler | C | 5 | Filler |
| Filler | C | 5 | Filler |
| NR_CONTROLE | N | 10 | Numero de Controle |

## Registros do Recibo

#### Tipo:  HR

Header do Recibo

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | C | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| FILLER | C | 3 | Espaco reservado |
| NR_CONTROLE | N | 10 | Numero de Controle |

#### Tipo:  DR

Recibo de entrega da declaracao

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | C | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| FILLER | C | 3 | Espaco em branco |
| IN_COMPLETA | C | 1 | Indicativo dec. Completa(S)/simplificada(N) |
| NM_NOME | A | 60 | nome do contribuinte |
| TIP_LOGRA | A | 15 | formato do Logradouro |
| NM_LOGRA | C | 40 | Endereco contribuinte: logradouro |
| NR_NUMERO | C | 6 | Endereco contribuinte: numero |
| NM_COMPLEM | C | 21 | Endereco contribuinte: complemento |
| NM_BAIRRO | C | 19 | Endereco contribuinte: bairro |
| NR_CEP | C | 9 | Endereco contribuinte: CEP/ZIP |
| CD_MUNICIP | N | 4 | Codigo municipio |
| NM_MUNICIP | C | 40 | Endereco contribuinte: municipio |
| SG_UF | A | 2 | Endereco contribuinte: UF |
| FILLER1 | C | 100 | Espaços em branco (Endereço contribuinte: Email - Correio Eletrônico) |
| FILLER2 | C | 4 | Endereco contribuinte: DDD do FAX |
| FILLER3 | C | 8 | Endereco contribuinte: FAX |
| NR_DDD_TELEFONE | C | 4 | Endereco contribuinte: DDD do telefone |
| FILLER4 | C | 9 | FILLER |
| IN_RETIFICADORA | C | 1 | Indicativo se declaracao retificadora |
| VR_TOTTRIB | N | 13 | Valor dos rendimentos tributaveis |
| VR_IMPDEV | N | 13 | Valor do imposto devido |
| VR_IMPREST | N | 13 | Valor do imposto a restituir |
| VR_IMPPAGAR | N | 13 | Valor do imposto a pagar |
| NR_QUOTAS | N | 1 | Quantidades de quotas |
| VR_QUOTA | N | 13 | Valor da quota |
| NR_BANCO | N | 3 | Codigo do Banco |
| NR_AGENCIA | N | 4 | Numero da Agencia Bancaria |
| FILLER | C | 1 | Filler |
| IN_DEBITO_PRIMEIRA_QUOTA | N | 1 | Indicador de Débito Automático da 1ª quota |
| VR_GCIMPOSTOPAGO | N | 13 | Valor do Imposto pago do Ganho de Capital |
| NR_CONTA | C | 13 | Numero da conta corrente para deposito de IAR |
| NR_DV_CONTA | C | 2 | Numero do Digito Verificador da Conta Corrente |
| VR_VCMOEDAEST | N | 13 | Imposto sobre alienacao de ME em especie |
| NR_TELEFONE | C | 11 | Endereco contribuinte: telefone |
| NR_CONTROLE | N | 10 | Numero de Controle |

#### Tipo:  R9

Trailler do Recibo

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | C | 2 | formato do registro |
| NR_CPF | C | 11 | CPF contribuinte |
| FILLER | C | 3 | Espaco reservado |
| NR_HASH | N | 10 | Hash calculado sobre todos os registros da dec.,exceto o Header e o Trailler do recibo |
| NR_CONTROLE | N | 10 | Numero de Controle |

## Registros de Complemento de Recibo

#### Tipo:  HC

Header do complemento do recibo

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | A | 2 | formato de registro |
| NR_CPFCNPJ | C | 11 | CPF/CNPJ do Contribuinte |
| FILLER | C | 3 | Espaco reservado |
| NR_CONTROLE | N | 10 | Numero de Controle |

#### Tipo:  RC

Detalhes do complemento do recibo

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | A | 2 | formato de registro |
| NR_CPFCNPJ | C | 11 | CPF/CNPJ do Contribuinte |
| FILLER1 | C | 3 | Espaço em branco |
| DIAREC | N | 2 | Data de recepcao: dia |
| MESREC | N | 2 | Data de recepcao: mes |
| ANOREC | N | 4 | Data de recepcao: ano |
| HORAREC | N | 2 | Horario : hora |
| MINREC | N | 2 | Horario : minutos |
| SEGREC | N | 2 | Horario : segundos |
| LOCALREC | C | 25 | Local de recepcao |
| NR_REMESSA | C | 4 | N. da remessa |
| ASSINATURA | C | 10 | Assinatura |
| IN_GATEWAY | N | 1 | Indicador gateway |
| FILLER2 | C | 1 | campo reservado |
| IN_APLIC_TRANSMISSAO | N | 1 | Indica o aplicativo de transmissão: 1- Receitanet; 2-ReceitanetWEB |
| APLIC_TRANSMISSAO | C | 2 | Indica a expressão associada ao aplicativo de transmissão :RW - se ReceitanetWEB; RN - se Receitanet |
| COD_AG_TRANSMISSOR | C | 3 | Agente transmissor |
| NI_ASSINATURA_DECL | C | 14 | NI assinante |
| CONTROLE_SRF | C | 10 | Número do controle SRF da declaração criptografado. OBS: Essa informação somente deve ser utilizada para a validação do recibo para os PGD versão Java. |
| FILLER3 | C | 20 | Espaco reservado |
| NR_CONTROLE | N | 10 | Numero de Controle |

#### Tipo:  NC

NOTIFICACAO DE MULTA

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | A | 2 | formato de registro |
| IN_ACAO_FISCAL | N | 1 | formato de registro |
| NM_DELEGADO | C | 60 | nome do Delegado da SRF |
| NR_MATRIC_DELEGADO | C | 8 | Numero da Matricula do Delegado |
| NR_CARGO | N | 1 | Cargo do Delegado( 1 - AFRF 2 - TRF) |
| NR_UA | C | 7 | Código da Unidade de Atendimento |
| NM_UA | C | 50 | nome da Unidade de Atendimento |
| DT_VENCIMENTO | N | 8 | Data de Vencimento da Multa(Formato AAAAMMDD) |
| QT_MESES | N | 2 | Qtd. Meses de atraso |
| VR_MULTA | N | 13 | Valor da Multa |
| NR_DISTRIBUICAO | C | 14 | Código da Notificação - XHHHHHHHHHHY - DD onde: X - identificador do sistema que está cobrando a multa. Para o IRPF, X = 5 HHHHHHHHHH - é o hashcode da declaração Y - é a primeira posição do dígito verificador do CPF DD - é o DV módulo 11 com 2 posições de DV |
| IN_OBRIGATORIEDADE | C | 1 | Indicador de obrigatoriedade de entrega atualizado |
| TP_DELEGACIA | C | 57 | formato da Delegacia |
| IN_CRIT_OBRIG | N | 3 | Criterio de obrigatoriedade verificado pelo validador |
| FILLER | C | 25 | Espaco em branco |
| NR_CONTROLE | N | 10 | Numero de Controle |

#### Tipo:  VC

DADOS DO VALIDADOR

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| TP_REG | A | 2 | formato do tipo |
| IN_PENDENCIA | N | 5 | Indicador de pendência dos anos anteriores. |
| QTD_RETIFICADORAS | N | 3 | Quantidade de Retificadoras (já entregues anteriormente) |
| IN_DEBITO | A | 1 | Indicador de débito com a RFB |
| DATA_MENSAGEM | N | 8 | Data de geração da mensagem |
| IN_SALDO_RESTITUICAO | A | 1 | Indicador de existência de saldo de restituição de IRPF não resgatado |
| DATA_SALDO_RESTITUICAO | N | 8 | Data (formato AAAAMMDD) da apuração da existência de saldo de restituição de IRPF não resgatado |
| NR_CPF_DARF1 | C | 11 | CPF do contribuinte para emissão do DARF de auxilio emergencial. |
| VL_DARF1 | N | 13 | Valor do DARF. |
| NR_CPF_DARF2 | C | 11 | CPF do contribuinte para emissão do DARF de auxilio emergencial. |
| VL_DARF2 | N | 13 | Valor do DARF. |
| NR_CPF_DARF3 | C | 11 | CPF do contribuinte para emissão do DARF de auxilio emergencial. |
| VL_DARF3 | N | 13 | Valor do DARF. |
| NR_CPF_DARF4 | C | 11 | CPF do contribuinte para emissão do DARF de auxilio emergencial. |
| VL_DARF4 | N | 13 | Valor do DARF. |
| NR_CPF_DARF5 | C | 11 | CPF do contribuinte para emissão do DARF de auxilio emergencial. |
| VL_DARF5 | N | 13 | Valor do DARF. |
| NR_CPF_DARF6 | C | 11 | CPF do contribuinte para emissão do DARF de auxilio emergencial. |
| VL_DARF6 | N | 13 | Valor do DARF. |
| NR_CPF_DARF7 | C | 11 | CPF do contribuinte para emissão do DARF de auxilio emergencial. |
| VL_DARF7 | N | 13 | Valor do DARF. |
| NR_CONTROLE | N | 10 | Numero de Controle |

#### Tipo:  MC

MENSAGEM

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| TP_REG | A | 2 | formato do tipo |
| DES_MENSAGEM | A | 240 | Descrição da mensagem enviada pelo Validador para o PGD |
| NR_CONTROLE | N | 10 | Numero de Controle |

#### Tipo:  TC

Trailler do complemento do recibo

| Nome | Formato | Tamanho | Observação |
|------|---------|---------|------------|
| NR_REG | A | 2 | formato de registro |
| NR_CPFCNPJ | C | 11 | CPF/CNPJ do Contribuinte |
| FILLER | C | 3 | Espaco reservado |
| SIGNET | C | 32 | Assinatura MD5 |
| NR_CONTROLE | N | 10 | Numero de Controle |

