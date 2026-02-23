using System;

class Application
{
    static void Main()
    {
        string validUsername = "admin";
        string validPassword = "password123";
        int maxAttempts = 3;
        int attempts = 0;
        bool isLoggedIn = false;

        Console.WriteLine("=== Login System ===\n");

        while (attempts < maxAttempts && !isLoggedIn)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == validUsername && password == validPassword)
            {
                isLoggedIn = true;
                Console.WriteLine("\n✓ Login successful! Welcome, " + username + "\n");
            }
            else
            {
                attempts++;
                int remainingAttempts = maxAttempts - attempts;

                if (remainingAttempts > 0)
                {
                    Console.WriteLine("✗ Invalid credentials. Attempts remaining: " + remainingAttempts + "\n");
                }
                else
                {
                    Console.WriteLine("✗ Maximum login attempts exceeded. Access denied.\n");
                }
            }
        }

        if (isLoggedIn)
        {
            Console.WriteLine("You are now logged in. Perform your tasks here.");
            Console.ReadKey();
        }
    }
}