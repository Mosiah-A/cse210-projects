using System;

public class Product
{
    private string _name = "";
    private string _id = "";
    private double _price = 0;
    private int _quantity = 0;
    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public double CalculateCost()
    {
        return _price * _quantity;
    }
    public string productInf()
    {
        return $"{_id} - {_name}";
    }
}