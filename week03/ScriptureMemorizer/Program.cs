using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    static void Main(string[] args){
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        while (!scripture.AllWordsHidden()){
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); 
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden. Good Job");
    }
}
