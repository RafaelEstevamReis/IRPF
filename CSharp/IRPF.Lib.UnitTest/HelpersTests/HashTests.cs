using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IRPF.Lib.Helpers;
using System.Text;

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
        public void Helpers_HashCrc32_Registro16_OLZEU()
        {
            // Este teste tem 1 caractere de diferença, estou aproveitando um erro de grafia corrigido no commit 269905f9da1333eb6b0b26c73d93ccefd235de80
            string r16_GrafiaErrada = "1622222222303OLZEFU BYAISNO ASRIM                                        RUA            CANTAREIRA                              306                        CENTRO HISTORICO DE01024900 7107SAO PAULO                               SP   105OLZEFU@EXEMPLE.COM                                                                                   3333333341411           01021993330132630167 111110NNSN            0010001N000001        9 N099111111000132          A                                          S911111111  2914851822";
            Assert.AreEqual("2914851822", Hash.obterCrc32Utf8(r16_GrafiaErrada.Substring(0, r16_GrafiaErrada.Length - 10)));

            string r16_GrafiaCorreta = "1622222222303OLZEFU BYAISNO ASRIM                                        RUA            CANTAREIRA                              306                        CENTRO HISTORICO DE01024900 7107SAO PAULO                               SP   105OLZEFU@EXAMPLE.COM                                                                                   3333333341411           01021993330132630167 111110NNSN            0010001N000001        9 N099111111000132          A                                          S911111111  0609000497";
            Assert.AreEqual("0609000497", Hash.obterCrc32Utf8(r16_GrafiaCorreta.Substring(0, r16_GrafiaCorreta.Length - 10)));
        }
        [TestMethod]
        public void Helpers_HashCrc32_Registro16_OLZEU_GRAFIA_CORRETA()
        {
            // registro "R16" gerado na declaração de 2020 com dados randômicos
            string r16 = "1622222222303OLZEFU BYAISNO ASRIM                                        RUA            CANTAREIRA                              306                        CENTRO HISTORICO DE01024900 7107SAO PAULO                               SP   105OLZEFU@EXAMPLE.COM                                                                                   3333333341411           01021993330132630167 111110NNSN            0010001N000001        9 N099111111000132          A                                          S911111111  0609000497";
            Assert.AreEqual("0609000497", Hash.obterCrc32Utf8(r16.Substring(0, r16.Length - 10)));
        }
        [TestMethod]
        public void Helpers_HashCrc32_Registro19()
        {
            // registro "R19" gerado na declaração de 2020 com dados randômicos
            string r19 = "1911111111030222222220002720000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001500000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000510002488175154";
            Assert.AreEqual("2488175154", Hash.obterCrc32Utf8(r19.Substring(0, r19.Length - 10)));
        }
        [TestMethod]
        public void Helpers_HashCrc32_RegistroT9()
        {
            // registro "R19" gerado na declaração de 2020 com dados randômicos
            string rT9 = "T9111111110300000170000100000000000000100001000010000000000000010000300002000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000002000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000100001000000000000000000000000000000000003765855037";
            Assert.AreEqual("3765855037", Hash.obterCrc32Utf8(rT9.Substring(0, rT9.Length - 10)));
        }
        [TestMethod]
        public void Helpers_Valida_NRControle_RegistroT9()
        {
            // registro "R19" gerado na declaração de 2020 com dados randômicos
            string rT9 = "T9111111110300000170000100000000000000100001000010000000000000010000300002000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000002000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000100001000000000000000000000000000000000003765855037";
            Assert.IsTrue(Hash.Valida_NRControle(rT9, "3765855037"));
        }

        [TestMethod]
        public void Helpers_HashCrc32_Ascii127()
        {
            string txt = "0123456789 ABCDEFGHIJKLMNOPQRSTUVWXYZ-abcdefghijklmnopqrstuvwxyz";
            Assert.AreEqual("1164571807", Hash.obterCrc32Utf8(txt));

            // Hash com todos os caracteres ASCII127
            StringBuilder sb = new StringBuilder();
            for (char c = '\0'; c < 128; c++)
            {
                sb.Append(c);
            }
            Assert.AreEqual("0610602327", Hash.obterCrc32Utf8(sb.ToString()));

            txt = "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz"
                + "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz"
                + "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz"
                + "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz"
                + "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz";
            Assert.AreEqual("1918949460", Hash.obterCrc32Utf8(txt));
        }
        [TestMethod]
        public void Helpers_HashCrc32_ArrayLinhas()
        {
            // Certifica que o Array de linhas é igual ao calculo concatenado do teste Helpers_HashCrc32_Ascii127
            string[] arr = { "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz", // Acum: 2808346969
                             "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz", // Acum: 3915510840
                             "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz", // Acum: 1930397578
                             "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz", // Acum: 3367836050
                             "#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz" };

            Assert.AreEqual("1918949460", Hash.obterCrc32Utf8Linhas(arr));
        }
    }
}
