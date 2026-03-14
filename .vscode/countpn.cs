using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[8];
        int positiveCount = 0, negativeCount = 0;

        Console.WriteLine("Enter 8 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        foreach (int num in numbers)
        {
            if (num > 0)
                positiveCount++;
            else if (num < 0)
                negativeCount++;
        }

        Console.WriteLine($"Positive numbers: {positiveCount}");
        Console.WriteLine($"Negative numbers: {negativeCount}");
    }
}

