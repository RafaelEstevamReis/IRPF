using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes
{
    public class R26_RelacaoPagamentosEfetuados : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.N), Length(2)]
        public int NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(2)]
        public int CD_Pagto { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(5)]
        public int NR_Chave_Depend { get; set; }

        [Index(5), Type(TipoRegistro.C), Length(14)]
        public string NR_Benef { get; set; }

        [Index(6), Type(TipoRegistro.C), Length(60)]
        public string NM_Benef { get; set; }

        [Index(7), Type(TipoRegistro.C), Length(11)]
        public string NR_NIT { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Pagto { get; set; }

        [Index(9), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Reduc { get; set; }

        [Index(10), Type(TipoRegistro.N), Length(13, 2)]
        public decimal VR_Contrib_PATR { get; set; }

        [Index(11), Type(TipoRegistro.N), Length(1)]
        public bool IN_Tipo_Cpf_Cnpj { get; set; }

        [Index(12), Type(TipoRegistro.C), Length(1)]
        public string IN_Tipo_Pgto { get; set; }

        [Index(13), Type(TipoRegistro.N), Length(10)]
        public int NR_Controle { get; set; }
    }
}