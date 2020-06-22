using System;
using System.Collections.Generic;
using System.Text;

namespace tapE2
{
    public class IBan:IsPalindrom
    {
        int Iban=0;
        public IBan(string s) { 
            
            this.Iban = Int32.Parse(s); }
        public  int IBAN{ get; protected set;}
    }
}
