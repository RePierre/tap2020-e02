using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IBAN_Extension;

namespace IBAN_tests
{
    [TestClass]
    public class IBAN_test
    {
        [TestMethod]
        public void IsPalindromShouldReturnTrue()
        {
            string test_IBAN = "1234567887654321";

            bool test_result = test_IBAN.IsPalindrome();

            Assert.IsTrue(test_result);
        }

        [TestMethod]
        public void IsPalindromShouldReturnFalse()
        {
            string test_IBAN = "5422559984543617";

            bool test_result = test_IBAN.IsPalindrome();

            Assert.IsFalse(test_result);
        }

        [TestMethod]
        public void IsPalindromShouldThrow()
        {
            string test_IBAN = "1";
            bool exception_thrown = false;

            try
            {
                test_IBAN.IsPalindrome();
            }
            catch (ArgumentException)
            {
                exception_thrown = true;
            }

            Assert.IsTrue(exception_thrown);
        }
    }
}
