using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int answer = int.Parse(userInput);
        while (answer != number)
        {
            if (answer < number)
            {
                Console.WriteLine("Higher");
            }
            else if(answer > number)
            {
                Console.WriteLine("Lower");

            }
            Console.Write("What is your guess?");
            userInput = Console.ReadLine();
            answer = int.Parse(userInput);
        }
        Console.WriteLine($" You guessed it! IT'S {number} ");
    }
}