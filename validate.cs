using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2;
        char op;

        Console.WriteLine("Enter first number:");
        while (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }

        Console.WriteLine("Enter operator:");
        while (!char.TryParse(Console.ReadLine(), out op) || (op != '+' && op != '-' && op != '*' && op != '/'))
        {
            Console.WriteLine("Invalid input. Please enter a valid operator (+, -, *, /):");
        }

        Console.WriteLine("Enter second number:");
        while (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }
        
        if(op == '/' && num2 ==0)
        {
            Console.WriteLine("Error: Divide by zero exception!");
            Console.ReadLine();
            return;
        }
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
