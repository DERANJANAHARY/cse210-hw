using System;

class Program
{
    static void Main(string[] args)
    {
        // FIRST ORDER (USA)
        Address a1 = new Address("100 Main St", "Springfield", "IL", "USA");
        Customer c1 = new Customer("Alice Johnson", a1);
        Order order1 = new Order(c1);

        order1.AddProduct(new Product("USB Cable", "UCB-100", 3.50m, 3));
        order1.AddProduct(new Product("Wireless Mouse", "MSE-200", 25.99m, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.TotalPrice():C}");
        Console.WriteLine();

        // SECOND ORDER (International)
        Address a2 = new Address("22 Queen Rd", "Antananarivo", "Analamanga", "Madagascar");
        Customer c2 = new Customer("Basile Rakoto", a2);
        Order order2 = new Order(c2);

        order2.AddProduct(new Product("Notebook", "NTB-01", 7.25m, 5));
        order2.AddProduct(new Product("Pen Set", "PEN-09", 4.50m, 2));
        order2.AddProduct(new Product("Headphones", "HP-300", 45.00m, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.TotalPrice():C}");
    }
}
