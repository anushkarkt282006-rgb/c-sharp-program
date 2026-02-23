// See https://aka.ms/new-console-template for more information

Console.Write("Enter a number: ");
string input = Console.ReadLine();

bool IsPalindrome(string num)
{
    string reversed = new string(num.Reverse().ToArray());
    return num == reversed;
}

if (IsPalindrome(input))
{
    Console.WriteLine($"{input} is a palindrome.");
}
else
{
    Console.WriteLine($"{input} is not a palindrome.");
}

