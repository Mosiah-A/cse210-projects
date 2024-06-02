using System.Security.Cryptography.X509Certificates;

public class Order
{
    List<Product> _products;
    Customer _customer;
    public Order(string street, string city, string stateProv, string country, string name)
    {
        _customer = new Customer(street,city,stateProv,country,name);
        _products = new List<Product>();
    }
    public void Addproduct(string name, string id, double price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _products.Add(product);
    }
    public void GetPackingLabel()
    {
        Console.WriteLine();

        Console.WriteLine("Packing Label \n================");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.productInf());
        }
    }
    public string GetShippingLabel()
    {
        return _customer.GetShippingAddress();
    }
    private double GetShippingCost()
    {   
        if (_customer.LivingInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public double GetTotalCost()
    {
        double TotalCost = 0;
        foreach (Product product in _products)
        {
            TotalCost = TotalCost + product.CalculateCost();
        }
        return TotalCost + GetShippingCost();
    }
}