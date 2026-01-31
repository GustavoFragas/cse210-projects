using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.Clear();

        Customer customer = new Customer("Gustavo Fragas", new Adress("123 Main St", "Anytown", "Anystate", "USA"));
        Product productGustavo1 = new Product("Laptop", "P001", 25, 1);
        Product productGustavo2 = new Product("Mouse", "P002", 25.50, 2);
        Order order = new Order(customer);
        order.AddProduct(productGustavo1);
        order.AddProduct(productGustavo2);
        Console.WriteLine($"Hi there {customer.GetName()}");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Your shipping address is valid: {customer.GetAdress()}");
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");

        Console.WriteLine();

        Customer customer2 = new Customer("Amanda Silva", new Adress("Anchieta 121", "Sao Paulo", "Sao Paulo", "Brazil"));
        Product productAmanda1 = new Product("Bruh", "P003", 12.32, 5);
        Product productAmanda2 = new Product("Clash Royale", "P004", 12, 5);
        Order order1 = new Order(customer2);
        order1.AddProduct(productAmanda1);
        order1.AddProduct(productAmanda2);
        Console.WriteLine($"Hi there {customer2.GetName()}");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Your shipping address is valid: {customer2.GetAdress()}");
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
    
         
    }
}