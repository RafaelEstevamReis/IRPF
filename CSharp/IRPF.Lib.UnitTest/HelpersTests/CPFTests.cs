using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IRPF.Lib.UnitTest.HelpersTests
{
    [TestClass]
    public class CPFTests
    {
        [TestMethod]
        public void Helpers_CPF_Valida_CPF()
        {
            // Valida CPFs da documentação
            Assert.IsTrue(Helpers.CPF.ValidaCPF("111.111.110-30"));
            Assert.IsTrue(Helpers.CPF.ValidaCPF("222.222.223-03"));
            Assert.IsTrue(Helpers.CPF.ValidaCPF("333.333.334-14"));
            Assert.IsTrue(Helpers.CPF.ValidaCPF("444.444.445-25"));
            Assert.IsTrue(Helpers.CPF.ValidaCPF("555.555.556-36"));
            // Randômicos do 4Devs
            Assert.IsTrue(Helpers.CPF.ValidaCPF("557.253.420-00"));
            Assert.IsTrue(Helpers.CPF.ValidaCPF("048.206.360-22"));
            Assert.IsTrue(Helpers.CPF.ValidaCPF("720.798.750-19"));
            Assert.IsTrue(Helpers.CPF.ValidaCPF("997.147.020-97"));
        }
    }
}
