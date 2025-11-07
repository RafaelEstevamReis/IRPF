namespace IRPF.Lib.Serialization;

using System;

public class SerializableValue
{
    public object Object { get; set; }
    public string Name { get; set; }
    public int Index { get; set; }
    public TipoRegistro Tipo { get; set; }
    public int Length { get; set; }
    public int Decimals { get; set; }
    public Type Type { get; set; }
    public TFormatter Formatter { get; set; }

    public override string ToString()
    {
        if (Tipo == TipoRegistro.Skip) return Name + " [SKIP]";
        return string.Format("{0} [{2}] {1}", Name, Object == null ? "[NULL]" : Object.ToString(), Tipo.ToString());
    }
}
