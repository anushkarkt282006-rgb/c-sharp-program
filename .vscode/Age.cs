using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 12)
        {
            Console.WriteLine("You are kid");
        }
        else if (age >= 12 && age <= 17)
        {
            Console.WriteLine("You are teenager");
        }
        else if (age >= 18 && age <= 60)
        {
            Console.WriteLine("You are an adult");
        }
        else if (age > 60)
        {
            Console.WriteLine("You are a senior citizen");
        }
    }
}