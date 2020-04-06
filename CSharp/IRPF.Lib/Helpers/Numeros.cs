using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Helpers
{
    public static class Numeros
    {
        /// <summary>
        /// Tenta converter um número para inteiro, se falhar, retorna o parâmetro Erro
        /// </summary>
        /// <param name="Valor">Valor a ser convertido</param>
        /// <param name="Erro">Valor a ser retornado em caso de falha</param>
        /// <returns>Retorno do valor convertido ou do campo Erro</returns>
        public static int Inteiro(string Valor, int Erro = 0)
        {
            if (Valor == null) return Erro;
            if (Valor == "") return Erro;

            var val = Erro;
            if (int.TryParse(Valor, out val)) return val;
            
            return Erro;
        }
        /// <summary>
        /// Tenta converter um número para Decimal, se falhar, retorna o parâmetro Erro
        /// </summary>
        /// <param name="Valor">Valor a ser convertido</param>
        /// <param name="Erro">Valor a ser retornado em caso de falha</param>
        /// <returns>Retorno do valor convertido ou do campo Erro</returns>
        public static decimal Decimal(string Valor, decimal Erro = 0)
        {
            if (Valor == null) return Erro;
            if (Valor == "") return Erro;

            var val = Erro;
            if (decimal.TryParse(Valor, out val)) return val;

            return Erro;
        }
    }
}
