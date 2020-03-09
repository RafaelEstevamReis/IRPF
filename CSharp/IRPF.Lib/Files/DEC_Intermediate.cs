using IRPF.Lib.Classes;
using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Files
{
    public class DEC_Intermediate
    {
        string[] lines;
        private DEC_Intermediate() { }

        public IR_RegistroHeader Header { get; private set; }
        public R16_Declarante Declarante { get; private set; }

        #region Simplificada
        public R17_DemaisRendimentosImpostoPago DemaisRendimentosEImpostoPago { get; private set; }
        public R18_TotaisDeclaracaoDescontoSimplificado TotaisDeclaracaoSimplificada { get; private set; }

        #endregion

        #region Completa
        public R19_Completa Completa { get; private set; }

        #endregion

        public static DEC_Intermediate FromFile(string file)
        {
            DEC_Intermediate dec = new DEC_Intermediate();
            dec.lines = File.ReadAllLines(file);

            dec.Header = new IR_RegistroHeader();
            dec.Header.Deserialize(dec.lines[0]);

            dec.Declarante = new R16_Declarante();
            dec.Declarante.Deserialize(dec.lines[1]);

            for (int i = 2; i < dec.lines.Length; i++)
            {
                processaLinha(i, dec);
            }

            return dec;
        }
        private static void processaLinha(int i, DEC_Intermediate dec)
        {
            var linha = dec.lines[i];
            if (linha.Length < 2) return;

            switch (linha.Substring(0, 2))
            {
                case "17":
                    dec.DemaisRendimentosEImpostoPago = new R17_DemaisRendimentosImpostoPago();
                    dec.DemaisRendimentosEImpostoPago.Deserialize(linha);
                    return;
                case "18":
                    dec.TotaisDeclaracaoSimplificada = new R18_TotaisDeclaracaoDescontoSimplificado();
                    dec.TotaisDeclaracaoSimplificada.Deserialize(linha);
                    return;


                case "19":
                    dec.Completa = new R19_Completa();
                    dec.Completa.Deserialize(linha);
                    return;

            }
        }
    }
}