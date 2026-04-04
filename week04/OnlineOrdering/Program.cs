using System;

class Program
{
    static void Main(string[] args)
    {
    var address1 = new Address("123 Market St", "Seattle", "WA", "USA");
        var address2 = new Address("45 Oxford Rd", "London", "England", "UK");

        var customer1 = new Customer("Alice Johnson", address1);
        var customer2 = new Customer("David Smith", address2);

        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "B200", 25.50, 2));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Desk Lamp", "C300", 45.00, 3));
        order2.AddProduct(new Product("Notebook", "D400", 5.00, 10));

        var orders = new List<Order> { order1, order2 };

        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():F2}\n");
        }
    }
}