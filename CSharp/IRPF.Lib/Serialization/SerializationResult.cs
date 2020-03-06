using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRPF.Lib.Serialization
{
    public class SerializationResult
    {
        public SerializationResult()
        {
            Errors = new List<Exception>();
        }

        public List<Exception> Errors { get; private set; }
    }
}