using System;
using System.Collections.Generic;
using System.Text;
using Library;

namespace GinigaGabrielE02
{
    class Factory
    {

       
        public static IReader CreateReader()
        {
            return new Reader();
        }
        public static IWriter CreateWriter()
        {
            return new Writer();
        }

        public static IEmployee CreateEmployee()
        {
            return new Employee();
        }

    }
}
