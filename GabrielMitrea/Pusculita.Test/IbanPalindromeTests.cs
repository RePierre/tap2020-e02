using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
namespace Pusculita.Test
{
    [TestClass]
    public class IbanPalindromeTests
    {
        [TestMethod]
        public void isPalindrome()
        {
            var Iban = "17671".isPalindrome();
            Assert.IsTrue(Iban);
        }

    }
    public static class StringEx
    {
        public static bool isPalindrome(this string value)
        {
            if (value == null) throw new ArgumentNullException("value");
            if (value.Length > 2) return true;
            if(value.First()==value.Last())
            {
                return value.Substring(1, value.Length - 2).isPalindrome();
            }
                return false;
            return true;
        }
    }
}
