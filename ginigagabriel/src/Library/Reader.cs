using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Reader : IReader
    {
        public string readingFromConsole()
        {
            string IBAN;
            IBAN = Console.ReadLine();
            return IBAN;
        }

    }
}
