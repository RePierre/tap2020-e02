using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare2.Core.Calculate
{
    class PersonIsPalindrom:IsPalindrom
    {
        protected override bool CalculatePalindrom(int iban)
        {
            int ibanNr, ibanTest = 0;
            ibanNr = iban;
            while (ibanNr!=0)
            {
                int c = Decomposition(ibanNr); 
                ibanTest = ConstructNr(ibanTest) + c;
                ibanNr=DivisionNr(ibanNr);

            }
            if (iban == ibanTest)
                return true;
            return false;

        }
        private int Decomposition(int val) 
        {
            return val % 10;
        }
        private int ConstructNr(int val)
        {
            return val * 10;
        }
        private int DivisionNr(int val)
        {
            return val/ 10;
        }
    }
}
