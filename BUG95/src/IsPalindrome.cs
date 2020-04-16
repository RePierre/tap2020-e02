using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    public static class ExtensionMethodFoRStringType
    {
        public static bool IsPalindrome(this string iban)
        {
            string copy_iban = iban.Substring(8);
            string _iban = "";
            int length = copy_iban.Length - 1;
            while (length >= 0)
            {
                _iban += iban[length];
                length--;
            }
            return copy_iban.Equals(_iban);
        }
    }
}
