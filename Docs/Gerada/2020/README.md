# Arquivos Gerados referentes à 2020    

## Arquivos do repositório:

### 11111111030-IRPF-A-2020-2019-ORIGI.DBK

Arquivo gerado com dados aleatórios no IRPF versão 2020 \
Valores foram escolhidos para facilitar a achar campos, o CPF é 111.111.110-30 pois os "1"s ajudam a localizar \
Os CPFs dos dependentes são sequências de "2" e "3"

Processos semelhantes foram gerados para os CNPJs que ou são sequências de núemros "1", "2", etc..

### 22222222303-IRPF-A-2020-2019-ORIGI.DEC - Simplificada

Arquivo gerado com dados aleatórios no IRPF versão 2020 v1.4 \
Valores foram escolhidos para facilitar a achar campos

Os dados foram gerados de acordo com o README com exemplos de dados

* Contribuinte: 222.222.223-03 Olzefu Byaisno Asrim
* Dependente: Cod 11 - 333.333.334-14 Ana Furirezu
* Alimentando: 444.444.445-25 Artur Syonay
* Rendimentos Recebidos PJ, titular e dependente
* Rendimentos Isentos e Não Tributáveis do titular e dependente
* Rendimentos Sujeitos a Trib. Exclusiva/Definitiva do titular e dependente
* Pagamentos do titular e dependente
* Bens e Direitos: Apartamento e Automóvel
* Dívidas e ônus

Processos semelhantes foram gerados para os CNPJs que ou são sequências de núemros "1", "2", etc..

#### Diferença entre o DEC e o DBK

A diferença entre os arquivos é:
* O NR_HASH não muda
* o NR_CONTROLE muda
* o DEC tem os registros HR, DR e R9

### 22222222303-0000000000.xml

Arquivo XML da pasta Aplicação->Dados da mesma declaração que gerou o arquivo `22222222303-IRPF-A-2020-2019-ORIGI.DEC`

Parece ser a seriazação completa da declaração na aplicação, notei que é preferido o uso de Atributos ao invés de Elementos

## Links e Sites:

### Site para gerar CPFs e CNPJs com dígitos válidos

Site que gera CPFs e outros números respeitando as regras de cálculo [4devs](https://www.4devs.com.br/gerador_de_cpf)

Site que calcula o dígito para o CPF ou CNPJ fornecido, utilizei para gerar os números sequenciais como 111.111.110-30 [informatiqueiro](https://www.informatiqueiro.com.br/calcular-digito-verificador-para-cpf-e-cnpj/)
