using System;
using System.Collections.Generic;
using System.Text;

namespace GalbinitaSebastian
{
    class IBAN
    {
        public int Id { get; set; }
        public long Iban { get; set; }

        public void setIban(long creditCard)
        {
            Iban = creditCard;
        }
    }
}
