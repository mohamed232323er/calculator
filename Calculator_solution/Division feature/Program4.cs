using System;

class Program4
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double? result = Divide(num1, num2);

        if (result != null)
            Console.WriteLine($"Result: {result}");
    }

    static double? Divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return null;
        }
        return num1 / num2;
    }
}