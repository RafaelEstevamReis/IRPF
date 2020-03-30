using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace IRPF.Lib.UnitTest.DecTests
{
    [TestClass]
    public class DecFullTest
    {
        [TestMethod]
        public void DEC_EndToEndTest()
        {
            string file = "Exemplo\\11111111030-IRPF-A-2020-2019-ORIGI.DBK";
            if (!File.Exists(file)) Assert.Inconclusive();

            var originalLines = File.ReadAllLines(file);
            var dec = IRPF.Lib.Files.DEC_Intermediate.FromFile(file);

            dec.ToFile("test.tmp");
            var newLines = File.ReadAllLines("test.tmp");

            Assert.AreEqual(originalLines.Length, newLines.Length);
            for (int i = 0; i < originalLines.Length; i++)
            {
                Assert.AreEqual(originalLines[i], newLines[i]);
            }
        }
    }
}
