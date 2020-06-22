using System;
using System.Linq;
using Uaic.IsPalindrom;
namespace GalbinitaSebastian
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customerNumber1 = new Customer("Galbinita Sebastian", 5951962443678287);
            IBAN ibn = new IBAN();
            Palindrom p = new Palindrom();
            Console.WriteLine(p.palindromNumber(customerNumber1.CustomerIBAN));
        }


    }
}
