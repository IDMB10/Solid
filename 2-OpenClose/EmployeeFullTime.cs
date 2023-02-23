namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {
        public EmployeeFullTime(string fullname, int hoursWorked)
        : base(fullname, hoursWorked) { }

        public override decimal CalculateSalaryMonthly()
        {
            const decimal hourValue = 30000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}