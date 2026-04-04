using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    private string name;
    private string description;
    private int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.WriteLine($"\nStarting {name} Activity");
        Console.WriteLine(description);
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);
        Run(duration);
        EndMessage();
    }

    protected abstract void Run(int duration);

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    private void EndMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed the {name} activity for {duration} seconds.");
        PauseWithAnimation(3);
    }
}




