using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // Private attributes
    private Reference _reference;
    private List<Word> _words;
    
    // Constructor - takes reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        // Split text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    
    // Method to get the full display text
    public string GetDisplayText()
    {
        // Start with the reference
        string display = _reference.GetDisplayText() + " ";
        
        // Add each word's display text
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        
        return display.Trim();  // Remove extra space at end
    }
    
    // Method to hide random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        for (int i = 0; i < numberToHide; i++)
        {
            // Pick a random word index
            int index = random.Next(0, _words.Count);
            
            // Hide that word
            _words[index].Hide();
        }
    }
    
    // Method to check if all words are hidden
    public bool IsCompletelyHidden()
    {
        // Check each word
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;  // Found a visible word
            }
        }
        return true;  // All words are hidden
    }
}