class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalaryAndTax(string position, int experience)
    {
        double baseSalary = 30000;
        double experienceBonus = experience * 1000;
        double totalSalary = baseSalary + experienceBonus;

        double taxRate = 0.15;
        double tax = totalSalary * taxRate;

        Console.WriteLine($"Employee Information:");
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Base Salary: {baseSalary:C}");
        Console.WriteLine($"Experience Bonus: {experienceBonus:C}");
        Console.WriteLine($"Total Salary: {totalSalary:C}");
        Console.WriteLine($"Tax ({taxRate * 100}%): {tax:C}");
    }
}