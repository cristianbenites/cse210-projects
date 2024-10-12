using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("10346 N Davis Rd", "Davis", "Illinois(IL)", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Gaming Keyboard", "KB123", 99.99, 2));
        order1.AddProduct(new Product("Acer Aspire Go 15 Slim Laptop", "AC231", 259.99, 1));
        order1.AddProduct(new Product("Razer Gaming Mouse", "RZ8882", 39.99, 1));

        Address address2 = new Address("Rua dos Imbus 18", "Porto Alegre", "Rio Grande do Sul", "Brasil");
        Customer customer2 = new Customer("Maria José da Silva", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Extra Large Travel Backpack", "TVB2828", 23.99, 5));
        order2.AddProduct(new Product("Hooded Sweatshirt for Men", "HDD11", 14.66, 8));
        order2.AddProduct(new Product("Workout Running Yoga Leggings for Women", "LG1123", 24.99, 6));

        List<Order> orders = [order1, order2];

        orders.ForEach(order => {
            Console.WriteLine("   =====   ORDER   =====");
            Console.WriteLine("Packing Label");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine("---\n");
            Console.WriteLine("Shipping Label");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("---\n");
            Console.WriteLine("Total Price: " + order.GetTotalPrice().ToString("C"));
            Console.WriteLine("\n");
        });
    }
}