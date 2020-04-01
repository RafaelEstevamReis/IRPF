using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Classes_DEC
{
    public class T9_Encerramento : IFixedLenLine
    {
        [Index(1), Type(TipoRegistro.C), Length(2)]
        public string NR_Reg { get; set; }

        [Index(2), Type(TipoRegistro.C), Length(11)]
        public string NR_Cpf { get; set; }

        [Index(3), Type(TipoRegistro.N), Length(6)]
        public int QT_Total { get; set; }

        [Index(4), Type(TipoRegistro.N), Length(5)]
        public int QT_R16 { get; set; }

        [Index(5), Type(TipoRegistro.N), Length(5)]
        public int QT_R17 { get; set; }

        [Index(6), Type(TipoRegistro.N), Length(5)]
        public int QT_R18 { get; set; }

        [Index(7), Type(TipoRegistro.N), Length(5)]
        public int QT_R19 { get; set; }

        [Index(8), Type(TipoRegistro.N), Length(5)]
        public int QT_R20 { get; set; }

        [Index(9), Type(TipoRegistro.N), Length(5)]
        public int QT_R21 { get; set; }

        [Index(10), Type(TipoRegistro.N), Length(5)]
        public int QT_R22 { get; set; }

        [Index(11), Type(TipoRegistro.N), Length(5)]
        public int QT_R23 { get; set; }

        [Index(12), Type(TipoRegistro.N), Length(5)]
        public int QT_R24 { get; set; }

        [Index(13), Type(TipoRegistro.N), Length(5)]
        public int QT_R25 { get; set; }

        [Index(14), Type(TipoRegistro.N), Length(5)]
        public int QT_R26 { get; set; }

        [Index(15), Type(TipoRegistro.N), Length(5)]
        public int QT_R27 { get; set; }

        [Index(16), Type(TipoRegistro.N), Length(5)]
        public int QT_R28 { get; set; }

        [Index(17), Type(TipoRegistro.N), Length(5)]
        public int QT_FILLER1 { get; set; }

        [Index(18), Type(TipoRegistro.N), Length(5)]
        public int QT_R30 { get; set; }

        [Index(19), Type(TipoRegistro.N), Length(5)]
        public int QT_FILLER2 { get; set; }

        [Index(20), Type(TipoRegistro.N), Length(5)]
        public int QT_R32 { get; set; }

        [Index(21), Type(TipoRegistro.N), Length(5)]
        public int QT_FILLER3 { get; set; }

        [Index(22), Type(TipoRegistro.N), Length(5)]
        public int QT_R34 { get; set; }

        [Index(23), Type(TipoRegistro.N), Length(5)]
        public int QT_R35 { get; set; }

        [Index(24), Type(TipoRegistro.N), Length(5)]
        public int QT_FILLER4 { get; set; }

        [Index(25), Type(TipoRegistro.N), Length(5)]
        public int QT_FILLER5 { get; set; }

        [Index(26), Type(TipoRegistro.N), Length(5)]
        public int QT_R38 { get; set; }

        [Index(27), Type(TipoRegistro.N), Length(5)]
        public int QT_R39 { get; set; }

        [Index(28), Type(TipoRegistro.N), Length(5)]
        public int QT_R40 { get; set; }

        [Index(29), Type(TipoRegistro.N), Length(5)]
        public int QT_R41 { get; set; }

        [Index(30), Type(TipoRegistro.N), Length(5)]
        public int QT_R42 { get; set; }

        [Index(31), Type(TipoRegistro.N), Length(5)]
        public int QT_R43 { get; set; }

        [Index(32), Type(TipoRegistro.N), Length(5)]
        public int QT_FILLER6 { get; set; }

        [Index(33), Type(TipoRegistro.N), Length(5)]
        public int QT_R45 { get; set; }

        [Index(34), Type(TipoRegistro.N), Length(5)]
        public int QT_R46 { get; set; }

        [Index(35), Type(TipoRegistro.N), Length(5)]
        public int QT_R47 { get; set; }

        [Index(36), Type(TipoRegistro.N), Length(5)]
        public int QT_R48 { get; set; }

        [Index(37), Type(TipoRegistro.N), Length(5)]
        public int QT_R49 { get; set; }

        [Index(38), Type(TipoRegistro.N), Length(5)]
        public int QT_R50 { get; set; }

        [Index(39), Type(TipoRegistro.N), Length(5)]
        public int QT_R51 { get; set; }

        [Index(40), Type(TipoRegistro.N), Length(5)]
        public int QT_R52 { get; set; }

        [Index(41), Type(TipoRegistro.N), Length(5)]
        public int QT_R53 { get; set; }

        [Index(42), Type(TipoRegistro.N), Length(5)]
        public int QT_R54 { get; set; }

        [Index(43), Type(TipoRegistro.N), Length(5)]
        public int QT_R55 { get; set; }

        [Index(44), Type(TipoRegistro.N), Length(5)]
        public int QT_R56 { get; set; }

        [Index(45), Type(TipoRegistro.N), Length(5)]
        public int QT_FILLER7 { get; set; }

        [Index(46), Type(TipoRegistro.N), Length(5)]
        public int QT_R58 { get; set; }

        [Index(47), Type(TipoRegistro.N), Length(5)]
        public int QT_R59 { get; set; }

        [Index(48), Type(TipoRegistro.N), Length(5)]
        public int QT_R60 { get; set; }

        [Index(49), Type(TipoRegistro.N), Length(5)]
        public int QT_R61 { get; set; }

        [Index(50), Type(TipoRegistro.N), Length(5)]
        public int QT_R62 { get; set; }

        [Index(51), Type(TipoRegistro.N), Length(5)]
        public int QT_R63 { get; set; }

        [Index(52), Type(TipoRegistro.N), Length(5)]
        public int QT_R64 { get; set; }

        [Index(53), Type(TipoRegistro.N), Length(5)]
        public int QT_R65 { get; set; }

        [Index(54), Type(TipoRegistro.N), Length(5)]
        public int QT_R66 { get; set; }

        [Index(55), Type(TipoRegistro.N), Length(5)]
        public int QT_R67 { get; set; }

        [Index(56), Type(TipoRegistro.N), Length(5)]
        public int QT_R68 { get; set; }

        [Index(57), Type(TipoRegistro.N), Length(5)]
        public int QT_R69 { get; set; }

        [Index(58), Type(TipoRegistro.N), Length(5)]
        public int QT_R70 { get; set; }

        [Index(59), Type(TipoRegistro.N), Length(5)]
        public int QT_R71 { get; set; }

        [Index(60), Type(TipoRegistro.N), Length(5)]
        public int QT_R72 { get; set; }

        [Index(61), Type(TipoRegistro.N), Length(5)]
        public int QT_R73 { get; set; }

        [Index(62), Type(TipoRegistro.N), Length(5)]
        public int QT_R74 { get; set; }

        [Index(63), Type(TipoRegistro.N), Length(5)]
        public int QT_R75 { get; set; }

        [Index(64), Type(TipoRegistro.N), Length(20)]
        public int QT_FILLER8 { get; set; }

        [Index(65), Type(TipoRegistro.N), Length(5)]
        public int QT_R80 { get; set; }

        [Index(66), Type(TipoRegistro.N), Length(5)]
        public int QT_R81 { get; set; }

        [Index(67), Type(TipoRegistro.N), Length(5)]
        public int QT_FILLER9 { get; set; }

        [Index(68), Type(TipoRegistro.N), Length(5)]
        public int QT_R83 { get; set; }

        [Index(69), Type(TipoRegistro.N), Length(5)]
        public int QT_R84 { get; set; }

        [Index(70), Type(TipoRegistro.N), Length(5)]
        public int QT_R85 { get; set; }

        [Index(71), Type(TipoRegistro.N), Length(5)]
        public int QT_R86 { get; set; }

        [Index(72), Type(TipoRegistro.N), Length(5)]
        public int QT_R87 { get; set; }

        [Index(73), Type(TipoRegistro.N), Length(5)]
        public int QT_R88 { get; set; }

        [Index(74), Type(TipoRegistro.N), Length(5)]
        public int QT_R89 { get; set; }

        [Index(75), Type(TipoRegistro.N), Length(5)]
        public int QT_R90 { get; set; }

        [Index(76), Type(TipoRegistro.N), Length(5)]
        public int QT_R91 { get; set; }

        [Index(77), Type(TipoRegistro.N), Length(5)]
        public int QT_R92 { get; set; }

        [Index(78), Type(TipoRegistro.N), Length(35)]
        public int QT_FILLER10 { get; set; }

        [Index(79), Type(TipoRegistro.N), Length(10)]
        public string NR_Controle { get; set; }
    }
}
