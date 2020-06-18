using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
   public class R88_RendimentoExclusivo_Tipo2 : IFixedLenLine
   {
       public R88_RendimentoExclusivo_Tipo2() { }
       public R88_RendimentoExclusivo_Tipo2(IR_RegistroHeader Header, int Codigo)
       {
           NR_Reg = 88;
           NR_Cpf = Header.CPF_Contribuinte;
           IN_Tipo = "T";
           NR_Cpf_Benefic = Header.CPF_Contribuinte;
           NR_Cod = Codigo;
       }
       [Index(1), Type(TipoRegistro.N), Length(2)]
       public int NR_Reg { get; set; }

       [Index(2), Type(TipoRegistro.C), Length(11)]
       public string NR_Cpf { get; set; }

       [Index(3), Type(TipoRegistro.C), Length(1)]
       public string IN_Tipo { get; set; }

       [Index(4), Type(TipoRegistro.C), Length(11)]
       public string NR_Cpf_Benefic { get; set; }

       [Index(5), Type(TipoRegistro.C), Length(4)]
       public int NR_Cod { get; set; }

       [Index(6), Type(TipoRegistro.C), Length(14)]
       public string NR_Pagadora { get; set; }

       [Index(7), Type(TipoRegistro.C), Length(60)]
       public string NM_Nome { get; set; }

       [Index(8), Type(TipoRegistro.N), Length(13, 2)]
       public decimal VR_Valor { get; set; }

       [Index(9), Type(TipoRegistro.N), Length(10)]
       public string NR_Controle { get; set; }
    }
}
