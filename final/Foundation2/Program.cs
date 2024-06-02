using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================Order 1========================");

        Order order = new Order("123 Bronsun", "Zaraenla", "Zion", "GOD Country", "Mosiah");

        order.Addproduct("bike", "ABC123", 17, 2);
        order.Addproduct("car", "DEF456", 10, 1);
        
        Console.WriteLine();
        Console.WriteLine($"Order 1 Total Cost: {order.GetTotalCost()}");
        order.GetPackingLabel();
        
        Console.WriteLine();
        Console.WriteLine("Shipping Label\n===============");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("========================Order 2========================");

        Order order2 = new Order("456 Corn street", "New York City", "NY", "USA", "Lehi");

        order2.Addproduct("Burguer", "GHI789", 1, 2);
        order2.Addproduct("SWORD CANDY", "HJG756", 7, 10);
        
        Console.WriteLine();
        Console.WriteLine($"Order 2 Total Cost: {order2.GetTotalCost()}");
        order2.GetPackingLabel();
        
        Console.WriteLine();
        Console.WriteLine("Shipping Label\n===============");
        Console.WriteLine(order2.GetShippingLabel());

    }
}