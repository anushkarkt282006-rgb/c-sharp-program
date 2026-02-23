using System;

class ElectricityBillCalculator
{
    static void Main()
    {
        Console.Write("Enter units consumed: ");
        int units = int.Parse(Console.ReadLine());
        
        double billAmount = CalculateBill(units);
        double finalBill = billAmount;
        
        if (billAmount > 500)
        {
            double gst = billAmount * 0.18;
            finalBill = billAmount + gst;
            Console.WriteLine($"\nBill Amount: Rs {billAmount:F2}");
            Console.WriteLine($"GST (18%): Rs {gst:F2}");
        }
        else
        {
            Console.WriteLine($"\nBill Amount: Rs {billAmount:F2}");
            Console.WriteLine("GST: Not applicable");
        }
        
        Console.WriteLine($"Final Bill: Rs {finalBill:F2}");
    }
    
    static double CalculateBill(int units)
    {
        double bill = 50; // Fixed meter charge
        
        if (units <= 100)
        {
            bill += units * 1.5;
        }
        else if (units <= 200)
        {
            bill += (100 * 1.5) + ((units - 100) * 2.5);
        }
        else
        {
            bill += (100 * 1.5) + (100 * 2.5) + ((units - 200) * 4);
        }
        
        return bill;
    }
}