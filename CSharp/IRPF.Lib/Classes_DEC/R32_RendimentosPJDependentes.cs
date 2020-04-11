using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
   public  class R32_RendimentosPJDependentes : IFixedLenLine
   {
       [Index(1), Type(TipoRegistro.N), Length(2)]
       public int NR_Reg { get; set; }

       [Index(2), Type(TipoRegistro.C), Length(11)]
       public string NR_Cpf { get; set; }

       [Index(3), Type(TipoRegistro.C), Length(11)]
       public string Cpf_Benef { get; set; }

       [Index(4), Type(TipoRegistro.C), Length(14)]
       public string NR_Pagador { get; set; }

       [Index(5), Type(TipoRegistro.C), Length(60)]
       public string NM_Pagador { get; set; }

       [Index(6), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_Rendto { get; set; }

       [Index(7), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_Contrib { get; set; }

       [Index(8), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_DecTerc { get; set; }

       [Index(9), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_Imposto { get; set; }

       [Index(10), Type(TipoRegistro.C), Length(8)]
       public string DT_Comunicacao_Saida { get; set; }

       [Index(11), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_IRRF13Salario { get; set; }

       [Index(12), Type(TipoRegistro.N), Length(10)]
       public string NR_Controle { get; set; }
    }
}
