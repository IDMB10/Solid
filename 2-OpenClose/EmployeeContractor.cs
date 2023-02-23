using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClose
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked)
        : base(fullname, hoursWorked) { }
        public override decimal CalculateSalaryMonthly()
        {
            //Abierto para extensiones
            throw new NotImplementedException();
        }
    }
}