using Microsoft.VisualStudio.TestTools.UnitTesting;
using tapE2;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            // Create an instance to test:
            IBan iban1 = new IBan("123456789100001987654321");

            // Define a test input and output value:
            bool expectedResult= true;
            
            // Run the method under test:
            bool realResult = iban1.Palindrome(iban1.IBAN);
            // Verify the result:
            Assert.AreEqual(expectedResult, realResult);
        }
    }
}
