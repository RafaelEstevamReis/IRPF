using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IRPF.Lib.Declaracao
{
    public class BensItens
    {
        public int Pais { get; set; }
        public string Descricao { get; set; }
        public int CodigoBem { get; set; }
        public decimal ValorAtual { get; set; }
        public decimal ValorAnterior { get; set; }
    }
}
