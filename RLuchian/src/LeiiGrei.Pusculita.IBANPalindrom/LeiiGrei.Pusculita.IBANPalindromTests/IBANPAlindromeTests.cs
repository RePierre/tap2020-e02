using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeiiGrei.Pusculita.IBANPalindrom;

namespace LeiiGrei.Pusculita.IBANPalindromTests
{
    public class IBANPalindromeTests
    {
        [TestClass]

        public class WhenStringIsNotIBAN
        {
            [TestInitialize]
            public void TestInitialize()
            {
                IBAN Iban = new IBAN();
            }
            [TestMethod]
            [ExpectedException(typeof(InvalidOperationException))]

            public void throwException()
            {   //Arrange
                string IbanNumber= "2734471529361444";
                bool exceptionThrown = true;
                //Act
                try
                {
                    Iban.IsPaldindrome(IbanNumber);
                }
                catch (ExpectedExceptionAttribute) {
                    exceptionThrown = true;
                }
                //Assert
                Assert.IsTrue(exceptionThrown);
            }
        }

        [TestClass]

        public class WhenIBANIsNotPalindrome
        {

            [TestInitialize]
            public void TestInitialize()
            {
                IBAN Iban = new IBAN();
            }
            [TestMethod]
            [ExpectedException(typeof(InvalidOperationException))]

            public void throwException()
            {   //Arrange
                string IbanNumber = "2734471529361444";
                bool exceptionThrown = true;
                //Act
                try
                {
                    Iban.IsPaldindrome(IbanNumber);
                }
                catch (ExpectedExceptionAttribute)
                {
                    exceptionThrown = true;
                }
                //Assert
                Assert.IsTrue(exceptionThrown);
            }
        }
    }
}
