using System;
using System.Linq;

namespace PalindromeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text or number: ");
            string input = Console.ReadLine() ?? string.Empty;

            bool isPalindrome = IsPalindrome(input);
            Console.WriteLine(isPalindrome ? "Palindrome" : "Not a palindrome");
        }

        // Returns true if the input is a palindrome ignoring case and non-alphanumeric characters.
        static bool IsPalindrome(string s)
        {
            string filtered = new string(s
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLowerInvariant)
                .ToArray());

            int left = 0, right = filtered.Length - 1;
            while (left < right)
            {
                if (filtered[left++] != filtered[right--]) return false;
            }
            return true;
        }
    }
}