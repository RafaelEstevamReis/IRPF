using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace IRPF.Lib.Declaracao
{
    public class BensItens
    {
        [XmlAttribute("pais")]
        public int Pais { get; set; }
        [XmlAttribute("discriminacao")]
        public string Descricao { get; set; }
        [XmlAttribute("codigo")]
        public int CodigoBem { get; set; }
        [XmlIgnore]
        public decimal ValorAtual { get; set; }
        [XmlAttribute("valorExercicioAtual")]
        public string XML_ValorAtual
        {
            get { return Helpers.ConversoesXML.Decimal_Get(ValorAtual); }
            set { ValorAtual = Helpers.ConversoesXML.Decimal_Set(value); }
        }
        [XmlIgnore]
        public decimal ValorAnterior { get; set; }
        [XmlAttribute("valorExercicioAnterior")]
        public string XML_ValorAnterior
        {
            get { return Helpers.ConversoesXML.Decimal_Get(ValorAnterior); }
            set { ValorAnterior = Helpers.ConversoesXML.Decimal_Set(value); }
        }
    }
}
