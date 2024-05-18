using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
    {
        _name = "Breathing Activity";
        _description = "This activity will help you  relax by walking  your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();


        Console.WriteLine("Get  ready...");

        ShowSpinner(2);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        do{
            Console.Write("Breathe in... ");
            ShowCountDown(5);

            for (int j = 0; j < 15; j++)
            {
                Console.Write("\b \b"); 
            }
            Console.Write("Breathe out... ");
            ShowCountDown(5);
            for (int j = 0; j < 16; j++)
            {
                Console.Write("\b \b"); 
            }
        } while (DateTime.Now < stopTime); 

        Console.WriteLine("Well Done");
        ShowSpinner(2);

        DisplayEndingMessage();
        ShowSpinner(4);

        Console.Clear();
    }
}