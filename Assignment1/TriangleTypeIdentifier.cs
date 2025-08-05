class TriangleTypeIdentifier
{ 
    static void Main()
    {
        Console.Write("Enter side 1: ");
        string? input1 = Console.ReadLine();
        int side1 = int.TryParse(input1, out int s1) ? s1 : throw new ArgumentException("Input cannot be null or non-numeric.");

        Console.Write("Enter side 2: ");
        string? input2 = Console.ReadLine();
        int side2 = int.TryParse(input2, out int s2) ? s2 : throw new ArgumentException("Input cannot be null or non-numeric.");

        Console.Write("Enter side 3: ");
        string? input3 = Console.ReadLine();
        int side3 = int.TryParse(input3, out int s3) ? s3 : throw new ArgumentException("Input cannot be null or non-numeric.");

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Triangle Type: Equilateral");
        else if (side1 == side2 || side2 == side3 || side1 == side3)
            Console.WriteLine("Triangle Type: Isosceles");
        else
            Console.WriteLine("Triangle Type: Scalene");
    }
}
