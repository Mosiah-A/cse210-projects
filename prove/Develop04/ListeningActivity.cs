using System;
using System.Collections.Generic;


public class ListeningActivity : Activity
{
    protected int _count;
    protected List<string> _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListeningActivity()
    {
         _name = "Listening Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();


        Console.WriteLine("Get  ready...");

        ShowSpinner(2);

        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:\n");

        GetRandomPrompt();

        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);

        Console.Write("\n");
        
        GetListFromUser();
        
        Console.WriteLine("Well Done");
        ShowSpinner(2);

        DisplayEndingMessage();
        ShowSpinner(4);

        Console.Clear();
        
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomItem = _prompts[randomIndex];
        Console.WriteLine(randomItem);
    }
    public List<string> GetListFromUser()
    {
        List<string> _userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        do
        {
            Console.Write("> ");
            string newItem = Console.ReadLine();
            _userList.Add(newItem);
        }while (DateTime.Now < stopTime);
        Console.WriteLine($"You listed {_userList.Count} items!\n");

        return _userList;
    }
}