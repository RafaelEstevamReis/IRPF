using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
   public class R83_RendimentoIsento_Tipo2 : IFixedLenLine
   {
       [Index(1), Type(TipoRegistro.N), Length(2)]
       public int NR_Reg { get; set; }

       [Index(2), Type(TipoRegistro.C), Length(11)]
       public string NR_Cpf { get; set; }

       [Index(3), Type(TipoRegistro.C), Length(1)]
       public string IN_Tipo { get; set; }

       [Index(4), Type(TipoRegistro.C), Length(11)]
       public string NR_Cpf_BenefIC { get; set; }

       /*
          19=Transferências patrimoniais – meação e divórcio
          20=Ganhos líquidos de ações até R$ 20.000,00
          21=Ganhos líquidos com ouro até R$ 20.000,00
        */
       [Index(5), Type(TipoRegistro.N), Length(4)]
       public int NR_COD { get; set; }

       [Index(6), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_Valor { get; set; }

       [Index(7), Type(TipoRegistro.N), Length(10)]
       public string NR_Controle { get; set; }
    }
}
