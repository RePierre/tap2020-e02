using System;
using System.Collections.Generic;
using System.Text;

namespace Pusculita
{
    public interface IDepositAccount
    {
        decimal Amount { get; }
        string Iban { get; set; }
        void Deposit(decimal amount);
    }
}
