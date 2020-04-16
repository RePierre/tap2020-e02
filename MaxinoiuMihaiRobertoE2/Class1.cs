using System;

namespace MyClassLIbrary
{
    public class Class1
    {
    }

    public class Tester
    {
        public double isPalindrome(string input)
        { 
            string revs = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                revs += input[i].ToString();
            }
            if (revs == input)
                return 1; // IsPalindrome
            else
                return 0; //  IsNotPalindrome

        }
    }
}
