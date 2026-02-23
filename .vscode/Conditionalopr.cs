using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        int minimum = (num1 < num2) ? ((num1 < num3) ? num1 : num3) : ((num2 < num3) ? num2 : num3);

        Console.WriteLine($"Minimum number is: {minimum}");
    }
}