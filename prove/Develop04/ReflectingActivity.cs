using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    protected List<string> _prompts = new List<string>{"----Think of a time when you stood up for someone else.----", "----Think of a time when you did something really difficult.----", "----Think of a time when you helped someone in need.----", "----Think of a time when you did something truly selfless.----"};
    protected List<string> _questions = new List<string>{"> Why was this experience meaningful to you?", "> Have you ever done anything like this before?", "> How did you get started?", "> How did you feel when it was complete?", "> What made this time different than other times when you were not as successful?", "> What is your favorite thing about this experience?", "> What could you learn from this experience that applies to other situations?", "> What did you learn about yourself through this experience?", "> How can you keep this experience in mind in the future?"};

    public ReflectingActivity() 
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have show strength and resilience. This will help you recognize the power of you have and how can use it in other aspects of your life.";
    }

    public void Run()
    {
        Console.Clear();

        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get  ready...");

        ShowSpinner(2);

        Console.Clear();

        Console.WriteLine("Consider the following prompt:\n");

        DisplayPrompt();

        Console.WriteLine("\nWhen you have some thing in your mind, press ENTER to continue.");
        Console.ReadLine();

        Console.WriteLine("Now Ponder on each of  the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DisplayQuestions();
        DisplayQuestions();
        
        Console.Clear();

        Console.WriteLine("Well Done");
        ShowSpinner(2);

        DisplayEndingMessage();
        ShowSpinner(4);

        Console.Clear();

    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomItem = _prompts[randomIndex];
        return randomItem;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string randomItem = _questions[randomIndex];
        return randomItem;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
        ShowSpinner(_duration);
    }
}