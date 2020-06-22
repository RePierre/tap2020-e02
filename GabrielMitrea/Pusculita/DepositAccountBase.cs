namespace Pusculita
{
    public abstract class DepositAccountBase : IDepositAccount
    {
        public string Iban { get; set; }
        public decimal Amount { get; protected set; }
        public void Deposit(decimal amount)
        {
            Amount += amount;
        }
    }

}
