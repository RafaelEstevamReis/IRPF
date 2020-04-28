using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Helpers
{
    public static class CPF
    {
        public static string FormataCPF(string CPF)
        {
            throw new NotImplementedException();
        }
        public static string DesFormataCPF(string CPF)
        {
            throw new NotImplementedException();
        }

        public static bool ValidaCPF(string CPF)
        {
            if (CPF.Contains("-")) CPF = CPF.Replace("-", "");
            if (CPF.Contains(".")) CPF = CPF.Replace(".", "");

            if (string.IsNullOrEmpty(CPF)) return false;
            if (CPF.Length != 11) return false;

            string cpfParte1 = CPF.Substring(0, 9);
            char dv1 = CPF[9];

            if (calculaParteCpf(cpfParte1) != dv1) return false;
            
            string cpfParte2 = CPF.Substring(0, 10);
            char dv2 = CPF[10];

            return calculaParteCpf(cpfParte2) == dv2;
        }
        public static char calculaParteCpf(string str)
        {
            int soma = 0;
            int peso = str.Length + 1;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (!char.IsDigit(c)) throw new ArgumentException("Invalid char");

                soma += (c - '0') * (peso--);
            }
            int mod = soma % 11;
            if (mod < 2) return '0';
            return (11 - mod).ToString()[0];
        }
    }
}
