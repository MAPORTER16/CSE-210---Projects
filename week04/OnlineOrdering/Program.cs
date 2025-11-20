using System;

class Program
{
    static void Main(string[] args)
    {
        // First customer (USA)
        var address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        var customer1 = new Customer("Alice Johnson", address1);

        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", "W-100", 3.50, 5));
        order1.AddProduct(new Product("Gadget", "G-200", 10.00, 2));

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Order 1 Total Price: ${order1.TotalPrice():F2}");
        Console.WriteLine(new string('-', 40));

        // Second customer (international)
        var address2 = new Address("456 Market Ave", "London", "Greater London", "United Kingdom");
        var customer2 = new Customer("Bob Smith", address2);

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Thingamajig", "T-300", 25.00, 1));
        order2.AddProduct(new Product("Doohickey", "D-400", 7.25, 3));
        order2.AddProduct(new Product("Accessory", "A-500", 2.00, 4));

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Order 2 Total Price: ${order2.TotalPrice():F2}");
    }
}