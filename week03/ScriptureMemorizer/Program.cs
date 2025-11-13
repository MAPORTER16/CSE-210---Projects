using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the reference for Matthew 5:16
        Reference reference = new Reference("Matthew", 5, 16);
        
        // Create the scripture text
        string text = "Let your light so shine before men that they may see your good works and glorify your Father which is in heaven";
        
        // Create the Scripture object
        Scripture scripture = new Scripture(reference, text);
        
        // Main program loop
        string userInput = "";
        
        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            // Clear the console
            Console.Clear();
            
            // Display the scripture
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            
            // Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                break;  // Exit the loop
            }
            
            // Prompt the user
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            
            // If not quitting, hide more words
            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);  // Hide 3 words at a time
            }
        }
        
        // Final display if all hidden
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("All words are now hidden!");
        }
    }
}