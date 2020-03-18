using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IRPF.Lib.Helpers;

namespace IRPF.Lib.UnitTest.HelpersTests
{
    [TestClass]
    public class HashTests
    {
        [TestMethod]
        public void Helpers_HashCrc32_Registro16()
        {
            // registro "R16" gerado na declaração de 2020 com dados randômicos
            string r16 = "1611111111030TESTE ASDA ADSA                                             AEROPORTO      LOGRADOURO AAAAAAAAABBBBBBBBB           NUM0  COMPLEMENTO          BAIRRO             88045108 9939ABDON BATISTA                           SC   105EMAIL@EMAIL.COM                                                                                                 11                                101911S SN            0000000N0               N022222222000272          A                               12222222222 111111111  0473170319";
            Assert.AreEqual("0473170319", Hash.obterCrc32Utf8(r16.Substring(0, r16.Length - 10)));
        }
        [TestMethod]
        public void Helpers_HashCrc32_Registro19()
        {
            // registro "R19" gerado na declaração de 2020 com dados randômicos
            string r19 = "1911111111030222222220002720000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000510002488175154";
            Assert.AreEqual("2488175154", Hash.obterCrc32Utf8(r19.Substring(0, r19.Length - 10)));
        }
    }
}
