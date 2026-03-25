using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        // Create references
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);
        Reference ref2 = new Reference("John", 3, 16);

        // Create scriptures
        Scripture s1 = new Scripture(ref1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        Scripture s2 = new Scripture(ref2, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        // Create a collection and add scriptures
        ScriptureCollection collection = new ScriptureCollection();
        collection.AddScripture(s1);
        collection.AddScripture(s2);

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Type 'quit' to exit at any time.\n");

        // Pick a random scripture to practice
        Scripture current = collection.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(current.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            current.HideRandomWords(3); // hide 3 words at a time

            if (current.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(current.GetDisplayText());
                Console.WriteLine("\nAll words are hidden! Great job!");
                break;
            }
        }

        Console.WriteLine("\nProgram ended. Goodbye!");
    }
}