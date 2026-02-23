using System;

class PrimeProgram
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int start = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int end = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"\nPrime numbers between {start} and {end}:");
        
        for (int num = start; num <= end; num++)
        {
            if (IsPrime(num))
            {
                Console.WriteLine(num);
            }
        }
    }
    
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;
        
        if (number == 2)
            return true;
        
        if (number % 2 == 0)
            return false;
        
        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }
        
        return true;
    }
}