using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsPalindrome;

namespace UnitTests
{
    [TestClass]
    public class IbanIsPalindromeTests
    {
        [TestMethod]
        public void IbanIsNotPalindrome()
        {
            //Arange
            string iban = "RO17PORL8859516163898428";
            //Act
            bool result = iban.IsPalindrome();
            bool expected = false;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void IbanIsPalindrome()
        {
            //Arange
            string iban = "RO74PORL1111111111111111";
            //Act
            bool result = iban.IsPalindrome();
            bool expected = true;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
