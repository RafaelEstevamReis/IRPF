using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R87_RendimentoIsento_Tipo6 : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        /*
           05=Lucro na alienação de bens de pequeno valor
           06=Lucro na alienação do único imóvel
           07=Lucro na alienação de outros bens imóvel.
         */
        [Index(3), Type(TipoRegistro.N), Length(4)]
        public int NR_Cod { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Valor { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_ValorGCap { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}
