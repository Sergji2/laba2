using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter employee details:");
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Position: ");
        string position = Console.ReadLine();

        Console.Write("Experience (in years): ");
        if (!int.TryParse(Console.ReadLine(), out int experience))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for experience.");
            return;
        }

        Employee employee = new Employee(lastName, firstName);
        employee.CalculateSalaryAndTax(position, experience);

    }
}
