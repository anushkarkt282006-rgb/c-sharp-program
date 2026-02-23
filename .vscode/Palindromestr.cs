using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it's a palindrome:");
        string input = Console.ReadLine();
        
        if (IsPalindrome(input))
        {
            Console.WriteLine($"\"{input}\" is a palindrome.");
        }
        else
        {
            Console.WriteLine($"\"{input}\" is not a palindrome.");
        }
    }
    
    static bool IsPalindrome(string str)
    {
        string cleaned = str.Replace(" ", "").ToLower();
        int left = 0;
        int right = cleaned.Length - 1;
        
        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
                return false;
            left++;
            right--;
        }
        
        return true;
    }
}