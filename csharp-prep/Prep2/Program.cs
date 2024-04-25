using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade Percentage? (0-100) ");
        string userInput = Console.ReadLine();
        int gradeNumber = int.Parse(userInput);
        string gradeLetter = "None";
        if ( gradeNumber >= 90)
        {
            gradeLetter = "A";
        }
        else if ( gradeNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNumber >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        
        Console.WriteLine($"Your Grade is: {gradeLetter}");
        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulation you Pass");
        }
        else{
            Console.WriteLine("Sorry, you dont Pass");
        }
    }
}