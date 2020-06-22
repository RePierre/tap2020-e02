using BankAccounts.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Tests
{
    public class BankAccountsTests
    {
        public IBAN Iban { get; protected set; }

        protected void Initialize()
        {
            this.Iban = new IBAN();
        }

        [TestClass]
        public class WhenIsPalindrome : BankAccountsTests
        {
            [TestInitialize]
            public void TestInitialize()
            {
                Initialize();
            }

            [TestMethod]
            public void IsPalindromeShouldReturnTrue()
            {
                this.Iban.SetIBAN("RO41RZBR1234567887654321");

                bool result = this.Iban.IsPalindrome();

                Assert.IsTrue(result);
            }
        }

        [TestClass]
        public class WhenIsNotPalindrome : BankAccountsTests
        {
            [TestInitialize]
            public void TestInitialize()
            {
                Initialize();
            }

            [TestMethod]
            public void IsPalindromeShouldReturnFalse()
            {
                this.Iban.SetIBAN("RO41RZBR1764567821546321");

                bool result = this.Iban.IsPalindrome();

                Assert.IsFalse(result);
            }
        }
    }
}