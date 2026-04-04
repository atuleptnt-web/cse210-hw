class ListingActivity : Activity
{
    private static readonly string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing",
        "This activity will help you reflect on the good things in your life by listing items.") { }

    protected override void Run(int duration)
    {
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Console.WriteLine("You will have a few seconds to think...");
        PauseWithAnimation(3);

        Console.WriteLine("Start listing items (press Enter after each):");
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                    items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
    }
}
