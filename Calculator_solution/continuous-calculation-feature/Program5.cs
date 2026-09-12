bool continueCalculating = true;

while (continueCalculating)
{
    // ... do a calculation ...

    Console.Write("Do you want to perform another calculation? (y/n): ");
    string? answer = Console.ReadLine();
    continueCalculating = answer != null && answer.ToLower() == "y";
}

Console.WriteLine("Goodbye!");