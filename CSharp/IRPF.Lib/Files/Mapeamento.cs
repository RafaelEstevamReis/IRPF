using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace IRPF.Lib.Files
{
    [XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Mapeamento
    {
        [XmlElementAttribute("DeclaracaoTXT", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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

        [XmlElementAttribute("Registro", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MapeamentoDeclaracaoTXTRegistro[] Registro { get; set; }

        [XmlAttributeAttribute()]
        public string TipoArquivo { get; set; }

        public override string ToString()
        {
            return TipoArquivo;
        }
    }

    public class MapeamentoDeclaracaoTXTRegistro
    {
        [XmlElementAttribute("Campo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MapeamentoDeclaracaoTXTRegistroCampo[] Campos { get; set; }
        [XmlAttributeAttribute()]
        public string Nome { get; set; }
        [XmlAttributeAttribute()]
        public string Identificador { get; set; }
        [XmlAttributeAttribute()]
        public string Descricao { get; set; }
        [XmlAttributeAttribute()]
        public string Descrição { get; set; }
        [XmlAttributeAttribute()]
        public string Colecao { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Identificador, Nome);
        }
    }

    public class MapeamentoDeclaracaoTXTRegistroCampo
    {
        [XmlAttributeAttribute()]
        public string Nome { get; set; }
        [XmlAttributeAttribute()]
        public string Descricao { get; set; }
        [XmlAttributeAttribute()]
        public string Tamanho { get; set; }
        [XmlAttributeAttribute()]
        public string Tipo { get; set; }
        [XmlAttributeAttribute()]
        public string Decimais { get; set; }
        [XmlAttributeAttribute()]
        public string Conteudo { get; set; }
        [XmlAttributeAttribute()]
        public string atributoObjetoNegocio { get; set; }
        [XmlAttributeAttribute()]
        public string CasasDecimais { get; set; }
        [XmlAttributeAttribute()]
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

}