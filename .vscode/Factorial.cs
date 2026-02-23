using System;

class Factorial
{
    static int CalculateFactorial(int n)
    {
        if (n < 0)
            return -1;
        if (n == 0 || n == 1)
            return 1;
        return n * CalculateFactorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        int result = CalculateFactorial(number);
        
        if (result == -1)
            Console.WriteLine("Factorial is not defined for negative numbers");
        else
            Console.WriteLine($"Factorial of {number} is {result}");
    }
}