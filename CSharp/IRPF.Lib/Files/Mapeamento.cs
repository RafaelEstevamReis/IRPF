namespace IRPF.Lib.Files;

using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

[XmlRoot(Namespace = "", IsNullable = false)]
public class Mapeamento
{
    [XmlElement("DeclaracaoTXT", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MapeamentoDeclaracaoTXT[] Items { get; set; }

    public static Mapeamento fromFile(string Path)
    {
        try
        {
            using (var reader = new StreamReader(Path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Mapeamento));
                return (Mapeamento)serializer.Deserialize(reader);
            }
        }
        catch (XmlException xe)
        { throw; }
        catch (InvalidOperationException ioe)
        { throw; }
    }
}

public class MapeamentoDeclaracaoTXT
{
    public MapeamentoDeclaracaoTXTRegistro this[int Idx]
    {
        get { return Registro[Idx]; }
    }
    public MapeamentoDeclaracaoTXTRegistro this[string Id]
    {
        get { return Registro.First(o => o.Identificador == Id); }
    }

    [XmlElement("Registro", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MapeamentoDeclaracaoTXTRegistro[] Registro { get; set; }

    [XmlAttribute()]
    public string TipoArquivo { get; set; }

    public override string ToString()
    {
        return TipoArquivo;
    }
}

public class MapeamentoDeclaracaoTXTRegistro
{
    [XmlElement("Campo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public MapeamentoDeclaracaoTXTRegistroCampo[] Campos { get; set; }
    [XmlAttribute()]
    public string Nome { get; set; }
    [XmlAttribute()]
    public string Identificador { get; set; }
    [XmlAttribute()]
    public string Descricao { get; set; }
    [XmlAttribute()]
    public string Descrição { get; set; }
    [XmlAttribute()]
    public string Colecao { get; set; }

    public override string ToString()
    {
        return string.Format("{0} - {1}", Identificador, Nome);
    }
}

public class MapeamentoDeclaracaoTXTRegistroCampo
{
    [XmlAttribute()]
    public string Nome { get; set; }
    [XmlAttribute()]
    public string Descricao { get; set; }
    [XmlAttribute()]
    public string Tamanho { get; set; }
    [XmlAttribute()]
    public string Tipo { get; set; }
    [XmlAttribute()]
    public string Decimais { get; set; }
    [XmlAttribute()]
    public string Conteudo { get; set; }
    [XmlAttribute()]
    public string atributoObjetoNegocio { get; set; }
    [XmlAttribute()]
    public string CasasDecimais { get; set; }
    [XmlAttribute()]
    public string ParticipaImportacao { get; set; }

    public string AtributoLen()
    {
        return string.Format("Length({0}{1})", Tamanho, Decimais == null ? "" : "," + Decimais);
    }

    public override string ToString()
    {
        return string.Format("{0}({1}{2}) {3}", Tipo, Tamanho, Decimais == null ? "" : "," + Decimais, Nome);
    }
}