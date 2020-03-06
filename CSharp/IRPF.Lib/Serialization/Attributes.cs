using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Serialization
{
    public enum TipoRegistro
    {
        N,
        C,
        Skip = -1,
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
    public class FixedLenAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class IndexAttribute : Attribute
    {
        public int Index { get; private set; }

        public IndexAttribute(int index)
        {
            this.Index = index;
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class LengthAttribute : Attribute
    {
        public int Length { get; private set; }
        public int Decimals { get; private set; }

        public LengthAttribute(int length)
            : this(length, 0)
        { }
        public LengthAttribute(int length, int Decimals)
        {
            this.Length = length;
            this.Decimals = Decimals;
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class TypeAttribute : Attribute
    {
        public TipoRegistro Tipo { get; private set; }

        public TypeAttribute(TipoRegistro tipo)
        {
            this.Tipo = tipo;
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class IgnoreAttribute : Attribute
    {
    }
}
