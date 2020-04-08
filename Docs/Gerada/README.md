# Documentação Gerada

## Links e Sites:

### Site para gerar CPFs e CNPJs com dígitos válidos

Site que gera CPFs e outros números respeitando as regras de cálculo [4devs](https://www.4devs.com.br/gerador_de_cpf)

Site que calcula o dígito para o CPF ou CNPJ fornecido, utilizei para gerar os números sequenciais como 111.111.110-30 [informatiqueiro](https://www.informatiqueiro.com.br/calcular-digito-verificador-para-cpf-e-cnpj/)


## Arquivos do repositório:


------

Dados randômicos para usar em testes:

AVISO (DISCLAIMER): Todos os dados devem ter fonte de aleatoriedade ou explciação de escolha para garantir que não serão usados dados de uma pessoa real

## Documentos

### CPFs

Gerados com números repetidos, quando o DV também é repetição, foi alterado o último dígito para o próximo para trocar o DV

* 111.111.110-30
* 222.222.223-03
* 333.333.334-14
* 444.444.445-25 
* 555.555.556-36 
  
### CNPJs

Gerados com números repetidos, quando o DV também é repetição, foi alterado o último dígito para o próximo para trocar o DV

Pela natureza quase sequencial do CNPJ é plausível que algumas repetições acabem tendo colisão com números reais, logo irei gerar, ou começando com '99', ou tendo o final como sendo `/9999-DV`

Começam com '99'
* 99.111.111/0001-32
* 99.222.222/0001-16
* 99.333.333/0001-18
* 99.444.444/0001-83
* 99.555.555/0001-67

Em 2020, nenhum dos 5 CNPJs acima existia de acordo com a [consulta nacional de CNPJ](http://servicos.receita.fazenda.gov.br/Servicos/cnpjreva/Cnpjreva_Solicitacao.asp?cnpj=)

## Nomes de Pessoas

Devido à problemática de gerar nomes e acontecerem colisões ou estereótipos

#### Completamente aleatórios

1. Utilizarei um gerador de Nomes de Fantasia do [4devs](4devs.com.br) já linkado acima

* Adanfiwe Baylyath Nurod Heastai
* Aegur Xoeze Raikseo Belegvoion
* Clarond Arpurim Pivilli Kaciamph
* Dayziucai Wyavuarandir Zuyndîr Koinael
* Feloarhad Noyke Wuada Thuringa
* Galdyo Coehu Sewol Marid
* Jarflefi Vyuadan Soitueurt Foupidor
* Keupior Oles Barabirion Furirezu
* Krinhahe Zuamolri Dumbku Geomba
* Ogruon Caok Naor Daxuaog
* Olzefu Byaisno Asrim Lahoric
* Rirya Azukla Bakhnu Touwa
* Rukue Luifou Gimkas Ingurion
* Xokel Gognoileu Kester Wuro
* Xuyrod Syonay Fagul Khargo

#### Sobrenomes aleatórios

Nomes completamente aleatórios são difícieis de testar pois são estranhos de memorizar,vou gerar uma lista com primeiros nomes comuns no Brasil

Metodologia: Buscarei a uma lista de nome populares, ordenarei em ordem alfabética e concatenarei com sobrenomes gerados de uma lista de nomes de fantasia

* Ana Furirezu
* Artur Syonay
* Bernardo Zuamolri
* Bruna Geomba
* Clara Noyke
* Davi Thuringa
* Eduarda Wyavuarandir
* Enzo Koinael
* Gabriel Coehu
* Heitor Marid
* Helena Vyuadan
* Isabela Belegvoion
* João Caok
* Júlia Daxuaog
* Laura Gognoileu
* Lorenzo Wuro
* Manuela Heastai
* Maria Azukla
* Miguel Touwa
* Pedro Arpurim
* Rafael Kaciamph
* Sofia Luifou
* Valentina Ingurion

## Nomes de empresas

Metodologia: Nomes gerados de uma lista de nomes de fantasia concatenados de LTDA. A primeira letra será repetida para facilitar localização

* AAAegur Bayortur 2901507 LTDA
* BBBuwir Koidirn 9364423 LTDA
* CCCosoe Alungrim 3087491 LTDA
* DDDaumu Tyuha 8491702 LTDA
* EEEspen Umurvi 7719036 LTDA
* FFFloluaim Kruimexeu 7685825 LTDA
* GGGaerl Huvoeion 2829655 LTDA
* MMMuzsauxo Yatugurz 6927530 LTDA
* RRRumyo Bikeha 4658927 LTDA
* SSSivokeku Kagurz 8885230 LTDA
* WWWoxuoku Narduyko 8175854 LTDA
* ZZZapor Vihaior 3988755 LTDA

## Endereços

Como o software da Receita, valida o endereço, não dá para gerar completamente aleatório, então vou colocar uma lista contendo locais conhecidos ou pontos turísticos

### DF

* Congresso Nacional:  Palácio do Congresso Nacional - Praça dos 3 Poderes, Brasília - DF, 70160-900
* Palácio da Alvorada: Zona Cívico-Administrativa - Brasília, DF, 70150-903
* Catedral Metropolitana: Esplanada dos Ministérios lote 12 - Brasília, DF, 70050-000

### SP Capital

* Pq Ibirapuera:  Av. Pedro Álvares Cabral - Vila Mariana, São Paulo - SP, 04094-050
* Mercado Municipal: R. Cantareira, 306 - Centro Histórico de São Paulo, São Paulo - SP, 01024-900
* Parque Zoológico: Av. Miguel Estéfno, 4241 - Vila Santo Estefano, São Paulo - SP, 04301-002
* Aquário: R. Huet Bacelar, 407 - Vila São José, São Paulo - SP, 04275-000
* Jardim Botânico: Av. Miguel Estéfno, 3031 - Vila Água Funda, São Paulo - SP, 04301-902

### RJ Capital

* Real Gabinete: R. Luís de Camões, 30 - Centro, Rio de Janeiro - RJ, 20051-020
* Praça Muhammad Ali - Via Binário do Porto, s/n - Gamboa, Rio de Janeiro - RJ, 20220-360
* Parque Lage: R. Jardim Botânico, 414 - Jardim Botânico
* Arcos da Lapa: Lapa, Rio de Janeiro - RJ, 20031-040
* Jardim Botânico: R. Jardim Botânico, 1008, Rio de Janeiro - RJ, 22460-000
