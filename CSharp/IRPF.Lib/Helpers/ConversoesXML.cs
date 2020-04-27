﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Helpers
{
    public class ConversoesXML
    {
        public static DateTime Datas_Set(string Valor)
        {
            if (Valor.Length == 10)
            {
                return DateTime.ParseExact(Valor, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            throw new Exception();
        }
        public static string Datas_Get(DateTime Valor)
        {
            return Valor.ToString("dd/MM/yyyy");
        }
        /// <summary>
        /// Bool Numérico, utiliza '1' como TRUE e resto como FALSO
        /// </summary>
        public static bool BoolN_Set(string Valor)
        {
            if (Valor == "S") throw new Exception("Possível inversão de chamada");
            if (Valor == "N") throw new Exception("Possível inversão de chamada");
            return Valor == "1";
        }
        /// <summary>
        /// Bool Numérico, utiliza '1' e '0'
        /// </summary>
        public static string BoolN_Get(bool Valor)
        {
            return Valor ? "1" : "0";
        }
        /// <summary>
        /// Bool Textual, utiliza 'S' como TRUE e resto como FALSO
        /// </summary>
        public static bool BoolT_Set(string Valor)
        {
            if (Valor == "1") throw new Exception("Possível inversão de chamada");
            if (Valor == "0") throw new Exception("Possível inversão de chamada");
            return Valor == "S";
        }
        /// <summary>
        /// Bool Textual, utiliza 'S' e 'N'
        /// </summary>
        public static string BoolT_Get(bool Valor)
        {
            return Valor ? "S" : "N";
        }
    }
}