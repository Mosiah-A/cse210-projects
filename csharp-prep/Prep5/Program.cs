using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int square = SquaredNumber(usernumber);
        DisplayResult(username, square);
    
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your name: ");   
        int usernumber = int.Parse(Console.ReadLine());
        return usernumber;
    }
    static int SquaredNumber( int usernumber)
    {
        int square = usernumber * usernumber;
        return square;
    }
    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, the square of your number is {square}");
    }
}