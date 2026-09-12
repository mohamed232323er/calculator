using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = Add(num1, num2);

        Console.WriteLine($"Result: {result}");
    }

    static double Add(double num1, double num2)
    {
        return num1 + num2;
    }
}