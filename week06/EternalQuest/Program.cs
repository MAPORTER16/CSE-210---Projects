using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string choice = "";

        while (choice != "6")
        {
            manager.DisplayScore();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                manager.ListGoals();
            }
            else if (choice == "3")
            {
                manager.SaveGoals();
            }
            else if (choice == "4")
            {
                manager.LoadGoals();
            }
            else if (choice == "5")
            {
                manager.RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}