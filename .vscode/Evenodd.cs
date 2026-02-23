using System;

class EvenOdd
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is Even");
        }
        else
        {
            Console.WriteLine($"{number} is Odd");
        }
    }
}