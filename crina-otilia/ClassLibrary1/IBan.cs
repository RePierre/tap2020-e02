using System;
using System.Collections.Generic;
using System.Text;

namespace tap_e2.library
{
    public class IBan
    {
        string Iban="";

        public IBan(string s) {
            this.Iban = s;
        }
        public  string IBAN{ get; protected set;}
    }
}
