using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        //declaring variables
        string userInput = Console.ReadLine();
        int answer = int.Parse(userInput);
        int sum = answer;
        int largest = 0;
        int smallest = answer;

        //while loop
        while (answer != 0)
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            answer = int.Parse(userInput);
            if (answer != 0)
            {
                numbers.Add(answer); //store the number in a list
            }
            sum = sum + answer; // sum the total
            if (answer > largest)
            {
                largest = answer; // store the higest number
            }
            if (answer > 0)// verify if is positive
            {
                if (answer < smallest)
                {
                    smallest = answer;// store the smallest number
                }
            }
        }
        
        //the output block  
        Console.WriteLine($"The sum is: {sum}");

        float average =  ((float)sum) / numbers.Count  ; 
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive  number is: {smallest}");

        //sort list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}