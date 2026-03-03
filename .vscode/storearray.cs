using System;

class Program
{
    static void Main()
    {
        // Store 8 numbers in an array
        int[] numbers = { 5, -3, 8, -1, 0, 12, -7, 4 };
        
        int positiveCount = 0;
        int negativeCount = 0;
        
        // Loop to traverse the array
        for (int i = 0; i < numbers.Length; i++)
        {
            // Count positive and negative numbers
            if (numbers[i] > 0)
            {
                positiveCount++;
            }
            else if (numbers[i] < 0)
            {
                negativeCount++;
            }
        }
        
        // Display results
        Console.WriteLine("Positive numbers: " + positiveCount);
        Console.WriteLine("Negative numbers: " + negativeCount);
    }
}