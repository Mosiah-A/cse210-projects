using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("10/05/2024",30,3);
        Console.WriteLine(running.GetSummary());
        Biking biking = new Biking("10/26/2024", 60,15);
        Console.WriteLine(biking.GetSummary());
        Swimming swimming = new Swimming("10/08/2024", 20, 20);
        Console.WriteLine(swimming.GetSummary());
    }
}