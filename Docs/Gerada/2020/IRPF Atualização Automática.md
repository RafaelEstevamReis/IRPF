# IRPF - Atualização automática

## Verificação de Updates

### DNS

Quando abro a versão 1.4 do IRPF versão Windows é feita uma query DNS:

~~~
downloadirpf.receita.fazenda.gov.br: type A, class IN
~~~

Para qual o servidor de DNS retorna:

~~~
downloadirpf.receita.fazenda.gov.br: type A, class IN, addr 161.148.231.16
~~~

### Consulta

Após a resolução no nome, é enviado uma query HTTP (não seguro) 

~~~ HTTP
GET /irpf/2020/irpf/update/latest.xml HTTP/1.1
Cache-Control: no-cache
Pragma: no-cache
User-Agent: Java/13.0.2
Host: downloadirpf.receita.fazenda.gov.br
Accept: text/html, image/gif, image/jpeg, *; q=.2, */*; q=.2
Connection: keep-alive
~~~

E é retornado:

~~~ HTTP
HTTP/1.1 200 OK
Date: XXX, 00 Apr 2020 00:00:00 GMT
Server: Apache
Last-Modified: XXX, 00 Apr 2020 00:00:00 GMT
ETag: "000-0000000000000"
Accept-Ranges: bytes
Content-Length: 2015
Vary: Accept-Encoding
Keep-Alive: timeout=60, max=100
Connection: Keep-Alive
Content-Type: text/xml

<?xml version="1.0" encoding="ISO-8859-1"?>
<information>
	<pubDate>00/04/2020 00:00</pubDate>
	<pkgver>1.6</pkgver>
	<pkgrel></pkgrel>
	<severity>Opcional</severity>
	<extra>
		<message>{ultimaVersaoManual:"1.0", periodoEspera:5, enderecoServidorDownloadManual:"https://idg.receita.fazenda.gov.br/interface/cidadao/irpf/2020/download", enderecoServidor:"http://downloadirpf.receita.fazenda.gov.br/irpf/2020/irpf/update/", arquivoZip:"IRPF2020-@.zip", mensagem:""}</message>
		<files>
			<file>
				<fileId>ECA</fileId>
				<fileVersion>20200327</fileVersion>
				<fileHash>-754612957</fileHash>
				<filePath>lib/resources/eca.xml</filePath>
				<filePackageName>ECA__20200327_20200327010133.zip</filePackageName>
			</file>
			<file>
				<fileId>IDOSO</fileId>
				<fileVersion>20200318</fileVersion>
				<fileHash>-1962364021</fileHash>
				<filePath>lib/resources/eidoso.xml</filePath>
				<filePackageName>IDOSO__20200318_20200318010140.zip</filePackageName>
			</file>
			<file>
				<fileId>BANCO</fileId>
				<fileVersion>20200214</fileVersion>
				<fileHash>464864309</fileHash>
				<filePath>lib/resources/bancos.xml</filePath>
				<filePackageName>BANCO__20200214_20200214162252.zip</filePackageName>
			</file>
			<file>
				<fileId>BBENS</fileId>
				<fileVersion>20200320</fileVersion>
				<fileHash>1423162183</fileHash>
				<filePath>lib/resources/bancos_bens.xml</filePath>
				<filePackageName>BBENS__20200320_20200320010116.zip</filePackageName>
			</file>
			<file>
				<fileId>NATOC</fileId>
				<fileVersion>20200206</fileVersion>
				<fileHash>-1388464830</fileHash>
				<filePath>lib/resources/naturezasOcupacao.xml</filePath>
				<filePackageName>NATOC__20200206_20200214162252.zip</filePackageName>
			</file>
			<file>
				<fileId>PAIS</fileId>
				<fileVersion>20200218</fileVersion>
				<fileHash>280293192</fileHash>
				<filePath>lib/resources/paises.xml</filePath>
				<filePackageName>PAIS__20200218_20200218095929.zip</filePackageName>
			</file>
		</files>
	</extra>
</information>
~~~

Conteúdo do campo `message` formatado:
```json
{
   "ultimaVersaoManual":"1.0",
   "periodoEspera":5,
   "enderecoServidorDownloadManual":"https://idg.receita.fazenda.gov.br/interface/cidadao/irpf/2020/download",
   "enderecoServidor":"http://downloadirpf.receita.fazenda.gov.br/irpf/2020/irpf/update/",
   "arquivoZip":"IRPF2020-@.zip",
   "mensagem":""
}
```
Obs: Foram inseridas aspas faltantes na mensagem original

Arquivo [latest.xml](latest.xml) capturado foi salvo nesta mesma pasta

Uma busca pelo conteúdo do XML me levou até o repositório de uma biblioteca chamada [JUPAR](https://github.com/MasterEx/jupar). Veja o [blog do Periklis Ntanasis](https://masterex.github.io/archive/2011/12/25/jupar.html)

-------

Me preocupa o fato de que a transmissão é feita de forma insegura (sem o uso do HTTPS), os dados podem ser manipulados para forçar a aplicação a baixar e executar código arbitrário

Exemplo de ataque:
~~~
Com um envenenamento simples (até local) de DNS, a requisição pode ser redirecionada instruindo uma atualização a aprtir de um servidor que não seja o da receita, então um arquivo preparado será instalado e executado
~~~

Eu não verifiquei se o IRPF aceita qualquer endereço de atualização recebido no XML ou se ele obriga (internamente ?) que o URL contenha, por exemplo, `fazenda.gov.br`

