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
    }
}
