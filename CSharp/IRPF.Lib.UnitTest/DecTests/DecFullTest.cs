using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace IRPF.Lib.UnitTest.DecTests
{
    [TestClass]
    public class DecFullTest
    {
        [TestMethod]
        public void DEC_EndToEndLoadTest_Completa()
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
                Assert.AreEqual(originalLines[i].Length, newLines[i].Length);
                Assert.AreEqual(originalLines[i], newLines[i]);
            }
        }
        [TestMethod]
        public void DEC_EndToEndLoadTest_Simplificada()
        {
            string file = "Exemplo\\22222222303-IRPF-A-2020-2019-ORIGI.DEC";
            if (!File.Exists(file)) Assert.Inconclusive();

            var originalLines = File.ReadAllLines(file);
            var dec = IRPF.Lib.Files.DEC_Intermediate.FromFile(file);

            dec.ToFile("test.tmp");
            var newLines = File.ReadAllLines("test.tmp");

            Assert.AreEqual(originalLines.Length, newLines.Length);
            for (int i = 0; i < originalLines.Length; i++)
            {
                Assert.AreEqual(originalLines[i].Length, newLines[i].Length);
                Assert.AreEqual(originalLines[i], newLines[i]);
            }
        }
    }
}
