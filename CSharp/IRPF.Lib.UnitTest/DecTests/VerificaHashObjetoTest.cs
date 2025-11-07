namespace IRPF.Lib.UnitTest.DecTests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using IRPF.Lib.Files;
using System.IO;

[TestClass]
public class VerificaHashObjetoTest
{
    [TestMethod]
    public void DEC_VerificaHashObjetoTest()
    {
        string file = "Exemplo\\11111111030-IRPF-A-2020-2019-ORIGI.DBK";
        if (!File.Exists(file)) Assert.Inconclusive();

        var originalLines = File.ReadAllLines(file);
        var dec = IRPF.Lib.Files.DEC2025_Intermediate.FromFile(file);

        Assert.IsTrue(DEC2025_Intermediate.VerificaHashObjeto(dec.Declarante));

        var hash = DEC2025_Intermediate.CalculaHashObjeto(dec.Declarante);
        Assert.AreEqual(dec.Declarante.NR_Controle, hash);
    }
}
