using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice !=5)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"Prompt: {newEntry._promptText}");
                Console.Write("Your response: ");
                newEntry._entryText = Console.ReadLine();

                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added successfully!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("\nAll Journal Entries:");
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (choice == 5)
            {
                Console.WriteLine("GoodBye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        
        }
    }
}