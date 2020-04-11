using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IRPF.Lib.Serialization
{
    public static class Serializer
    {
        public static SerializableValue[] ReadObject(this IFixedLenLine Object)
        {
            var myType = Object.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
            var dicProps = new Dictionary<int, SerializableValue>();

            foreach (var prop in props)
            {
                if (prop.GetCustomAttributes(typeof(IgnoreAttribute), true).Any()) continue;

                TipoRegistro tipo = TipoRegistro.Skip;

                var len = checkProperty<LengthAttribute>(myType, prop);
                tipo = checkProperty<TypeAttribute>(myType, prop).Tipo;
                var index = checkProperty<IndexAttribute>(myType, prop);

                if (dicProps.ContainsKey(index.Index))
                {
                    throw new InvalidOperationException("IndexAttribute can not be duplicate " + myType.Name + "." + prop.Name + ", Index:" + index.Index);
                }
                object propVal = prop.GetValue(Object);
                var formatter = Formatter.GetNativeFormatter(tipo, prop.PropertyType, propVal);
                if (formatter == null) throw new InvalidOperationException("None Formatter matched " + myType.Name + "." + prop.Name + ", Index:" + index.Index);
                dicProps.Add(index.Index, new SerializableValue()
                {
                    Name = prop.Name,
                    Index = index.Index,
                    Length = len.Length,
                    Decimals = len.Decimals,
                    Tipo = tipo,
                    Object = propVal,
                    Type = prop.PropertyType,
                    Formatter = formatter,
                });
            }

            return dicProps.OrderBy(x => x.Key).Select(x => x.Value).ToArray();
        }

        public static void Serialize(this IFixedLenLine Object, StreamWriter stream)
        {
            var data = ReadObject(Object);
            foreach (var val in data)
            {
                string value = val.Formatter.Serialize(val);
                if (value.Length != val.Length) throw new InvalidOperationException("Serialized Length mismatch");
                stream.Write(value);
            }
            stream.WriteLine();
            stream.Flush();
        }
        public static SerializationResult Deserialize(this IFixedLenLine Object, StreamReader stream)
        {
            var line = stream.ReadLine();
            return Deserialize(Object, line);
        }
        public static SerializationResult Deserialize(this IFixedLenLine Object, string line)
        {
            var serResult = new SerializationResult();
            var data = ReadObject(Object);

            for (int idx = data.Min(o => o.Index); idx <= data.Max(o => o.Index); idx++)
            {
                if (!data.Select(o => o.Index).Contains(idx))
                {
                    //throw new InvalidOperationException("Index " + idx + " is missing");
                }
            }

            int offset = 0;
            foreach (var val in data)
            {
                try
                {
                    if (val.Formatter.Deserialize(line, offset, val))
                    {
                        Object.GetType().GetProperty(val.Name).SetValue(Object, val.Object);
                    }
                    else
                    {
                        serResult.Errors.Add(new Exception("Failed to deserialize field " + val.Name));
                    }
                }
                catch (Exception ex)
                {
                    serResult.Errors.Add(new Exception("Error serializing field " + val.Name, ex));
                }
                offset += val.Length;
            }
            return serResult;
        }

        private static T checkProperty<T>(Type myType, PropertyInfo prop)
        {
            var p = prop.GetCustomAttributes(typeof(T), true).Cast<T>().FirstOrDefault();
            if (p == null)
            {
                throw new InvalidOperationException("Public property must be marked with " + typeof(T).Name + " or IgnoreAttribute. " + myType.Name + "." + prop.Name);
            }
            return p;
        }

        public static void SerializeXml<T>(T Object, string filename)
        {
            // https://docs.microsoft.com/pt-br/dotnet/standard/serialization/examples-of-xml-serialization
            XmlSerializer x = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StreamWriter(filename))
            {
                x.Serialize(writer, Object);
            }
        }
        public static T DeserializeXmlFile<T>(string filename)
        {
            // https://docs.microsoft.com/pt-br/dotnet/api/system.xml.serialization.xmlserializer.deserialize?view=netframework-4.8
            // Create an instance of the XmlSerializer.
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            // Declare an object variable of the type to be deserialized.
            T i;

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                i = (T)serializer.Deserialize(reader);
            }
            return i;
        }
    }
}