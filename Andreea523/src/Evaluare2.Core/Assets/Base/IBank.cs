namespace Evaluare2.Core.Assets.Base
{
    interface IBank
    {
        decimal Account { get; }
        int Iban { get; }
        string Name { get; }
    }
}