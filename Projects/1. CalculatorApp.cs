using System;

namespace ConsoleApp1.Projects
{
    public class CalculatorApp
    {
        void calculatorApp_Main()
        {
            Console.WriteLine("Welcome to the Console Calculator!");
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\nEnter the first number:");
                double num1 = GetValidNumber();

                Console.WriteLine("Enter the operator (+, -, *, /):");
                string operation = GetValidOperator();

                Console.WriteLine("Enter the second number:");
                double num2 = GetValidNumber();

                double result = PerformCalculation(num1, num2, operation);
                Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");

                Console.WriteLine("\nDo you want to perform another calculation? (yes/no):");
                string continueResponse = Console.ReadLine()?.Trim().ToLower();
                keepRunning = continueResponse == "yes";
            }

            Console.WriteLine("Thank you for using the Console Calculator. Goodbye!");
        }

        static double GetValidNumber()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }
            }
        }

        static string GetValidOperator()
        {
            while (true)
            {
                string operation = Console.ReadLine()?.Trim();
                if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                {
                    return operation;
                }
                else
                {
                    Console.WriteLine("Invalid operator. Please enter one of the following: +, -, *, /");
                }
            }
        }

        static double PerformCalculation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero.");
                default:
                    throw new InvalidOperationException("Unexpected operator.");
            }
        }
    }
}
