using System;

class Program
{
    static void Main(string[] args)
    {
        //Asking for a user's first and last names
        string firstName,lastName;

        
        Console.Write("What is your first name? ");
        firstName=Console.ReadLine();
        Console.Write("What is your last name? ");
        lastName=Console.ReadLine();

        
        Console.Write("Your name is {1}, {0} {1}",firstName,lastName);
        firstName=Console.ReadLine();
    }
}