using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        

        string answer = "1";
        Journal journal = new Journal();

        while (answer != "5")
        {
            Console.WriteLine("Please Select One of the Following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            answer = Console.ReadLine();

            PromptGenerator pg = new PromptGenerator();
            string prompt = pg.GetRandomPrompt();
            
            if (answer == "1") 
            {
                Entry e = new Entry();
                e._promptText = prompt;
                Console.WriteLine(prompt);

                Console.Write(">");
                string entry = Console.ReadLine();

                DateTime currentdate = DateTime.Now;
                string date = currentdate.ToShortDateString();
                e._date = date;

                e._entryText = entry;   
                string newEntry = date + prompt + entry;
                journal.AddEntry(e);
            }
            else if( answer == "2")
            {
                journal.DisplayAll();
            }
            else if ( answer == "3")
            {
                Console.Write("File Name:");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine($"Entries Loaded");
            }

            else if ( answer == "4")
            {
                Console.Write("File Name:");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine($"Entries saved to {fileName}");
            }

        }
            
    }
}