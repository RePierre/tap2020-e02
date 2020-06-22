using System;
using Library;

namespace GinigaGabrielE02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IWriter writer = Factory.CreateWriter();
            IReader reader = Factory.CreateReader();
            IEmployee Vasile = Factory.CreateEmployee();
            Vasile.Name = "Gheorhe";
            writer.firstLine(Vasile.Name);

            Vasile.IBAN = reader.readingFromConsole();

            writer.showResultInConsole(Vasile.IBAN.IsPalindrom(),Vasile.IBAN);

            Console.ReadLine();


        }
    }
}
