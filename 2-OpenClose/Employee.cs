using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClose
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public Employee(string fullname, int hoursWorked)
        {
            this.Fullname = fullname;
            this.HoursWorked = hoursWorked;
        }

        public abstract decimal CalculateSalaryMonthly();
    }
}