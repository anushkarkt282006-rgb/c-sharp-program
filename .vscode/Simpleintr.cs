using System;

class SimpleInterest
{
    static void Main()
    {
        Console.Write("Enter Principal Amount: ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Rate of Interest (%): ");
        double rate = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Time Period (Years): ");
        double years = double.Parse(Console.ReadLine());
        
        double simpleInterest = (principal * rate * years) / 100;
        double totalAmount = principal + simpleInterest;
        
        Console.WriteLine("\n--- Simple Interest Calculation ---");
        Console.WriteLine($"Principal: ${principal}");
        Console.WriteLine($"Rate: {rate}% per annum");
        Console.WriteLine($"Time: {years} years");
        Console.WriteLine($"Simple Interest: ${simpleInterest}");
        Console.WriteLine($"Total Amount: ${totalAmount}");
    }
}