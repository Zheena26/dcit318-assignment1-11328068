class GradeCalculator{
    static void Main()
  {
        Console.Write("Enter numerical grade (0 - 100): ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int grade))
       {
            if (grade >= 90)
                Console.WriteLine("Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer between 0 and 100.");
        }
    }
}
