class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
            return;
        }

        int age = int.Parse(input);
        if (age < 0)
        {
            Console.WriteLine("Invalid age. Age cannot be negative.");
            return;
        }
        if (age <= 12 || age >= 65)
            Console.WriteLine("Ticket Price: GHC7");
        else
            Console.WriteLine("Ticket Price: GHC10");
    }
}
