using System;

namespace tap20_e2
{
    class Program
    {
        static void Main(string[] args)
        {
            IBan Iban1 = new IBan("123456789100001987654321");
            IBan Iban2 = new IBan("154643654365436546546541");
            //"123456789100001987654321"
            CheckIBAN check = new CheckIBAN();
            check.CheckPalindrome(Iban1);
            check.CheckPalindrome(Iban2);

        }
    }
}
