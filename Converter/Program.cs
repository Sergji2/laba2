using System;

class Program
{
    static void Main()
    {
        Converter currencyConverter = new Converter();

        Console.WriteLine("Enter amount:");
        if (!double.TryParse(Console.ReadLine(), out double amount))
        {
            Console.WriteLine("Invalid input. Please enter a valid amount.");
            return;
        }

        Console.WriteLine("Enter currency code (USD, EUR, PLN):");
        string currencyCode = Console.ReadLine();

        double result;

        if (currencyCode.ToLower() == "uah")
        {
            result = currencyConverter.ConvertFromUah(amount, currencyCode);
            Console.WriteLine($"{amount} UAH is equivalent to {result} {currencyCode}");
        }
        else
        {
            result = currencyConverter.ConvertToUah(amount, currencyCode);
            Console.WriteLine($"{amount} {currencyCode} is equivalent to {result} UAH");
        }
    }
}
