using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IRPF.Lib.UnitTest.ClassesTests.IR_Tests
{
    [TestClass]
    public class NomeArquivo
    {
        [TestMethod]
        public void ClassesIR_NomeArquivo_ExemploCPF111()
        {
            string nomeGerado = "11111111030-IRPF-A-2020-2019-ORIGI.DBK";

            Files.DEC_Intermediate dec = Files.DEC_Intermediate.makeEmpty();
            dec.Header = new Classes_DEC.IR_RegistroHeader();
            dec.Header.CPF_Contribuinte = "11111111030";
            dec.Header.Exercicio = 2020;
            dec.Header.AnoBase = 2019;
            dec.Header.IN_Retificadora = " ";

            Assert.AreEqual(nomeGerado, dec.GerarNomeArquivoDEC(true));
        }
    }
}