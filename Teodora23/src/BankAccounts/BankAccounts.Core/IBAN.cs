using System;

namespace BankAccounts.Core
{
    public class IBAN
    {
        public string Country { get; set; }
        public string Checksum { get; set; }
        public string Swift { get; set; }
        public string AccountNumber { get; set; }

        public IBAN(string iban)
        {
            this.Country = iban.Substring(0, 2);
            this.Checksum = iban.Substring(2, 2);
            this.Swift = iban.Substring(4, 4);
            this.AccountNumber = iban.Substring(8);
        }
    }
}
