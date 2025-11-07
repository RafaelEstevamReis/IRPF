namespace IRPF.Lib.Serialization;

using System;
using System.Collections.Generic;

public class SerializationResult
{
    public SerializationResult()
    {
        Errors = new List<Exception>();
    }

    public List<Exception> Errors { get; private set; }
}