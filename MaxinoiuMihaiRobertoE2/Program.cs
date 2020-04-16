using System;
using Employee;


namespace MaxinoiuMihaiRobertoE2
{
    class Program
    {
        
        static void Main(string[] args)
        {
             void palindrome(string IBAN)
            {
                string revs = "";
                for (int i = IBAN.Length - 1; i >= 0; i--)
                {
                    revs += IBAN[i].ToString();
                }
                if (revs == IBAN)
                {
                    Console.WriteLine("Your IBAN is palindrome", IBAN, revs);
                }
                else
                {
                    Console.WriteLine("Your IBAN is palindrome", IBAN, revs);
                }

            }
            EmployeeClass Employee1=new EmployeeClass(1,"123456789098765432112345678909876","George",1000);

            EmployeeClass Employee2 = new EmployeeClass(1, "1111111111111111101111111111111111", "Ion", 1200);
            
            palindrome(Employee1.IBAN);
            palindrome(Employee2.IBAN);
            


        }
    }
}
