using System;

class CompoundInterest
{
    static void Main()
    {
        Console.WriteLine("=== Compound Interest Calculator ===");
        
        Console.Write("Enter Principal Amount: ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Rate of Interest (% per annum): ");
        double rate = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Time Period (in years): ");
        int time = int.Parse(Console.ReadLine());
        
        double amount = principal * Math.Pow(1 + rate / 100, time);
        double compoundInterest = amount - principal;
        
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine($"Principal: {principal}");
        Console.WriteLine($"Rate: {rate}%");
        Console.WriteLine($"Time: {time} years");
        Console.WriteLine($"Amount: {amount:F2}");
        Console.WriteLine($"Compound Interest: {compoundInterest:F2}");
    }
}