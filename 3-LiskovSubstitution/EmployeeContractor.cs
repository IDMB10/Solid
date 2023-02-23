namespace Liskov
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked)
        {
        }

        public override decimal CalculateSalary()
        {
            const decimal hourValue = 50;
            return hourValue * HoursWorked;
        }
    }
}