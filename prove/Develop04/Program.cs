using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        string answer = "";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listening activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (answer == "2")
            {
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (answer == "3")
            {
                Console.Clear();
                ListeningActivity listening = new ListeningActivity();
                listening.Run();
            }
            else if (answer == "4")
            {
                Console.WriteLine("Good bye!");
            }
            else
            {
                Console.WriteLine("Try a valide answer");
            }
        } while (answer != "4" );
    }
} 