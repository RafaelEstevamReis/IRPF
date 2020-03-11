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

        public R21_RendimentosPJ[] RendimentosPJ { get; private set; }
        public R22_RendimentosPfExteriorLeao[] RendimentosPfExteriorLeao { get; private set; }
        public R23_RendimentosIsentosNaoTributaveis[] RendimentosIsentosNaoTributaveis { get; private set; }

        public static DEC_Intermediate FromFile(string file)
        {
            DEC_Intermediate dec = new DEC_Intermediate();
            dec.lines = File.ReadAllLines(file);

            dec.Header = new IR_RegistroHeader();
            dec.Header.Deserialize(dec.lines[0]);

            dec.Declarante = new R16_Declarante();
            dec.Declarante.Deserialize(dec.lines[1]);

            var lstR21 = new List<R21_RendimentosPJ>();
            var lstR22 = new List<R22_RendimentosPfExteriorLeao>();
            var lstR23 = new List<R23_RendimentosIsentosNaoTributaveis>();

            for (int i = 2; i < dec.lines.Length; i++)
            {
                var linha = dec.lines[i];
                if (linha.Length < 2) continue;
                
                switch (linha.Substring(0, 2))
                {
                    case "17":
                        dec.DemaisRendimentosEImpostoPago = new R17_DemaisRendimentosImpostoPago();
                        dec.DemaisRendimentosEImpostoPago.Deserialize(linha);
                        continue;
                    case "18":
                        dec.TotaisDeclaracaoSimplificada = new R18_TotaisDeclaracaoDescontoSimplificado();
                        dec.TotaisDeclaracaoSimplificada.Deserialize(linha);
                        continue;

                    case "19":
                        dec.Completa = new R19_Completa();
                        dec.Completa.Deserialize(linha);
                        continue;

                    case "21":
                        var pj = new R21_RendimentosPJ();
                        pj.Deserialize(linha);
                        lstR21.Add(pj);
                        continue;
                    case "22":
                        var r22 = new R22_RendimentosPfExteriorLeao();
                        r22.Deserialize(linha);
                        lstR22.Add(r22);
                        continue;
                    case "23":
                        var r23 = new R23_RendimentosIsentosNaoTributaveis();
                        r23.Deserialize(linha);
                        lstR23.Add(r23);
                        continue;
                }
            }
            dec.RendimentosPJ = lstR21.ToArray();
            dec.RendimentosPfExteriorLeao = lstR22.ToArray();
            dec.RendimentosIsentosNaoTributaveis = lstR23.ToArray();

            return dec;
        }
        private static void processaLinha(int i, DEC_Intermediate dec)
        {
           

        }
    }
}