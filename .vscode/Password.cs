using System;

class PasswordValidator
{
    static void Main()
    {
        string password;
        bool isValid;

        do
        {
            Console.Write("Enter a password: ");
            password = Console.ReadLine();
            isValid = ValidatePassword(password);

            if (!isValid)
            {
                Console.WriteLine("Password does not meet requirements. Try again.\n");
            }
        } while (!isValid);

        Console.WriteLine("Password accepted!");
    }

    static bool ValidatePassword(string password)
    {
        // Rule 1: Minimum length of 8 characters
        if (password.Length < 8)
        {
            Console.WriteLine("- Must be at least 8 characters long");
            return false;
        }

        // Rule 2: Contains at least one uppercase letter
        bool hasUppercase = false;
        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUppercase = true;
                break;
            }
        }
        if (!hasUppercase)
        {
            Console.WriteLine("- Must contain at least one uppercase letter");
        }

        // Rule 3: Contains at least one digit
        bool hasDigit = false;
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                hasDigit = true;
                break;
            }
        }
        if (!hasDigit)
        {
            Console.WriteLine("- Must contain at least one digit");
        }

        // Rule 4: Contains at least one special character
        bool hasSpecialChar = false;
        string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";
        foreach (char c in password)
        {
            if (specialChars.Contains(c))
            {
                hasSpecialChar = true;
                break;
            }
        }
        if (!hasSpecialChar)
        {
            Console.WriteLine("- Must contain at least one special character (!@#$%^&* etc.)");
        }

        return hasUppercase && hasDigit && hasSpecialChar;
    }
}