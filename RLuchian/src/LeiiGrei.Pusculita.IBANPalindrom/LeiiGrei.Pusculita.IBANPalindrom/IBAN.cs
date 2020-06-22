using System;

namespace LeiiGrei.Pusculita.IBANPalindrom
{
    public class IBAN
    {
        string IBAN;
        public static bool IsPalindrome(String IBAN)
        {
            var isNumeric = int.TryParse("123", out _);
            if (!isNumeric) {
                throw new InvalidOperationException("Not an IBAN");
                return false;
            }
            for (int i = 0; i < IBAN.Length; i++) {
                if (IBAN[i] != IBAN[IBAN.Length - i - 1])
                {
                    throw new InvalidOperationException("Not a palindrome!");
                    return false;
                }
            }
            return true;
        } 

    }
}
