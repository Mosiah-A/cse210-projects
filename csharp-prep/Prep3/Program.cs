using System;

class Program
{
    static void Main(string[] args)
    {
        string repet = "yes";
        while ( repet == "yes")
        {
            // Console.Write("What is the magic number? ");
            // int magicNumber = int.Parse(Console.ReadLine());
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
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
                Console.Write("What is your guess? ");
                userInput = Console.ReadLine();
                answer = int.Parse(userInput);
            }
            Console.WriteLine($" You guessed it! IT'S {number} ");
            
            Console.WriteLine("Do you want to play again? (yes / no)");
            repet = Console.ReadLine();
        }
    }
}