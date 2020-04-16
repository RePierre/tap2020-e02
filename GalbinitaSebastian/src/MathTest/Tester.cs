using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uaic.IsPalindrom;

namespace MathTest
{
    [TestClass]
    public class Tester
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            Palindrom p = new Palindrom();
            p.palindromNumber(121);
        }
    }
}
