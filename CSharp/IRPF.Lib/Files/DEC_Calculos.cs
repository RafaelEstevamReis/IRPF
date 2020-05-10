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
            // Totaliza tudo ...
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
            int[] itens = {03, 08, 23, 24, 25};
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

    }
}
