namespace IRPF.Lib.Helpers;

using System.Collections.Generic;

public static class Extensoes
{
    public static T Get<T>(this Dictionary<string, T> dic, string Key, T Default)
    {
        if (dic.ContainsKey(Key)) return dic[Key];
        return Default;
    }
    public static T Get<T, K>(this Dictionary<K, T> dic, K Key, T Default)
    {
        if (dic.ContainsKey(Key)) return dic[Key];
        return Default;
    }
}
