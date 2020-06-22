using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluare2.Core.Assets.Base
{
    class Bank : IBank
    {
        public int Iban { get; protected set; }
        public string Name { get; protected set; }
        public decimal Account { get; protected set; }
    }
}
