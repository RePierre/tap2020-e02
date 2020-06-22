using TAP2020E02.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TAP2020E02.Test
{
    [TestClass]
    public class IsIbanPalindrom
    {
        public IbanClient client { get; set; }

      /*  [TestInitialize]
        public long TestInitialize()
        {
           return  client.Iban = 1131007593840000;
        }
       */
        [TestMethod]
        public void IsPalindromThrow()
        {
            //Arrange
            long ib = 1000000000000001; ;
            bool isit;
            bool exceptionThrown = true;
            //Act
            try
            { 
                isit=Palindrom.IsPalindrom(ib);
                Console.WriteLine("it is palindrome");
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
