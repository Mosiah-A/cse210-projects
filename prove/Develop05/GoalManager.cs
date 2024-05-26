using System.Data;
using System.Threading;
using System.IO;
using System.Drawing;

public class GoalManager
{
    // attributes
    private List<Goal> goals = new List<Goal>();
    private int _score = 0;
    private string _rank = "";

    // constructors - initializing the attributes

    public void Start()
    {
        string choice = "";
        do
        {

            
            if (_score <= 50)
            {
                _rank = "Wood";
            }
            else if (_score <= 100)
            {
                _rank = "Iron";
            }
            else if (_score <= 200)
            {
                _rank = "Bronze";
            }
            else if (_score <= 500)
            {
                _rank = "Silver";
            }
            else if (_score <= 1000)
            {
                _rank = "Gold";
            }
            else
            {
                _rank = "Platinum";
            }

            //display main menu & display player info
            DisplayPlayerIngo();
            Console.WriteLine("Menu Option:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            //call:
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            // creategoal, listgoaldetails,savegoals,loadgoals
            if(choice == "1")
            {
                Console.Clear();
                CreateGoal();
            }
            else if(choice == "2")
            {
                Console.Clear();
                ListGoalDetails();
            }
            else if(choice == "3")
            {
                Console.Clear();
                SaveGoals();
            }
            else if(choice == "4")
            {
                Console.Clear();
                LoadGoals();
            }

            // recordevent
            
            else if(choice == "5")
            {
                Console.Clear();
                RecordEvent();
            }
            else if(choice == "6")
            {
                Console.WriteLine("Good bye! :3");
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Type a valid answere!");
                Thread.Sleep(1000);
                Console.Clear();

            }
            // loop until quit
        }while (choice != "6");
    }

    public void DisplayPlayerIngo()
    {
        //Display the points
        Console.WriteLine($"---------------------------------------");
        Console.WriteLine($"-Your score: {_score}- \n-you are : {_rank}-");
        Console.WriteLine($"---------------------------------------");
    }

    public void ListGoalNames()
    {
        // loop throgh the list of goals and display
        //the names (you may need another function
        // in the goal class!)
        int n = 0;
        foreach ( Goal goal in  goals)
        {
            n = n+1;
            Console.WriteLine($"{n}. {goal.GetNameDetail()} ({goal})");
        }
    }

    public void ListGoalDetails()
    {
        // loop through the list of goals and display 
        // the full details
        foreach ( Goal goal in  goals)
        {
            
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal()
    {
        //display a sub-menu to select a goal type
        // ask for the name, description, and points
        // ask for more if they pick checklist goal
        //create the object and add to the goal list
        do
        {
            Console.WriteLine("The type of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                Console.Write("What is the name of Goal? ");
                string name = Console.ReadLine();
            
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                goals.Add(simpleGoal);
                    
                Thread.Sleep(1000);
                Console.Clear();
                break;
            }
            else if (choice == "2")
            {
                Console.Write("What is the name of Goal? ");
                string name = Console.ReadLine();
            
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                goals.Add(eternalGoal);
                    
                Thread.Sleep(1000);
                Console.Clear();
                break;
            }
            else if (choice == "3")
            {
                Console.Write("What is the name of Goal? ");
                string name = Console.ReadLine();
            
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                Console.Write("How many time does this goal need to be accomplished for bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                goals.Add(checklistGoal);
                    
                Thread.Sleep(1000);
                Console.Clear();
                break;
            }
            else{
                Console.WriteLine("Type a valide answere!");
                    
                Thread.Sleep(1000);
                Console.Clear();
            }
        } while (true);
        
    }

    public void RecordEvent()
    {
        // displey a list of all of the goal names
        // ask user to select a goal
        // call recordevent on the correct
        // update the score based on the points
        //display current points
        ListGoalNames();
        Console.Write("Choice the goal: ");
        int choice = int.Parse(Console.ReadLine());
        int pointreceived = goals[choice-1].RecordEvent();
        _score = _score + pointreceived;
    
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine($"Congratulation you earn {pointreceived} Points!");
        Console.WriteLine($" Your score is: {_score}");

        Thread.Sleep(4000);
        Console.Clear();
    }

    public void SaveGoals()
    {
        // ask user for a file name
        //loop through the goals and convert each
        // goal to a string and then save the string.
        
        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_score);            
            // You can use the $ and include variables just like with Console.WriteLine
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.Savestring());
            }
        }
    }

    public void LoadGoals()
    {

    }
}