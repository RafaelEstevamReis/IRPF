using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class R22_RendimentosPfExteriorLeao : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.C), Length(1)]
        public string E_Dependente { get; set; }

        [Index(4), Type(TipoRegistro.C), Length(11)]
        public string NR_CpfDepen { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(2)]
        public int NR_Mes { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Rendto { get; set; }

        [Index(7), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Alugueis { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Outros { get; set; }

        [Index(9), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Exter { get; set; }

        [Index(10), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_LivCaix { get; set; }

        [Index(11), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Aliment { get; set; }

        [Index(12), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Deduc { get; set; }

        [Index(13), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Previd { get; set; }

        [Index(14), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_BaseCalculo { get; set; }

        [Index(15), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Imposto { get; set; }

        [Index(16), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }


    }
}
