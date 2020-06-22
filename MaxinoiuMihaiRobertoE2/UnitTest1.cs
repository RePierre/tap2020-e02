using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLIbrary;
using NUnit.Framework.Internal;

namespace PalindromeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            
            Tester rooter = new Tester();
            
            double expectedResult = 1;
            string input = "1111111111111111101111111111111111";
            
            double actualResult = rooter.isPalindrome(input);
           
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }
    }
    }

