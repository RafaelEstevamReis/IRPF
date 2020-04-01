using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
   public class R90_RelacaoDoacoes : IFixedLenLine
   {
       [Index(1), Type(TipoRegistro.N), Length(2)]
       public int NR_Reg { get; set; }

       [Index(2), Type(TipoRegistro.C), Length(11)]
       public string NR_Cpf { get; set; }

       [Index(3), Type(TipoRegistro.N), Length(2)]
       public int CD_Doacao { get; set; }

       [Index(4), Type(TipoRegistro.C), Length(14)]
       public string NR_Benef { get; set; }

       [Index(5), Type(TipoRegistro.C), Length(60)]
       public string NM_Benef { get; set; }

       [Index(6), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_Doacao { get; set; }

       [Index(7), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_Parc_Nao_Dedut { get; set; }

       [Index(8), Type(TipoRegistro.N), Length(1)]
       public int IN_Tipo_Cpf_Cnpj { get; set; }

       [Index(9), Type(TipoRegistro.N), Length(10)]
       public string NR_Controle { get; set; }
    }
}
