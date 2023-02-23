namespace OpenClose
{
    public class EmployeePartTime : Employee
    {
        public EmployeePartTime(string fullname, int hoursWorked)
        : base(fullname, hoursWorked) { }

        public override decimal CalculateSalaryMonthly()
        {
            const decimal hourValue = 20000M;
            decimal salary = hourValue * HoursWorked;
            if (HoursWorked > 160)
            {
                const decimal effortCompensation = 5000M;
                int extraDays = HoursWorked - 160;
                salary += effortCompensation * extraDays;
            }
            return salary;
        }
    }
}