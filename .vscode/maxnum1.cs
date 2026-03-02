using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxNumber = numbers[0];
        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > maxNumber)
                maxNumber = numbers[i];
        }



        Console.WriteLine($"Maximum number: {maxNumber}");
    }
}
