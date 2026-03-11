using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        string letter;

        // Core requirement: determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch challenge: determine + or - sign
        string sign = "";
        int lastDigit = grade % 10;

        if (letter != "F") // F never has + or -
        {
            if (letter == "A")
            {
                // No A+, only A or A-
                if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
            else
            {
                if (lastDigit >= 7)
                {
                    sign = "+";
                }
                else if (lastDigit < 3)
                {
                    sign = "-";
                }
            }
        }

        // Print the final grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Passing check
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying—you’ll get it next time!");
        }
    }
}