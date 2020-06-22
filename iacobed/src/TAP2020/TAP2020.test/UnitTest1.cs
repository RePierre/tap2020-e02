using Microsoft.VisualStudio.TestTools.UnitTesting;
using TAP;

namespace TAP2020.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string iban = "RO35RZBR1897765234414139";

            //Assert
            Assert.AreEqual(false, IsPalindrome.getPalindrome(iban.Substring(8)));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string iban = "RO35RZBR1234567887654321";

            //Assert
            Assert.IsTrue(IsPalindrome.getPalindrome(iban.Substring(8)));
        }
    }
}
