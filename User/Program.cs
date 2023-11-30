using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter user details:");
        Console.Write("Login: ");
        string login = Console.ReadLine();

        Console.Write("First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Age: ");
        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine("Invalid input. Please enter a valid number for age.");
            return;
        }

        User user = new User(login, firstName, lastName, age);
        user.DisplayUserInfo();

    }
}
