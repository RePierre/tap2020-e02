using Microsoft.VisualStudio.TestTools.UnitTesting;
using TAP2020E02.Core;

namespace TAP2020E02.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string iban = "RO48PORL4889462216578213";
            
            //Act
            bool isPalindrom=PalindromeExtensions.IsPalindrome(iban.Substring(8));

            //Assert
            Assert.AreEqual(true,isPalindrom);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string iban = "RO48PORL1234567887654321";

            //Act
            bool isPalindrom = PalindromeExtensions.IsPalindrome(iban.Substring(8));

            //Assert
            Assert.IsTrue(isPalindrom);
        }
    }
}
