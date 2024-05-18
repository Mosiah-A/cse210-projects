using System;
using System.Threading;
using System.Collections.Generic;


public class Activity
{
    protected string _name, _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}.");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for  your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have complete another {_duration} seconds of the {_name}.");

    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>{"|", "/", "-", "\\", "|", "/", "-", "\\"};
        for (int i = seconds; i > 0; i--)
        {
            foreach( string item in animationString)
            {
                Console.Write(item);
                Console.Write("\b");
                Thread.Sleep(200); // Wait for 1 second
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds ; i >= 1 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}