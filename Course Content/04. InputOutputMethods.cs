using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class InputOutputMethods
    {
        void inputOutputMethods_Main()
        {
            // Write Line Method
            Console.WriteLine("Hello, World!");

            // Basic printing

            // Printing variables
            string name = "John";
            int age = 25;
            Console.WriteLine(name);
            Console.WriteLine(age);

            // Write vs WriteLine
            Console.Write("This stays ");    // No new line
            Console.Write("on the same line");

            // Print empty line
            Console.WriteLine();             // Prints blank line for spacing
            Console.WriteLine("This is ");
            Console.WriteLine();             // Prints blank line for spacing
            Console.WriteLine("empty write line method.");

            // Read Line Method
            Console.WriteLine("\nBasic Input\n");

            // Basic input
            Console.Write("What's your name? ");
            string userName = Console.ReadLine();

            // Getting numbers requires conversion
            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            // Safer way to get numbers
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"You entered: {number}");
            }
            else
            {
                Console.WriteLine("That's not a valid number!");
            }

            // String Formatting
            Console.WriteLine("\nString Formatting\n");

            string username = "Alice";
            int user_age = 30;
            double height = 5.6;

            // Basic formatting
            Console.WriteLine("Name: {0}, Age: {1}", username, user_age);

            // Multiple placeholders
            Console.WriteLine("{0} is {1} years old and {2} feet tall", name, age, height);

            // Number formatting
            double price = 19.99;
            Console.WriteLine("Price: {0:C}", price);      // Currency: $19.99
            Console.WriteLine("Price: {0:F1}", price);     // One decimal: 20.0

            // String Interpolation
            Console.WriteLine("\nString Interpolation\n");

            string person_name = "Bob";
            int person_age = 25;
            double salary = 50000.50;

            // Basic interpolation
            Console.WriteLine($"Hello, {person_name}!");

            // Expressions inside interpolation
            Console.WriteLine($"In 5 years, you'll be {person_age + 5} years old");

            // Formatting with interpolation
            Console.WriteLine($"Salary: {salary:C}");          // Currency format
            Console.WriteLine($"Salary: {salary:F2}");         // Two decimal places

            // Combining multiple values
            Console.WriteLine($"{person_name} is {person_age} years old and earns {salary:C} per year");
        }
    }
}
