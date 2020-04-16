using TAP2020E02.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TAP2020E02.Test
{
    [TestClass]
    public class IsIbanPalindrom
    {
        public IbanClient client { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            client.Iban = 1131007593840000;
        }
       
        [TestMethod]
        public void IsPalindromThrow()
        {
            //Arrange
            bool isit;
            bool exceptionThrown = true;
            //Act
            try
            { 
                isit=Palindrom.IsPalindrom(client.Iban);
            }
            catch (InvalidOperationException)
            {
                exceptionThrown = true;
            }
            //Assert
            Assert.IsTrue(exceptionThrown);
        }
    }
}
