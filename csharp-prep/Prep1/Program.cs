using System;

class Program
{
    static void Main(string[] args)
    {
        //first name input
        Console.Write("what is your first name? ");
        string fname = Console.ReadLine();
        
        //last name input
        Console.Write("what is your last name? ");
        string lname = Console.ReadLine();

        //The output
        Console.WriteLine($"Your name is {lname}, {fname} {lname}.");

    }
}