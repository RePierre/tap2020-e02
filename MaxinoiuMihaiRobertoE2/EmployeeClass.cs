using System;

namespace MaxinoiuMihaiRobertoE2
{
    public class EmployeeClass : IEmployeeInterface
    {
        public EmployeeClass(int Employeeid, string iban, string EmployeeN, double sallary)
        {
            EmployeeID = Employeeid;
            IBAN = iban;
            EmployeeName = EmployeeN;
        
            Sallary = sallary;
           
        }

        public string IBAN { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        
        public double Sallary { get; set; }

        public double getGift(EmployeeClass employee)
        {
            return employee.Sallary + 512;
        }
    }
    static class IsPalindromeExtensions
    {
        static string Data(this EmployeeClass value)
            => $"{value.EmployeeName} {value.IBAN}";
    }
}
