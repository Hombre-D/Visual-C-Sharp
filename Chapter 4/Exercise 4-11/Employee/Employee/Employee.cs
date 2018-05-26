//Exercise 4-11. Employee Class

class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    private decimal monthlySalary;

    public Employee(string firstName, string lastName, decimal monthlySalary)
    {
        FirstName = firstName;
        LastName = lastName;
        MonthlySalary = monthlySalary;
    }

    public decimal MonthlySalary
    {
        get
        {
            return monthlySalary;
        }

        set
        {
            if(value > 0.0m)
            {
                monthlySalary = value;
            }
        }
    }

    public decimal YearSalary()
    {
        return monthlySalary * 12;
    }

    public void GiveRaise(decimal raise)
    {
        monthlySalary += monthlySalary * raise;
    }

}
