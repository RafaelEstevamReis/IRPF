using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
   public  class R84_RendimentoIsento_Tipo3 : IFixedLenLine
   {  
       public R84_RendimentoIsento_Tipo3() { }
       public R84_RendimentoIsento_Tipo3(IR_RegistroHeader Header, int Codigo)
       {
           NR_Reg = 84;
           NR_Cpf = Header.CPF_Contribuinte;
           IN_Tipo = "T";
           NR_Cpf_BenefIC = Header.CPF_Contribuinte;
           NR_Cod = Codigo;
       }

       [Index(1), Type(TipoRegistro.N), Length(2)]
       public int NR_Reg { get; set; }

       [Index(2), Type(TipoRegistro.C), Length(11)]
       public string NR_Cpf { get; set; }

       [Index(3), Type(TipoRegistro.C), Length(1)]
       public string IN_Tipo { get; set; }

       [Index(4), Type(TipoRegistro.C), Length(11)]
       public string NR_Cpf_BenefIC { get; set; }

       /*
          1 = Bolsas de estudo e de pesquisa caracterizada como doação
          2=Bolsas de médico-residente ou de participante do Pronatec
          4=Indenizações por rescisão de contrato de trabalho, PDV e FGTS
          9=Lucros e dividendos recebidos
          10=Parcela isenta de aposentadoria de maior de 65 anos
          12=Rendimentos de poupanças e letras hipotecárias
          13=Rendimentos de sócio de ME ou optante pelo Simples, exceto pró-labore
          14=Transferências patrimoniais – doações e heranças
          16=Imposto de anos anteriores compensado judicialmente
          17=75%
          18=Incorporação de reservas de capital
        */
       [Index(5), Type(TipoRegistro.N), Length(4)]
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
