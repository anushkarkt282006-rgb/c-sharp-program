using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers to sum (type 'done' to finish):");
        
        int sum = 0;
        
        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "done")
                break;
            
            if (int.TryParse(input, out int number))
            {
                sum += number;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        
        Console.WriteLine($"Sum of all numbers: {sum}");
    }
}