class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly.") { }

    protected override void Run(int duration)
    {
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(3);
            elapsed += 3;
            if (elapsed >= duration) break;

            Console.WriteLine("Breathe out...");
            PauseWithAnimation(3);
            elapsed += 3;
        }
    }
}
