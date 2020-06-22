using System;
using System.Collections.Generic;
using System.Text;

namespace Uaic.IsPalindrom
{
    public class Palindrom:Number
    {   
        public bool palindromNumber(long numar) 
        {
            long inversNumber=InversNumber(numar);
            if (numar == inversNumber)
                return true;
            else
                return false;
        }
        public long InversNumber(long initialNumber)
        {
            long inversNumber = 0;
            while (initialNumber > 0)
            {
                long c = initialNumber % 10;
                inversNumber = inversNumber * 10 + c;
                initialNumber = initialNumber / 10;
            }
            return inversNumber;
        }

    }
}

