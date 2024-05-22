    using System;

    public class Retangle : Shape
    {
        private double _lenght;
        private double _width;
    
    public Retangle(string color, double lenght, double width): base(color)
    {
        _lenght = lenght;
        _width = width;
    }
    public override double GetArea()
    {
        return _lenght * _width;
    }
}