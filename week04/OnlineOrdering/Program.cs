using System;
using System.Collections.Generic;

class Program{
    static void Main(string[] args){
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Mouse", "M123", 15.99m, 2));
        order1.AddProduct(new Product("Keyboard", "K456", 45.50m, 1));

        Address address2 = new Address("456 Cherry Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Johnson", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "MN789", 199.99m, 1));
        order2.AddProduct(new Product("HDMI Cable", "HD001", 10.00m, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}