class ReflectionActivity : Activity
{
    private static readonly string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base("Reflection",
        "This activity will help you reflect on times when you have shown strength and resilience.") { }

    protected override void Run(int duration)
    {
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine(questions[rand.Next(questions.Length)]);
            PauseWithAnimation(5);
            elapsed += 5;
        }
    }
}
