using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}

public class Fraction
{
    private int _top;
    private int _bottom ;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public  Fraction( int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public  Fraction(int top,int bottom)
    {
        _bottom = bottom;
        _top = top;
    }


    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom; 
    }


}
