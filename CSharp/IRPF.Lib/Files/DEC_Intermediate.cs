using IRPF.Lib.Classes_DEC;
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
    public partial class DEC_Intermediate
    {
        string[] lines;
        private DEC_Intermediate() { }

        public IR_RegistroHeader Header { get; set; }
        public R16_Declarante Declarante { get; set; }

        #region Simplificada
        public R17_DemaisRendimentosImpostoPago DemaisRendimentosEImpostoPago { get; set; }
        public R18_TotaisDeclaracaoDescontoSimplificado TotaisDeclaracaoSimplificada { get; set; }
        #endregion

        #region Completa
        public R19_Completa Completa { get; set; }
        public R20_TotaisDeclaracaoDesconto TotaisDeclaracao { get; set; }
        #endregion

        public R21_RendimentosPJ[] RendimentosPJ { get; set; }
        public R22_RendimentosPfExteriorLeao[] RendimentosPfExteriorLeao { get; set; }
        public R23_RendimentosIsentosNaoTributaveis[] RendimentosIsentosNaoTributaveis { get; set; }
        public R24_RendimentosTributacaoExclusiva[] RendimentosTributacaoExclusiva { get; set; }
        public R25_Dependentes[] Dependentes { get; set; }
        public R26_RelacaoPagamentosEfetuados[] RelacaoPagamentosEfetuados { get; set; }
        public R27_BensDireitos[] BensDireitos { get; set; }
        public R28_DividasOnus[] DividasOnus { get; set; }
        public R30_EspolioInventariante Inventariante { get; set; }
        public R32_RendimentosPJDependentes[] RendimentosPJDependentes { get; set; }
        public R34_DoacoesPartidos[] DoacoesPartidos { get; set; }
        public R35_Alimentandos[] Alimentandos { get; set; }
        public R42_RendaVar_FII[] RendaVar_FII { get; set; }
        public R43_RendaVar_Totais_FII RendaVarTotais_FII { get; set; }
        public R45_RecebidosAcumuladamente[] RecebidosAcumuladamente { get; set; }
        public R47_RendimentosAcumuladamenteDependente[] RendimentosAcumuladamenteDependente { get; set; }

        public R83_RendimentoIsento_Tipo2[] RendimentosIsentos_Tipo2 { get; set; }
        public R84_RendimentoIsento_Tipo3[] RendimentosIsentos_Tipo3 { get; set; }
        public R85_RendimentoIsento_Tipo4[] RendimentosIsentos_Tipo4 { get; set; }
        public R86_RendimentoIsento_Tipo5[] RendimentosIsentos_Tipo5 { get; set; }
        public R87_RendimentoIsento_Tipo6[] RendimentosIsentos_Tipo6 { get; set; }

        public R88_RendimentoExclusivo_Tipo2[] RendimentoExclusivo_Tipo2 { get; set; }
        public R89_RendimentoExclusivo_Tipo3[] RendimentoExclusivo_Tipo3 { get; set; }

        public R90_RelacaoDoacoes[] RelacaoDoacoes { get; set; }
        public R91_DoacoesECA[] DoacoesECA { get; set; }
        public R92_DoacoesIdoso[] DoacoesIdoso { get; set; }

        public T9_Encerramento Encerramento { get; set; }
        public HR_HeaderRecibo HeaderRecbibo { get; set; }
        public DR_ReciboEntregaDeclaracao ReciboEntregaDeclaracao { get; set; }
        public R9_TraillerRecibo TraillerRecibo { get; set; }

        public void ToFile(string file)
        {
            //using (var ms = new MemoryStream())
            using (var fs = new FileStream(file, FileMode.Create))
            {
                gravaDecStream(this, fs);
            }
        }
        protected static IEnumerable<string> toLines(DEC_Intermediate dec)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                gravaDecStream(dec, ms);
                ms.Position = 0;
                StreamReader sr = new StreamReader(ms, Encoding.UTF8);
                while (!sr.EndOfStream) yield return sr.ReadLine();
            }
        }
        private static void gravaDecStream(DEC_Intermediate dec, Stream fs)
        {
            var sw = new StreamWriter(fs);

            var fields = dec.GetType().GetProperties();
            foreach (var f in fields)
            {
                var ft = f.PropertyType;
                if (ft.IsArray)
                {
                    Array arr = (Array)f.GetValue(dec);
                    for (int i = 0; i < arr.Length; i++)
                    {
                        object o = arr.GetValue(i);
                        if (o == null) continue; // vazio
                        Serialization.Serializer.Serialize((IFixedLenLine)o, sw);
                    }
                }
                else
                {
                    object o = f.GetValue(dec);
                    if (o == null) continue; // vazio
                    Serialization.Serializer.Serialize((IFixedLenLine)o, sw);
                }
            }
        }

        public string GerarNomeArquivoDEC(bool ehBackup)
        {
            return Header.GerarNomeArquivo(ehBackup);
        }
        /// <summary>
        /// Cria um arquivo DEC vazio para testes da biblioteca
        /// </summary>
        public static DEC_Intermediate makeEmpty()
        {
            return new DEC_Intermediate();
        }
        public static DEC_Intermediate FromFile(string file)
        {
            DEC_Intermediate dec = new DEC_Intermediate();
            if (!ValidaNomeArquivo(file)) throw new InvalidOperationException("Arquivo inválido");

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
            var lstR28 = new List<R28_DividasOnus>();
            var lstR32 = new List<R32_RendimentosPJDependentes>();
            var lstR34 = new List<R34_DoacoesPartidos>();
            var lstR35 = new List<R35_Alimentandos>();
            var lstR42 = new List<R42_RendaVar_FII>();
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
                    case "28":
                        lstR28.Add(carregarRegistro<R28_DividasOnus>(linha));
                        continue;
                    case "30":
                        dec.Inventariante = carregarRegistro<R30_EspolioInventariante>(linha);
                        continue;
                    case "32":
                        lstR32.Add(carregarRegistro<R32_RendimentosPJDependentes>(linha));
                        continue;
                    case "34":
                        lstR34.Add(carregarRegistro<R34_DoacoesPartidos>(linha));
                        continue;
                    case "35":
                        lstR35.Add(carregarRegistro<R35_Alimentandos>(linha));
                        continue;
                    case "42":
                        lstR42.Add(carregarRegistro<R42_RendaVar_FII>(linha));
                        continue;
                    case "43":
                        dec.RendaVarTotais_FII = carregarRegistro<R43_RendaVar_Totais_FII>(linha);
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

                    case "HR":
                        dec.HeaderRecbibo = carregarRegistro<HR_HeaderRecibo>(linha);
                        continue;
                    case "DR":
                        dec.ReciboEntregaDeclaracao = carregarRegistro<DR_ReciboEntregaDeclaracao>(linha);
                        continue;
                    case "R9":
                        dec.TraillerRecibo = carregarRegistro<R9_TraillerRecibo>(linha);
                        continue;

                    default:
                        throw new NotImplementedException(linha.Substring(0, 2)); // Notifica que ainda não terminei
                }
            }
            dec.RendimentosPJ = lstR21.ToArray();
            dec.RendimentosPfExteriorLeao = lstR22.ToArray();
            dec.RendimentosIsentosNaoTributaveis = lstR23.ToArray();
            dec.RendimentosTributacaoExclusiva = lstR24.ToArray();
            dec.Dependentes = lstR25.ToArray();
            dec.RelacaoPagamentosEfetuados = lstR26.ToArray();
            dec.BensDireitos = lstR27.ToArray();
            dec.DividasOnus = lstR28.ToArray();
            dec.RendimentosPJDependentes = lstR32.ToArray();
            dec.DoacoesPartidos = lstR34.ToArray();
            dec.Alimentandos = lstR35.ToArray();
            dec.RendaVar_FII = lstR42.ToArray();
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

        public static string CalculaHashObjeto(IFixedLenLine Item)
        {
            using (var ms = new MemoryStream())
            {
                var sw = new StreamWriter(ms);
                Serializer.Serialize(Item, sw);
                string line = System.Text.Encoding.Default.GetString(ms.ToArray());

                return Helpers.Hash.obterCrc32Utf8(line.Substring(0, line.Length - 10 - 2)); // tira o \r\n
            }
        }
        public static bool VerificaHashObjeto(IFixedLenLine Item)
        {
            using (var ms = new MemoryStream())
            {
                var sw = new StreamWriter(ms);
                Serializer.Serialize(Item, sw);
                string line = System.Text.Encoding.Default.GetString(ms.ToArray());

                return Helpers.Hash.Valida_NRControle(line.Substring(0, line.Length - 2),    // tira o \r\n
                                                      line.Substring(line.Length - 12, 10)); // tira o \r\n
            }
        }

        public static string GravarArquivoDecBackup(DEC_Intermediate dadosDec, string FilePath)
        {
            // Pega nome do Arquivo, são os 8 primeiros caracteres, Concatenar direto o CPF ?
            string nomeArqOr = dadosDec.GerarNomeArquivoDEC(true).ToUpper();
            string nomeArquivo = nomeArqOr;
            var partesNome = nomeArquivo.Split('.');
            nomeArquivo = partesNome[0].Substring(0, 8) + "." + partesNome[1];
            // Apaga o NR_HASH e NR_CONTROLE
            dadosDec.zerarHeader();
            string[] linhasArrumadas = arrumaControleLinhas(toLines(dadosDec), false).ToArray(); // false => SEM IR

            string fileHash = Helpers.Hash.obterCrc32Utf8(string.Join(string.Empty, linhasArrumadas));
            // Dados esperados para o 22222222303-IRPF-A-2020-2019-ORIGI.DBK do commit df31f61
            // IR HASH: 0021677088
            // IR NR_C: 4183433249
            dadosDec.Header.NR_Hash = fileHash;

            // Pega novamente as linhas porém contendo o Header
            linhasArrumadas = arrumaControleLinhas(toLines(dadosDec), true, nomeArquivo).ToArray(); // true => COM IR

            string nomeFinal = FilePath + "\\" + nomeArqOr;
            File.WriteAllLines(nomeFinal, linhasArrumadas);

            return nomeFinal;
        }
        private void zerarHeader()
        {
            Header.NR_Hash = new string('0', 10);
            Header.NR_Controle = new string('0', 10);
        }
        private static IEnumerable<string> arrumaControleLinhas(IEnumerable<string> linhas, bool CalculaIR, string NomeArquivoRegIR = null)
        {
            if (CalculaIR && NomeArquivoRegIR == null) throw new ArgumentNullException("NomeArquivoRegIR");
            foreach (var l in linhas)
            {
                if (l.StartsWith("IR"))
                {
                    if (CalculaIR && NomeArquivoRegIR != null)
                    {
                        var lineToCheck = l.Substring(0, l.Length - 10); // descarta os 10 zeros no final
                        var linha = lineToCheck + Helpers.Hash.obterCrc32Utf8(NomeArquivoRegIR + lineToCheck);

                        yield return linha;
                    }
                    continue;
                }
                if (l.StartsWith("HR")) continue;
                if (l.StartsWith("DR")) continue;
                if (l.StartsWith("R9")) continue;
                yield return Helpers.Hash.Arruma_NRControle(l);
            }
        }
        public static void GravarArquivoDecEntrega(DEC_Intermediate dadosDec, string FilePath)
        {
            throw new NotImplementedException();
        }

        public static bool ValidaNomeArquivo(string FileName)
        {
            if (string.IsNullOrEmpty(FileName)) throw new ArgumentException("Path inválido");

            var fi = new FileInfo(FileName);
            if (!fi.Exists) throw new FileNotFoundException();

            // precisa checar o nome do arquivo pra ver se está correto

            // Exemplo de Nome:
            string[] extensoesValidas = { ".DEC", ".DBK", ".BKP" };
            if (!extensoesValidas.Contains(fi.Extension.ToUpper())) throw new InvalidOperationException("Extensão inválida para o arquivo");

            // 11111111030-IRPF-A-2020-2019-ORIGI.DBK
            // 22222222303-IRPF-A-2020-2019-RETIF.REC
            if (fi.Name.Length != 38) return false;

            // 1: CPF
            string cpf = fi.Name.Substring(0, 11);
            if (!Helpers.CPF.ValidaCPF(cpf)) return false;
            // 2: IRPF (fixo ?)
            // 3: "A"  (fixo ?)
            if (fi.Name.Substring(11, 8) != "-IRPF-A-") return false;
            // 4: Exercício
            int Ex;
            if (!int.TryParse(fi.Name.Substring(19, 4), out Ex)) return false;
            // 5: Ano base
            int AB;
            if (!int.TryParse(fi.Name.Substring(24, 4), out AB)) return false;

            if (AB != Ex - 1) return false;

            // Se é retificadora ou é a original
            string tipo = fi.Name.Substring(29, 5);

            // Cuidado, agora retorna TRUE
            if (tipo == "ORIGI") return true;
            if (tipo == "RETIF") return true;
            return false;
        }
    }
}