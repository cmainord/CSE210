using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Order orderA = new Order
        (
            new Customer
            (
                "Staniel John",
                new Address("100 Tree St. #1", "Caldwell", "Idaho", "USA")
            ),

            [
                new Product("Flex Tape", "001", 1, 3),
                new Product("Super Noodles", "002", 8.50, 500),
                new Product("Rubber Chicken", "003", 1.25, 17)
            ]
        );

        Order orderB = new Order
        (
            new Customer
            (
                "Danley Smithson",
                new Address("32 Maple Syrup Way", "Vanderhoof", "British Colombia", "Canada")
            ),

            [
                new Product("Authentic Japanese Ninja Sword", "004", 15, 3),
                new Product("Maple Syrup", "005", 25.80, 10),
                new Product("Hatsune Miku Body Pillow", "006", 6000, 1)
            ]
        );

        Console.WriteLine();
        Console.WriteLine($"{orderA.GetShippingLabel()}");
        Console.WriteLine($"{orderA.GetPackingLabel()}");
        Console.WriteLine($"Total Price: ${orderA.GetTotalPrice()}");
        Console.WriteLine("\n");
        Console.WriteLine($"{orderB.GetShippingLabel()}");
        Console.WriteLine($"{orderB.GetPackingLabel()}");
        Console.WriteLine($"Total Price: ${orderB.GetTotalPrice()}");
        Console.WriteLine();
        
    }
}