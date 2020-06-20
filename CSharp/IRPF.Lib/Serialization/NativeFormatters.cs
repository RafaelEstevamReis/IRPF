using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Serialization
{
    public class SkipFormatter : Formatter
    {
        override public string Serialize(SerializableValue Value)
        {
            throw new InvalidOperationException("Cannot serialize a property marked with SkipAttribute ");
        }
        override public bool Deserialize(string Line, int Offset, SerializableValue Value)
        {
            return true;
        }
    }
    public class BooleanFormatter : Formatter
    {
        override public string Serialize(SerializableValue Value)
        {
            if ((bool)Value.Object) return "1";
            return "0";
        }
        override public bool Deserialize(string Line, int Offset, SerializableValue Value)
        {
            string part = Line.Substring(Offset, Value.Length);
            Value.Object = (part == "1");
            return true;
        }
    }
    public class StringFormatter : Formatter
    {
        override public string Serialize(SerializableValue Value)
        {
            string sVal = Value.Object as string;

            if (string.IsNullOrEmpty(sVal)) return new string(' ', Value.Length);

            // Igual, ele mesmo
            if (sVal.Length == Value.Length) return sVal;
            // maior: trunca
            if (sVal.Length > Value.Length) return sVal.Substring(0, Value.Length);
            // menor, completa
            return sVal.PadRight(Value.Length);
        }
        override public bool Deserialize(string Line, int Offset, SerializableValue Value)
        {
            string part = Line.Substring(Offset, Value.Length);
            Value.Object = part.TrimEnd();
            return true;
        }
    }
    public class IntFormatter : Formatter
    {
        override public string Serialize(SerializableValue Value)
        {
            var iVal = Convert.ToInt32(Value.Object);

            var sVal = iVal.ToString(new string('0', Value.Length));
            if (sVal.Length > Value.Length) throw new InvalidOperationException();
            return sVal;
        }
        override public bool Deserialize(string Line, int Offset, SerializableValue Value)
        {
            string part = Line.Substring(Offset, Value.Length);
            Value.Object = Convert.ToInt32(part);
            return true;
        }
    }
    public class DecimalFormatter : Formatter
    {
        override public string Serialize(SerializableValue Value)
        {
            var dVal = Convert.ToDecimal(Value.Object);

            int inteiros = Value.Length - Value.Decimals;
            if (dVal < 0) inteiros--;
            string mascara = new string('0', inteiros) + "." + new string('0', Value.Decimals);

            var sVal = dVal.ToString(mascara, System.Globalization.CultureInfo.InvariantCulture).Replace(".", "");
            if (sVal.Length > Value.Length) throw new InvalidOperationException();

            return sVal;
        }
        override public bool Deserialize(string Line, int Offset, SerializableValue Value)
        {
            string part = Line.Substring(Offset, Value.Length);
            decimal dVal = Convert.ToDecimal(part);

            int Div = (int)Math.Pow(10, Value.Decimals);
            Value.Object = dVal / Div;

            return true;
        }
    }
    public class EnumOfIntFormatter : Formatter
    {
        override public string Serialize(SerializableValue Value)
        {
            var iVal = Convert.ToInt32(Value.Object);
            if (iVal == -1) return " ";

            var sVal = iVal.ToString(new string('0', Value.Length));
            if (sVal.Length > Value.Length) throw new InvalidOperationException();
            return sVal;
        }
        override public bool Deserialize(string Line, int Offset, SerializableValue Value)
        {
            string part = Line.Substring(Offset, Value.Length);
            int iVal;
            if (!Int32.TryParse(part, out iVal))
            {
                iVal = -1;
            }
            Value.Object = iVal; //Value.Type.
            return true;
        }
    }
}
