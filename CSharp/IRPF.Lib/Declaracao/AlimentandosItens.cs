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
        [XmlIgnore]
        public DateTime DataNascimento { get; set; }
        [XmlAttribute("dtNascimento")]
        public string XML_DataNascimento
        {
            get { return Helpers.ConversoesXML.Datas_Get(DataNascimento); }
            set { DataNascimento = Helpers.ConversoesXML.Datas_Set(value); }
        }
        [XmlIgnore]
        public bool Residente { get; set; }
        [XmlAttribute("residente")]
        public string XML_Residente
        {
            get { return Helpers.ConversoesXML.BoolN_Get(Residente); }
            set { Residente = Helpers.ConversoesXML.BoolN_Set(value); }
        }
    }
}
