using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
   public class R85_RendimentoIsento_Tipo4: IFixedLenLine
   {
       [Index(1), Type(TipoRegistro.N), Length(2)]
       public int NR_Reg { get; set; }

       [Index(2), Type(TipoRegistro.C), Length(11)]
       public string NR_Cpf { get; set; }

       [Index(3), Type(TipoRegistro.C), Length(1)]
       public string IN_Tipo { get; set; }

       [Index(4), Type(TipoRegistro.C), Length(11)]
       public string NR_Cpf_BenefIC { get; set; }

       /* Cod: 11 = Pensão, aposentadoria ou reforma por doença grave ou por acidente */
       [Index(5), Type(TipoRegistro.N), Length(4)]
       public int NR_Cod { get; set; }

       [Index(6), Type(TipoRegistro.C), Length(14)]
       public string NR_Pagadora { get; set; }

       [Index(7), Type(TipoRegistro.C), Length(60)]
       public string NM_Nome { get; set; }

       [Index(8), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_Receb { get; set; }

       [Index(9), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_13Salario { get; set; }

       [Index(10), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_IRRF { get; set; }

       [Index(11), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_IRRF13Salario { get; set; }

       [Index(12), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_Previdencia { get; set; }

       [Index(13), Type(TipoRegistro.N), Length(10)]
       public string NR_Controle { get; set; }
    }
}
