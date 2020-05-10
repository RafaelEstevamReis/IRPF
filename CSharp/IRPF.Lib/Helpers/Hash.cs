using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Helpers
{
    public class Hash
    {
        public static string obterMd5Utf8(string Texto)
        {
            // https://docs.microsoft.com/pt-br/dotnet/api/system.security.cryptography.md5?view=netframework-4.8
            using (var md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(Texto));
                // Create a new Stringbuilder to collect the bytes
                // and create a string.
            
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }
        public static string obterCrc32Utf8(string Texto)
        {
            // https://rosettacode.org/wiki/CRC-32#C.23
            //Crc32 crc = new Crc32();
            var val = Crc32.Get(Encoding.UTF8.GetBytes(Texto));
            return val.ToString("0000000000");
        }

        public static string obterCrc32Utf8Linhas(string[] Linhas)
        {
            return obterCrc32Utf8(string.Join(string.Empty, Linhas));
        }

        public static bool Valida_NRControle(string LinhaCompleta, string NR_Controle)
        {
            var lineToCheck = LinhaCompleta.Substring(0, LinhaCompleta.Length - 10); // descarta os 10 zeros no final
            var calculado = obterCrc32Utf8(lineToCheck);
            return calculado == NR_Controle;
        }
        public static string Arruma_NRControle(string LinhaCompleta)
        {
            var lineToCheck = LinhaCompleta.Substring(0, LinhaCompleta.Length - 10); // descarta os 10 zeros no final
            return lineToCheck + obterCrc32Utf8(lineToCheck);
        }
    }
}
