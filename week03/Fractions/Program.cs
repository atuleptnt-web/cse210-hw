using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World. THis is the Fraction program");
        
        // Using the no-parameter constructor
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction: {f1.GetFractionString()}, Decimal: {f1.GetDecimalValue()}");

        // Using the one-parameter constructor
        Fraction f2 = new Fraction(6);
        Console.WriteLine($"Fraction: {f2.GetFractionString()}, Decimal: {f2.GetDecimalValue()}");

        // Using the two-parameter constructor
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine($"Fraction: {f3.GetFractionString()}, Decimal: {f3.GetDecimalValue()}");

        // Testing setters and getters
        f3.SetNumerator(3);
        f3.SetDenominator(4);
        Console.WriteLine($"Updated Fraction: {f3.GetFractionString()}, Decimal: {f3.GetDecimalValue()}");

        // Another example
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction: {f4.GetFractionString()}, Decimal: {f4.GetDecimalValue()}");
    }
}