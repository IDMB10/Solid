namespace Liskov
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public Employee(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public abstract decimal CalculateSalary();

        //No cumple el principio Liskov ya que todos los subtipos no tienen horas extras
        // public virtual decimal CalculateSalary (bool IsFullTime)
        // {   
        //     decimal hourValue = IsFullTime ? 50 : 40;
        //     return hourValue * (HoursWorked + ExtraHours);
        // } 
    }
}