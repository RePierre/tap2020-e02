using System;

namespace IBAN_Extension
{
    public static class IBANExtension
    {
        public static bool IsPalindrome(this string IBAN)
        {
            if (IBAN.Length != 16)
                throw new ArgumentException("IBAN length should be 16");

            for (int i = 0; i < (IBAN.Length / 2); i++)
                if (IBAN[i] != IBAN[IBAN.Length - i - 1])
                    return false;
            return true;
        }
    }
}
