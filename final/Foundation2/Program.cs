using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders= new();

        Order order1 = new(new Customer("Jack Reacher", new Address("456 Gun Ave", "Los Angeles", "CA", "USA")));
        order1.AddProduct(new Product("Iphone XR Screen Protector", 7255614, 10.99, 2));
        order1.AddProduct(new Product("Rotisserie Chicken (whole)", 12362518, 4.99, 1));
        order1.AddProduct(new Product("Toothpicks (50 pack)", 5451646, 2.99, 3));
        orders.Add(order1);

        Order order2 = new(new Customer("Christine Wall", new Address("1221 Sugar St", "Cardston", "Alberta", "CA")));
        order2.AddProduct(new Product("Cornhole Set", 15121341, 45.49, 1));
        order2.AddProduct(new Product("Parachute", 92461564, 58.69, 2));
        orders.Add(order2);

        int i = 1;
        foreach(Order order in orders)
        {
            Console.WriteLine($"Order {i}: ");
            Console.WriteLine();
            Console.WriteLine("Packing Label: ");
            Console.WriteLine();
            foreach(string productLabel in order.GetPackingLabel())
            {
                Console.WriteLine(productLabel);
            }
            Console.WriteLine();
            Console.WriteLine("Shipping Label: ");
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():F2}");
            Console.WriteLine();
            Console.WriteLine();
            i++;
        }
    }
}