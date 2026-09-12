using System;

class Program3
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = Multiply(num1, num2);

        Console.WriteLine($"Result: {result}");
    }

    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }
}