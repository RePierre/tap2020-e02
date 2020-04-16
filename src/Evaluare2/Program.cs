using System;


namespace Evaluare2
{
   

    class Program
    {
        static private string name;
        static private ulong iban;
        static private decimal account;
        static void Main(string[] args)
        {
            Console.Write("The name is: ");
            name = Console.ReadLine();

            Console.Write("The IBAN is: ");
            iban =ulong.Parse(Console.ReadLine());


            Console.Write("The account is: ");
            account = Convert.ToDecimal(Console.ReadLine());

            Bank person = new Person(iban, name, account);
            Console.Write(person.CalculTotal(iban, account));

           
        }
    }
}
