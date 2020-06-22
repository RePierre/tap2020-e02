using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare2 { 
    class Bank: PersonIsPalindrom
    {
        public ulong Iban { get; protected set; }
        public string Name { get; protected set; }
        public decimal Account { get; protected set; }
    }
}
