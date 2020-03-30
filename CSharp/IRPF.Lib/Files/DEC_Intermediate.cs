using IRPF.Lib.Classes;
using IRPF.Lib.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
        public R20_TotaisDeclaracaoDesconto TotaisDeclaracao { get; private set; }
        #endregion

        public R21_RendimentosPJ[] RendimentosPJ { get; private set; }
        public R22_RendimentosPfExteriorLeao[] RendimentosPfExteriorLeao { get; private set; }
        public R23_RendimentosIsentosNaoTributaveis[] RendimentosIsentosNaoTributaveis { get; private set; }
        public R24_RendimentosTributacaoExclusiva[] RendimentosTributacaoExclusiva { get; private set; }
        public R25_Dependentes[] Dependentes { get; private set; }
        public R26_RelacaoPagamentosEfetuados[] RelacaoPagamentosEfetuados { get; private set; }
        public R27_BensDireitos[] BensDireitos { get; private set; }
        public R45_RecebidosAcumuladamente[] RecebidosAcumuladamente { get; private set; }
        public R47_RendimentosAcumuladamenteDependente[] RendimentosAcumuladamenteDependente { get; private set; }

        public R83_RendimentoIsento_Tipo2[] RendimentosIsentos_Tipo2 { get; private set; }
        public R84_RendimentoIsento_Tipo3[] RendimentosIsentos_Tipo3 { get; private set; }
        public R85_RendimentoIsento_Tipo4[] RendimentosIsentos_Tipo4 { get; private set; }
        public R86_RendimentoIsento_Tipo5[] RendimentosIsentos_Tipo5 { get; private set; }
        public R87_RendimentoIsento_Tipo6[] RendimentosIsentos_Tipo6 { get; private set; }

        public R88_RendimentoExclusivo_Tipo2[] RendimentoExclusivo_Tipo2 { get; private set; }
        public R89_RendimentoExclusivo_Tipo3[] RendimentoExclusivo_Tipo3 { get; private set; }

        public R90_RelacaoDoacoes[] RelacaoDoacoes { get; private set; }
        public R91_DoacoesECA[] DoacoesECA { get; private set; }
        public R92_DoacoesIdoso[] DoacoesIdoso { get; private set; }

        public T9_Encerramento Encerramento { get; private set; }

        public void ToFile(string file)
        {
            //using (var ms = new MemoryStream())
            using(var fs = new FileStream(file, FileMode.Create))
            {
                var sw = new StreamWriter(fs);
                
                var fields = this.GetType().GetProperties();
                foreach (var f in fields)
                {
                    var ft = f.PropertyType;
                    if (ft.IsArray)
                    {
                        Array arr = (Array)f.GetValue(this);
                        for (int i = 0; i < arr.Length; i++)
                        {
                            object o = arr.GetValue(i);
                            if (o == null) continue; // vazio
                            Serialization.Serializer.Serialize((IFixedLenLine)o, sw);
                        }
                    }
                    else
                    {
                        object o = f.GetValue(this);
                        if (o == null) continue; // vazio
                        Serialization.Serializer.Serialize((IFixedLenLine)o, sw);
                    }
                }
            }
        }

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
            var lstR25 = new List<R25_Dependentes>();
            var lstR26 = new List<R26_RelacaoPagamentosEfetuados>();
            var lstR27 = new List<R27_BensDireitos>();
            var lstR45 = new List<R45_RecebidosAcumuladamente>();
            var lstR47 = new List<R47_RendimentosAcumuladamenteDependente>();
            var lstR83 = new List<R83_RendimentoIsento_Tipo2>();
            var lstR84 = new List<R84_RendimentoIsento_Tipo3>();
            var lstR85 = new List<R85_RendimentoIsento_Tipo4>();
            var lstR86 = new List<R86_RendimentoIsento_Tipo5>();
            var lstR87 = new List<R87_RendimentoIsento_Tipo6>();

            var lstR88 = new List<R88_RendimentoExclusivo_Tipo2>();
            var lstR89 = new List<R89_RendimentoExclusivo_Tipo3>();

            var lstR90 = new List<R90_RelacaoDoacoes>();
            var lstR91 = new List<R91_DoacoesECA>();
            var lstR92 = new List<R92_DoacoesIdoso>();

            string linha;
            for (int i = 2; i < dec.lines.Length; i++)
            {
                linha = dec.lines[i];
                if (linha.Length < 2) continue;

                switch (linha.Substring(0, 2))
                {
                    case "17":
                        dec.DemaisRendimentosEImpostoPago = carregarRegistro<R17_DemaisRendimentosImpostoPago>(linha);
                        continue;
                    case "18":
                        dec.TotaisDeclaracaoSimplificada = carregarRegistro<R18_TotaisDeclaracaoDescontoSimplificado>(linha);
                        continue;

                    case "19":
                        dec.Completa = carregarRegistro<R19_Completa>(linha);
                        continue;
                    case "20":
                        dec.TotaisDeclaracao = carregarRegistro<R20_TotaisDeclaracaoDesconto>(linha);
                        continue;

                    case "21":
                        lstR21.Add(carregarRegistro<R21_RendimentosPJ>(linha));
                        continue;
                    case "22":
                        lstR22.Add(carregarRegistro<R22_RendimentosPfExteriorLeao>(linha));
                        continue;
                    case "23":
                        lstR23.Add(carregarRegistro<R23_RendimentosIsentosNaoTributaveis>(linha));
                        continue;
                    case "24":
                        lstR24.Add(carregarRegistro<R24_RendimentosTributacaoExclusiva>(linha));
                        continue;
                    case "25":
                        lstR25.Add(carregarRegistro<R25_Dependentes>(linha));
                        continue;
                    case "26":
                        lstR26.Add(carregarRegistro<R26_RelacaoPagamentosEfetuados>(linha));
                        continue;
                    case "27":
                        lstR27.Add(carregarRegistro<R27_BensDireitos>(linha));
                        continue;
                    case "45":
                        lstR45.Add(carregarRegistro<R45_RecebidosAcumuladamente>(linha));
                        continue;
                    case "47":
                        lstR47.Add(carregarRegistro<R47_RendimentosAcumuladamenteDependente>(linha));
                        continue;

                    case "83":
                        lstR83.Add(carregarRegistro<R83_RendimentoIsento_Tipo2>(linha));
                        continue;
                    case "84":
                        lstR84.Add(carregarRegistro<R84_RendimentoIsento_Tipo3>(linha));
                        continue;
                    case "85":
                        lstR85.Add(carregarRegistro<R85_RendimentoIsento_Tipo4>(linha));
                        continue;
                    case "86":
                        lstR86.Add(carregarRegistro<R86_RendimentoIsento_Tipo5>(linha));
                        continue;
                    case "87":
                        lstR87.Add(carregarRegistro<R87_RendimentoIsento_Tipo6>(linha));
                        continue;

                    case "88":
                        lstR88.Add(carregarRegistro<R88_RendimentoExclusivo_Tipo2>(linha));
                        continue;
                    case "89":
                        lstR89.Add(carregarRegistro<R89_RendimentoExclusivo_Tipo3>(linha));
                        continue;

                    case "90":
                        lstR90.Add(carregarRegistro<R90_RelacaoDoacoes>(linha));
                        continue;
                    case "91":
                        lstR91.Add(carregarRegistro<R91_DoacoesECA>(linha));
                        continue;
                    case "92":
                        lstR92.Add(carregarRegistro<R92_DoacoesIdoso>(linha));
                        continue;

                    case "T9":
                        dec.Encerramento = carregarRegistro<T9_Encerramento>(linha);
                        continue;

                    default:
                        throw new NotImplementedException(); // Notifica que ainda não terminei
                }
            }
            dec.RendimentosPJ = lstR21.ToArray();
            dec.RendimentosPfExteriorLeao = lstR22.ToArray();
            dec.RendimentosIsentosNaoTributaveis = lstR23.ToArray();
            dec.RendimentosTributacaoExclusiva = lstR24.ToArray();
            dec.Dependentes = lstR25.ToArray();
            dec.RelacaoPagamentosEfetuados = lstR26.ToArray();
            dec.BensDireitos = lstR27.ToArray();
            dec.RecebidosAcumuladamente = lstR45.ToArray();
            dec.RendimentosAcumuladamenteDependente = lstR47.ToArray();
            dec.RendimentosIsentos_Tipo2 = lstR83.ToArray();
            dec.RendimentosIsentos_Tipo3 = lstR84.ToArray();
            dec.RendimentosIsentos_Tipo4 = lstR85.ToArray();
            dec.RendimentosIsentos_Tipo5 = lstR86.ToArray();
            dec.RendimentosIsentos_Tipo6 = lstR87.ToArray();
            dec.RendimentoExclusivo_Tipo2 = lstR88.ToArray();
            dec.RendimentoExclusivo_Tipo3 = lstR89.ToArray();

            dec.RelacaoDoacoes = lstR90.ToArray();
            dec.DoacoesECA = lstR91.ToArray();
            dec.DoacoesIdoso = lstR92.ToArray();

            return dec;
        }
        public static T carregarRegistro<T>(string Linha) where T : IFixedLenLine
        {
            var inst = (T)Activator.CreateInstance(typeof(T));
            inst.Deserialize(Linha);
            return inst;
        }

    }
}