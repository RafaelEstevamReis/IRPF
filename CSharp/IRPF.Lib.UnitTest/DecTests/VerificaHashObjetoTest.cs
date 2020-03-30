using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IRPF.Lib.Files;
using System.IO;

namespace IRPF.Lib.UnitTest.DecTests
{
    [TestClass]
    public class VerificaHashObjetoTest
    {
        [TestMethod]
        public void DEC_VerificaHashObjetoTest()
        {
            string file = "Exemplo\\11111111030-IRPF-A-2020-2019-ORIGI.DBK";
            if (!File.Exists(file)) Assert.Inconclusive();

            var originalLines = File.ReadAllLines(file);
            var dec = IRPF.Lib.Files.DEC_Intermediate.FromFile(file);

            Assert.IsTrue(DEC_Intermediate.VerificaHashObjeto(dec.Declarante));

            var hash = DEC_Intermediate.CalculaHashObjeto(dec.Declarante);
            Assert.AreEqual(dec.Declarante.NR_Controle, hash);
        }
    }
}
