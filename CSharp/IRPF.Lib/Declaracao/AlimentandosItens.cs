using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IRPF.Lib.Declaracao
{
    public class AlimentandosItens : IRPFBase
    {
        [XmlAttribute("nome")]
        public string Nome { get; set; }
        [XmlAttribute("cpf")]
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
