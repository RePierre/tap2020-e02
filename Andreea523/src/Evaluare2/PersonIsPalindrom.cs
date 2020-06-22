using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare2
{
    class PersonIsPalindrom : IsPalindrom
    {
        protected override string CalculatePalindrom(ulong iban)
        {
            ulong ibanNr, ibanTest = 0;
            ibanNr = iban;
            while (ibanNr!=0)
            {
                ulong c = Decomposition(ibanNr); 
                ibanTest = ConstructNr(ibanTest) + c;
                ibanNr=DivisionNr(ibanNr);

            }
            if (iban == ibanTest)
                return "Paliondrom";
            return "Nu e palindrom";

        }
        private ulong Decomposition(ulong val) 
        {
            return val % 10;
        }
        private ulong ConstructNr(ulong val)
        {
            return val * 10;
        }
        private ulong DivisionNr(ulong val)
        {
            return val/ 10;
        }
    }
}
