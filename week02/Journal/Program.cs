using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        //Entry entry = new Entry("2026","Hello","Koko");
        PromptGenerator generator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");
    }
}