using IRPF.Lib.Serialization;
using IRPF.Lib.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Files
{
    partial class DEC_Intermediate
    {
        public void TotalizaDeclaracao()
        {
            // Totaliza tudo ... (header por último)            
            r23_TotalizaISentos();
            r24_TotalizaTributacaoExclusiva();

            r17_DemaisRendimentosEImpostoPago();
            // O Header está no final pois utiliza valores totalizados em outros campos
            ir_TotalizaHeader();
            // Contadores de encerrametnos
            t9_TotalizaEncerramento();
        }

        private void r17_DemaisRendimentosEImpostoPago()
        {
            // Esta guia não é validada,
            //  o software do IRPF vai carregar a declaração e recalcular tudo            
        }

        private void ir_TotalizaHeader()
        {
            // Ainda não está completo

            #region Fontes Pagadoras
            // Busca
            var fontes = new List<Tuple<string, decimal>>();
            if (RendimentosPJ != null)
            {
                fontes.AddRange(RendimentosPJ
                    .Select(r => new Tuple<string, decimal>(r.NR_Pagador, r.VR_Rendto)));
            }
            if (RendimentosPJDependentes != null)
            {
                fontes.AddRange(RendimentosPJDependentes
                    .Select(r => new Tuple<string, decimal>(r.NR_Pagador, r.VR_Rendto)));
            }
            // Agrega e Ordena
            fontes = fontes
                .GroupBy(g => g.Item1)
                .Select(r => new Tuple<string, decimal>(r.Key, r.Sum(o => o.Item2)))
                .OrderByDescending(i => i.Item2)
                .ToList();
            // Seta campos
            Header.NR_BaseFonteMaior = fontes.Count > 0 ? fontes[0].Item1 : "";
            Header.NR_BaseFonteDois = fontes.Count > 1 ? fontes[1].Item1 : "";
            Header.NR_BaseFonteTres = fontes.Count > 2 ? fontes[2].Item1 : "";
            Header.NR_BaseFonteQuatro = fontes.Count > 3 ? fontes[3].Item1 : "";
            #endregion

            #region Dependentes
            // Zera
            Tuple<string, string>[] rankingRendimentos = new Tuple<string, string>[0];

            if (Dependentes != null && Dependentes.Length > 0)
            {
                var dicDependentes = Dependentes
                    .Select(d => new
                    {
                        cpf = d.NI_Depend,
                        nasc = d.DT_Nascim
                    })
                    .ToDictionary(k => k.cpf, e => e.nasc);

                rankingRendimentos = RendimentosPJDependentes
                    .Select(o => new Tuple<string, decimal>(o.Cpf_Benef, o.VR_Rendto))
                    .OrderByDescending(o => o.Item2)
                    .Select(d => new Tuple<string, string>(d.Item1,
                                                           dicDependentes.Get(d.Item1, "")))
                    .ToArray();
            }
            Header.NR_CPFDepeRendMaior = leTupla(rankingRendimentos, 0).Item1;
            Header.DT_NasDepeRendMaior = leTupla(rankingRendimentos, 0).Item2;

            Header.NR_CPFDepeRendDois = leTupla(rankingRendimentos, 1).Item1;
            Header.DT_NasDepeRendDois = leTupla(rankingRendimentos, 1).Item2;

            Header.NR_CPFDepeRendTres = leTupla(rankingRendimentos, 2).Item1;
            Header.DT_NasDepeRendTres = leTupla(rankingRendimentos, 2).Item2;

            Header.NR_CPFDepeRendQuatro = leTupla(rankingRendimentos, 3).Item1;
            Header.DT_NasDepeRendQuatro = leTupla(rankingRendimentos, 3).Item2;

            Header.NR_CPFDepeRendCinco = leTupla(rankingRendimentos, 4).Item1;
            Header.DT_NasDepeRendCinco = leTupla(rankingRendimentos, 4).Item2;

            Header.NR_CPFDepeRendSeis = leTupla(rankingRendimentos, 5).Item1;
            Header.DT_NasDepeRendSeis = leTupla(rankingRendimentos, 5).Item2;
            #endregion

            #region VR_TotalPagamentos e Depsesas médicas
            Header.NR_BaseBenefDespMedMaior =
                 Header.NR_BaseBenefDespMedDois = "";
            Header.VR_TotalPagamentos = 0;

            if (RelacaoPagamentosEfetuados != null)
            {
                Header.VR_TotalPagamentos = RelacaoPagamentosEfetuados.Sum(o => o.VR_Pagto);

                var pagMed = RelacaoPagamentosEfetuados
                    .Where(r => r.ehDespesaMedica())
                    .Where(r => r.VR_Pagto >= r.VR_Reduc)
                    .GroupBy(g => g.NR_Benef)
                    .Select(g => new Tuple<string, decimal>(
                                    g.Key, g.Sum(o => o.VR_Pagto - o.VR_Reduc)))
                    .OrderByDescending(o => o.Item2)
                    .ToArray();

                if (pagMed.Length > 0) Header.NR_BaseBenefDespMedMaior = pagMed[0].Item1;
                if (pagMed.Length > 1) Header.NR_BaseBenefDespMedDois = pagMed[1].Item1;
            }
            #endregion

            if (RendimentosIsentosNaoTributaveis != null)
            {
                Header.VR_TotalIsentos = RendimentosIsentosNaoTributaveis.Sum(o => o.VR_Valor);
            }

            //Header.IN_EntregaObrigatoria = EhEntregaObrigatoria(); // TODO Implementar
            Header.IN_EntregaObrigatoria = Header.IN_EntregaObrigatoria;

            if (Header.ehCompleta())
            {
                Header.VR_ImpDevido = TotaisDeclaracao.VR_ImpDev;
            }
            else
            {
                Header.VR_ImpDevido = TotaisDeclaracaoSimplificada.VR_ImpDevido;
            }


        }

        private Tuple<string, string> leTupla(Tuple<string, string>[] items, int index)
        {
            if (items.Length <= index) return new Tuple<string, string>(string.Empty, string.Empty);
            return items[index];
        }

        private void r23_TotalizaISentos()
        {
            var lst = new List<Classes_DEC.R23_RendimentosIsentosNaoTributaveis>();

            // gera novos R23
            #region dos registros 83 até 87
            foreach (var r83 in RendimentosIsentos_Tipo2)
            {
                lst.Add(new Classes_DEC.R23_RendimentosIsentosNaoTributaveis(Header)
                {
                    CD_Isento = r83.NR_COD, // 19, 20 e 21
                    VR_Valor = r83.VR_Valor
                });
            }
            foreach (var r84 in RendimentosIsentos_Tipo3)
            {
                lst.Add(new Classes_DEC.R23_RendimentosIsentosNaoTributaveis(Header)
                {
                    CD_Isento = r84.NR_Cod, // 1, 2, 4, 9, 10, 12, 13, 14, 16, 17 e 18
                    VR_Valor = r84.VR_Valor
                });
            }
            foreach (var r85 in RendimentosIsentos_Tipo4) // TODO FIXME: Não verificado
            {
                lst.Add(new Classes_DEC.R23_RendimentosIsentosNaoTributaveis(Header)
                {
                    CD_Isento = r85.NR_Cod, // Apenas 11
                    VR_Valor = r85.VR_Receb + r85.VR_IRRF13Salario, // TODO FIXME: Não verificado
                });
            }
            foreach (var r86 in RendimentosIsentos_Tipo5)
            {
                lst.Add(new Classes_DEC.R23_RendimentosIsentosNaoTributaveis(Header)
                {
                    CD_Isento = r86.NR_Cod, // Apenas 26
                    VR_Valor = r86.VR_Valor
                });
            }
            foreach (var r87 in RendimentosIsentos_Tipo6)
            {
                lst.Add(new Classes_DEC.R23_RendimentosIsentosNaoTributaveis(Header)
                {
                    CD_Isento = r87.NR_Cod, // 5, 6 e 7
                    // Para os rendimentos 05, 06 e 07, é apresentado o somatório de VALOR + VALORGCAP.
                    VR_Valor = r87.VR_Valor + r87.VR_ValorGCap
                });
            }
            #endregion
            #region dos registros 52 e 40
            //foreach (var r40 in [40 Não implementado])
            //{
            //    lst.Add(new Classes_DEC.R23_RendimentosIsentosNaoTributaveis(Header)
            //    {
            //        CD_Isento = r40.NR_Cod,
            //        VR_Valor = r40.VR_Valor
            //    });
            //}
            //foreach (var r52 in [52 Não implementado])
            //{
            //    lst.Add(new Classes_DEC.R23_RendimentosIsentosNaoTributaveis(Header)
            //    {
            //        CD_Isento = r52.NR_Cod,
            //        VR_Valor = r52.VR_Valor
            //    });
            //}
            #endregion

            // Junta com os R23 unitários de códigos 03, 08, 23, 24 e 25
            int[] itens = { 03, 08, 23, 24, 25 };
            var unitarios = RendimentosIsentosNaoTributaveis
                .Where(r => itens.Contains(r.CD_Isento))
                .ToArray();

            var acumulados = lst
                .GroupBy(o => o.CD_Isento)
                .Select(g => new Classes_DEC.R23_RendimentosIsentosNaoTributaveis(Header)
                {
                    CD_Isento = g.Key,
                    VR_Valor = g.Sum(r => r.VR_Valor)
                });

            // grava registro
            RendimentosIsentosNaoTributaveis = unitarios
                .Union(acumulados)
                .ToArray();
        }
        private void r24_TotalizaTributacaoExclusiva()
        {
            var dicValores = new Dictionary<int, decimal>();

            // Zera todos
            //for (int i = 1; i <= 12; i++) dicValores.Add(i, 0);

            // São os campos próprios (calculados) e os 88, 89

            // 01: Décimo terceiro do Titular => R21
            if (RendimentosPJ != null)
            {
                dicValores[1] = RendimentosPJ.Sum(o => o.VR_DecTerc);
            }
            // 02: Ganhos de Capital          => 
            //--
            // 03: Ganhos de Capital Estrangeira =>
            //--
            // 04: Ganhos de Capital em espécie  =>
            //--
            // 05: Ganhos Renda Variável  => 
            if (RendimentosTributacaoExclusiva != null)
            {
                dicValores[5] = RendimentosTributacaoExclusiva
                    .Where(o => o.CD_Exclusivo == 5)
                    .Sum(o => o.VR_Valor);
            }            
            // 07: RRA
            //--
            // 08: Décimo terceiro dos Dependentes => R32
            if (RendimentosPJDependentes != null)
            {
                dicValores[8] = RendimentosPJDependentes.Sum(o => o.VR_DecTerc);
            }
            // 09: RRA Dependentes
            //--
            // 06: Rendimentos Aplicações => R88
            // 10: JCP     => R88
            // 11: RendPLR => R88
            if (RendimentoExclusivo_Tipo2 != null)
            {
                foreach (var v in RendimentoExclusivo_Tipo2)
                {
                    if (!dicValores.ContainsKey(v.NR_Cod)) dicValores.Add(v.NR_Cod, 0);
                    dicValores[v.NR_Cod] += v.VR_Valor;
                }
            }
            // 12: Outros  => R89
            if (RendimentoExclusivo_Tipo3 != null) dicValores[12] = RendimentoExclusivo_Tipo3.Sum(o => o.VR_Valor);

            RendimentosTributacaoExclusiva = dicValores
                .Where(o => o.Value > 0)
                .Select(pair => new Classes_DEC.R24_RendimentosTributacaoExclusiva(Header)
                    {
                        CD_Exclusivo = pair.Key,
                        VR_Valor = pair.Value
                    })
                .ToArray();
        }

        private void t9_TotalizaEncerramento()
        {
            //Encerramento.QT_Total - Basicamente a contagem de linhas
            Encerramento.QT_R16 = contar(Declarante);
            Encerramento.QT_R17 = contar(DemaisRendimentosEImpostoPago);
            Encerramento.QT_R18 = contar(TotaisDeclaracaoSimplificada);
            Encerramento.QT_R19 = contar(Completa);
            Encerramento.QT_R20 = contar(TotaisDeclaracao);

            Encerramento.QT_R21 = contar(RendimentosPJ);
            Encerramento.QT_R22 = contar(RendimentosPfExteriorLeao);
            Encerramento.QT_R23 = contar(RendimentosIsentosNaoTributaveis);
            Encerramento.QT_R24 = contar(RendimentosTributacaoExclusiva);
            Encerramento.QT_R25 = contar(Dependentes);
            Encerramento.QT_R26 = contar(RelacaoPagamentosEfetuados);
            Encerramento.QT_R27 = contar(BensDireitos);
            Encerramento.QT_R28 = contar(DividasOnus);
            //Encerramento.QT_R29 Não existe
            Encerramento.QT_R30 = contar(Inventariante);
            //Encerramento.QT_R31 Não existe
            Encerramento.QT_R32 = contar(RendimentosPJDependentes);
            //Encerramento.QT_R33 Não existe
            Encerramento.QT_R34 = contar(DoacoesPartidos);
            Encerramento.QT_R35 = contar(Alimentandos);
            //Encerramento.QT_R36 Não existe
            //Encerramento.QT_R37 Não existe
            Encerramento.QT_R38 = 0; // TODO: Não implementado
            Encerramento.QT_R39 = 0; // TODO: Não implementado
            Encerramento.QT_R40 = 0; // TODO: Não implementado
            Encerramento.QT_R41 = 0; // TODO: Não implementado
            Encerramento.QT_R42 = contar(RendaVar_FII);
            Encerramento.QT_R43 = contar(RendaVarTotais_FII);
            //Encerramento.QT_R44 Não existe
            Encerramento.QT_R45 = contar(RecebidosAcumuladamente);
            Encerramento.QT_R46 = 0; // TODO: Não implementado
            Encerramento.QT_R47 = contar(RendimentosAcumuladamenteDependente);
            Encerramento.QT_R48 = 0; // TODO: Não implementado
            Encerramento.QT_R49 = 0; // TODO: Não implementado
            Encerramento.QT_R50 = 0; // TODO: Não implementado
            Encerramento.QT_R51 = 0; // TODO: Não implementado
            Encerramento.QT_R52 = 0; // TODO: Não implementado
            Encerramento.QT_R53 = 0; // TODO: Não implementado
            Encerramento.QT_R54 = 0; // TODO: Não implementado
            Encerramento.QT_R55 = 0; // TODO: Não implementado
            Encerramento.QT_R56 = 0; // TODO: Não implementado
            //Encerramento.QT_R57 Não existe
            Encerramento.QT_R58 = 0; // TODO: Não implementado
            Encerramento.QT_R59 = 0; // TODO: Não implementado
            Encerramento.QT_R60 = 0; // TODO: Não implementado
            Encerramento.QT_R61 = 0; // TODO: Não implementado
            Encerramento.QT_R62 = 0; // TODO: Não implementado
            Encerramento.QT_R63 = 0; // TODO: Não implementado
            Encerramento.QT_R64 = 0; // TODO: Não implementado
            Encerramento.QT_R65 = 0; // TODO: Não implementado
            Encerramento.QT_R66 = 0; // TODO: Não implementado
            Encerramento.QT_R67 = 0; // TODO: Não implementado
            Encerramento.QT_R68 = 0; // TODO: Não implementado
            Encerramento.QT_R69 = 0; // TODO: Não implementado
            Encerramento.QT_R70 = 0; // TODO: Não implementado
            Encerramento.QT_R71 = 0; // TODO: Não implementado
            Encerramento.QT_R72 = 0; // TODO: Não implementado
            Encerramento.QT_R73 = 0; // TODO: Não implementado
            Encerramento.QT_R74 = 0; // TODO: Não implementado
            Encerramento.QT_R75 = 0; // TODO: Não implementado
            //Encerramento.QT_R76 Não existe
            //Encerramento.QT_R77 Não existe
            //Encerramento.QT_R78 Não existe
            //Encerramento.QT_R79 Não existe
            Encerramento.QT_R80 = 0; // TODO: Não implementado
            Encerramento.QT_R81 = 0; // TODO: Não implementado
            //Encerramento.QT_R82 Não existe
            Encerramento.QT_R83 = contar(RendimentosIsentos_Tipo2);
            Encerramento.QT_R84 = contar(RendimentosIsentos_Tipo3);
            Encerramento.QT_R85 = contar(RendimentosIsentos_Tipo4);
            Encerramento.QT_R86 = contar(RendimentosIsentos_Tipo5);
            Encerramento.QT_R87 = contar(RendimentosIsentos_Tipo6);
            Encerramento.QT_R88 = contar(RendimentoExclusivo_Tipo2);
            Encerramento.QT_R89 = contar(RendimentoExclusivo_Tipo3);

            Encerramento.QT_R90 = contar(RelacaoDoacoes);
            Encerramento.QT_R91 = contar(DoacoesECA);
            Encerramento.QT_R92 = contar(DoacoesIdoso);
        }

        private static int contar(Array array)
        {
            if (array == null) return 0;
            return array.Length;
        }
        private static int contar(IFixedLenLine item)
        {
            if (item == null) return 0;
            return 1;
        }

    }
}