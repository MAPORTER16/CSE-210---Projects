using System.Runtime.CompilerServices;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I met today?",
        "How did I show kindess today?",
        "How did I show show patience?",
        "What was the strongest emotion I felt tody?",
        "If I had one thing I could do over today, what would it be?",
        "How did I overcome a struggle today?",
        "What are some words of wisdom to tell your future self?",
        "What is one habit I'd like to change and why?",
        "Where do I want to be in 6 months?",
        "Who in your life deserves appreciation right now"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}