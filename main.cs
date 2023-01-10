using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2;
        char op;

        Console.WriteLine("Enter first number:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operator:");
        op = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine(num1 + num2);
                break;
            case '-':
                Console.WriteLine(num1 - num2);
                break;
            case '*':
                Console.WriteLine(num1 * num2);
                break;
            case '/':
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("Invalid operator");
                break;
        }

        Console.ReadLine();
    }
}
