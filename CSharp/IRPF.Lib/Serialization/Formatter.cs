using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Serialization
{
    public interface TFormatter
    {
        string Serialize(SerializableValue Value);
        bool Deserialize(string Line, int Offset, SerializableValue Value);
    }
    public abstract class Formatter : TFormatter
    {
        public static Formatter GetNativeFormatter(TipoRegistro TipoDados, Type type, object value)
        {
            if (TipoDados == TipoRegistro.Skip) return new SkipFormatter();
            if (TipoDados == TipoRegistro.C && type == typeof(string)) return new StringFormatter();

            if (TipoDados == TipoRegistro.C && type == typeof(int)) return new IntFormatter();
            if (TipoDados == TipoRegistro.N && type == typeof(int)) return new IntFormatter();

            if (TipoDados == TipoRegistro.N && type == typeof(decimal)) return new DecimalFormatter();

            if (TipoDados == TipoRegistro.N && type == typeof(bool)) return new BooleanFormatter();

            if (type.IsEnum)
            {
                if (TipoDados == TipoRegistro.N) // int
                {
                    return new EnumOfIntFormatter();
                }

            }


            if (TipoDados == TipoRegistro.C && type == typeof(object)) return new StringFormatter();
            
            //throw new NotImplementedException();
            return new StringFormatter();
        }

        public abstract string Serialize(SerializableValue Value);
        public abstract bool Deserialize(string Line, int Offset, SerializableValue Value);
    }
}
