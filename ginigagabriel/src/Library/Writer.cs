using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Writer : IWriter
    {
        public void firstLine(string Name)
        {
            Console.WriteLine(" Introduce IBAN lui {0}: ",Name);

        }


        public void showResultInConsole(bool boolean, string IBAN)
        {
            if (boolean)
                Console.WriteLine("IBAN: {0} este palindrom. ", IBAN);
            else Console.WriteLine("IBAN: {0} nu este palindrom. ", IBAN);
        }
    }
}
