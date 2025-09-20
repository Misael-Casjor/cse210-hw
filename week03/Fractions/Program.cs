using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetTop());
        fraction.SetTop(5);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetTop());
        fraction.SetTop(3);
        fraction.SetBottom(4);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
        fraction.SetTop(1);
        fraction.SetBottom(3);
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());


    }
}