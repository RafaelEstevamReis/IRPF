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
        public R24_RendimentosTributacaoExclusiva[] RendimentosTributacaoExclusiva { get; private set; }
        public R26_RelacaoPagamentosEfetuados[] RelacaoPagamentosEfetuados { get; private set; }
        public R27_BensDireitos[] BensDireitos { get; private set; }

        public R83_RendimentoIsento_Tipo2[] RendimentosIsentos_Tipo2 { get; private set; }

        public static DEC_Intermediate FromFile(string file)
        {
            DEC_Intermediate dec = new DEC_Intermediate();
            dec.lines = File.ReadAllLines(file);
            // Id "IR"
            dec.Header = new IR_RegistroHeader();
            dec.Header.Deserialize(dec.lines[0]);
            // Id "16"
            dec.Declarante = new R16_Declarante();
            dec.Declarante.Deserialize(dec.lines[1]);

            var lstR21 = new List<R21_RendimentosPJ>();
            var lstR22 = new List<R22_RendimentosPfExteriorLeao>();
            var lstR23 = new List<R23_RendimentosIsentosNaoTributaveis>();
            var lstR24 = new List<R24_RendimentosTributacaoExclusiva>();
            var lstR26 = new List<R26_RelacaoPagamentosEfetuados>();
            var lstR27 = new List<R27_BensDireitos>();
            var lstR83 = new List<R83_RendimentoIsento_Tipo2>();

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
                    case "24":
                        var r24 = new R24_RendimentosTributacaoExclusiva();
                        r24.Deserialize(linha);
                        lstR24.Add(r24);
                        continue;
                    case "26":
                        var r26 = new R26_RelacaoPagamentosEfetuados();
                        r26.Deserialize(linha);
                        lstR26.Add(r26);
                        continue;
                    case "27":
                        var r27 = new R27_BensDireitos();
                        r27.Deserialize(linha);
                        lstR27.Add(r27);
                        continue;

                    case "83":
                        lstR83.Add(carregarRegistro<R83_RendimentoIsento_Tipo2>(linha));
                        continue;
                }
            }
            dec.RendimentosPJ = lstR21.ToArray();
            dec.RendimentosPfExteriorLeao = lstR22.ToArray();
            dec.RendimentosIsentosNaoTributaveis = lstR23.ToArray();
            dec.RendimentosTributacaoExclusiva = lstR24.ToArray();
            dec.RelacaoPagamentosEfetuados = lstR26.ToArray();
            dec.BensDireitos = lstR27.ToArray();
            dec.RendimentosIsentos_Tipo2 = lstR83.ToArray();

            return dec;
        }
        public static T carregarRegistro<T>(string Linha) where T : IFixedLenLine
        {
            var inst = (T)Activator.CreateInstance(typeof(T));
            inst.Deserialize(Linha);
            return inst;
        }
        private static void processaLinha(int i, DEC_Intermediate dec)
        {
           

        }
    }
}