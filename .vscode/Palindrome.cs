using System;

class PalindromeChecker
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        
        if (IsPalindrome(input))
        {
            Console.WriteLine($"{input} is a Palindrome");
        }
        else
        {
            Console.WriteLine($"{input} is not a Palindrome");
        }
    }
    
    static bool IsPalindrome(string number)
    {
        string reversed = "";
        for (int i = number.Length - 1; i >= 0; i--)
        {
            reversed += number[i];
        }
        return number == reversed;
    }
}