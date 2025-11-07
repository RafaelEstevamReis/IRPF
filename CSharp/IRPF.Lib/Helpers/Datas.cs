namespace IRPF.Lib.Helpers;

using System;

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
