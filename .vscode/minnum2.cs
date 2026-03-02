using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }
        
        int min_number = numbers.Min();
        Console.WriteLine($"The minimum number is: {min_number}");
    }
}
