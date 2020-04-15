using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IRPF.Lib.Declaracao
{
   public class DependentesItens : IRPFBase
   {
       [XmlAttribute("codigo")]
       public int Codigo { get; set; }
       [XmlAttribute("nome")]
       public string Nome { get; set; }
       [XmlAttribute("cpf")]
       public string CPF { get; set; }
       public DateTime DataNascimento { get; set; }
    }
}
