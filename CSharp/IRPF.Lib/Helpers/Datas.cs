using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Helpers
{
    public static class Datas
    {
        public static DateTime Parse(string Data)
        {
            if (Data.Length == 8)
            {
                return DateTime.ParseExact(Data, "ddMMyyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            throw new Exception();
        }
    }
}
