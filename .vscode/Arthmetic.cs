using System;

class Arithmetic
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char op = char.Parse(Console.ReadLine());

        double result = 0;
        bool validOp = true;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero!");
                    validOp = false;
                }
                break;
            default:
                Console.WriteLine("Invalid operator!");
                validOp = false;
                break;
        }

        if (validOp)
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
}