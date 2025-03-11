using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fractionA = new Fraction ();
        Fraction fractionB = new Fraction (6);
        Fraction fractionC = new Fraction (6, 7);

        Check(fractionA);
        Check(fractionB);
        Check(fractionC);

        fractionA.SetTop(15);
        fractionA.SetBottom(5);
        Check(fractionA);

        

    }

    static void Check(Fraction fraction)
    {
        Console.WriteLine($"Top: {fraction.GetTop()}");
        Console.WriteLine($"Bottom: {fraction.GetBottom()}");
        Console.WriteLine($"String: {fraction.GetFractionString()}");
        Console.WriteLine($"Decimal: {fraction.GetDecimalValue()}");
        Console.WriteLine("");
    }
}