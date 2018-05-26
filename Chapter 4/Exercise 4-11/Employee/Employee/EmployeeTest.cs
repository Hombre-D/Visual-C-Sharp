using System;


class EmployeeTest
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Dan", "Nygard", 1000.0m);
        Employee employee2 = new Employee("Nicole", "Nyygard", 2000.0m);
        Console.WriteLine($"Employee 1: {employee1.FirstName} {employee1.LastName}, " +
            $"Monthly Salary: {employee1.MonthlySalary} Yearly Salary: {employee1.YearSalary()}");
        Console.WriteLine($"Employee 2: {employee2.FirstName} {employee2.LastName}, " +
            $"Monthly Salary: {employee2.MonthlySalary} Yearly Salary: {employee2.YearSalary()}");
        employee1.GiveRaise(.1m);
        employee2.GiveRaise(.1m);
        Console.WriteLine("After Raise:");
        Console.WriteLine($"Employee 1: {employee1.FirstName} {employee1.LastName}, " +
            $"Monthly Salary: {employee1.MonthlySalary} Yearly Salary: {employee1.YearSalary()}");
        Console.WriteLine($"Employee 2: {employee2.FirstName} {employee2.LastName}, " +
            $"Monthly Salary: {employee2.MonthlySalary} Yearly Salary: {employee2.YearSalary()}");
    }
}

