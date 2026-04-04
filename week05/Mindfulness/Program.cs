// Creativity Enhancements I made:
// - Added richer sets of prompts/questions for variety.
// - Implemented countdown animations for pauses.
// - Listing activity tracks and displays number of items entered.
// - Used inheritance with a base Activity class to avoid duplication.
// - Built a user-friendly menu system for multiple activities in one session.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
       while (true)
        {
            Console.WriteLine("\nMindfulness App Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (activity == null) break;
            activity.Start();
        }
    }
}