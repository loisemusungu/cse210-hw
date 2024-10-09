using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create a list of orders
        Order order1 = new Order(new Customer("John Doe", new Address("123 Main St", "Springfield", "IL", "USA")));
        order1.AddProduct(new Product("Apple", 0.50m, 5));
        order1.AddProduct(new Product("Banana", 0.25m, 10));
        order1.AddProduct(new Product("Orange", 0.75m, 3));

        Order order2 = new Order(new Customer("Jane Smith", new Address("456 Elm St", "Springfield", "IL", "USA")));
        order2.AddProduct(new Product("Milk", 2.50m, 2));
        order2.AddProduct(new Product("Bread", 1.50m, 3));


        // Step 2: Display the packing label and total cost for each order
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}");

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost():C}");
    }
}