using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool running = true;
        
        while (running)
        {
            Thread.Sleep(1000);
            //Display Menu
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulnes Program");
            Thread.Sleep(1000);
            Console.WriteLine("=== LOADING ===");
            Thread.Sleep(1000);
            Console.WriteLine("Menu Options");
            Thread.Sleep(1000);
            Console.WriteLine(" 1. Breathing Activity");
            Thread.Sleep(1000);
            Console.WriteLine(" 2. Reflection ACtivity");
            Thread.Sleep(1000);
            Console.WriteLine(" 3. Listing Activity");
            Thread.Sleep(1000);
            Console.WriteLine(" 4.Quit");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Select a choice from the menu");

            //Get user input
            string choice = Console.ReadLine();

            //Process the choice

             if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }
    }
}