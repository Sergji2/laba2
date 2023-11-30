using System;

class Program
{
    static void Main()
    {
        Address parisAddress = new Address();

        parisAddress.Index = "75001";
        parisAddress.Country = "France";
        parisAddress.City = "Paris";
        parisAddress.Street = "Champs-Élysées";
        parisAddress.House = "1";
        parisAddress.Apartment = "5A";

        Console.WriteLine("Address Information:");
        Console.WriteLine($"Index: {parisAddress.Index}");
        Console.WriteLine($"Country: {parisAddress.Country}");
        Console.WriteLine($"City: {parisAddress.City}");
        Console.WriteLine($"Street: {parisAddress.Street}");
        Console.WriteLine($"House: {parisAddress.House}");
        Console.WriteLine($"Apartment: {parisAddress.Apartment}");

    }
}
