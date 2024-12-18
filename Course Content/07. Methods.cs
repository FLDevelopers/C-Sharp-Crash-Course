using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class Methods
    {
        void methods_Main()
        {
            // Methods

            //Basic Methods
            void SayHello()
            {
                Console.WriteLine("Hello!");
            }

            // Method with return type
            int GetAge()
            {
                return 25;
            }

            // Calling Methods
            SayHello();
            int age = GetAge();
            Console.WriteLine(age);



            //Return Types
            // Different return types
            int CalculateAge()
            {
                return 2024 - 1995;
            }

            string GetFullName()
            {
                return "John Doe";
            }

            bool IsAdult()
            {
                return 29 >= 18;
            }

            // Calling Methods
            int get_age = CalculateAge();
            string get_name = GetFullName();
            bool is_adult = IsAdult();
            Console.WriteLine(get_age);
            Console.WriteLine(get_name);
            Console.WriteLine(is_adult);



            //Parameters & Arguments
            // Method with parameters
            void Greet(string name)
            {
                Console.WriteLine($"Hello, {name}!");
            }

            int Add(int a, int b)
            {
                return a + b;
            }

            // Calling Methods
            Greet("John");
            int sum = Add(14, 14);
            Console.WriteLine(sum);



            // Calling Overloaded Methods
            int sum1 = AddValue(17, 18);
            double sum2 = AddValue(9.3, 5.5);
            string text = AddValue("Hello ", "World");
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(text);



            // Optional Parameters
            void DisplayMessage(string message, string prefix = "Info", bool addTimestamp = false)
            {
                if (addTimestamp)
                {
                    Console.WriteLine($"{prefix}: {message} on [{DateTime.Now.Year}]");
                }
                else
                {
                    Console.WriteLine($"{prefix}: {message}");
                }
            }

            // Different ways to call optional parameters
            DisplayMessage("Hello");                 // Uses defaults
            DisplayMessage("Warning!", "Alert");     // Custom prefix
            DisplayMessage("Error", "Error", true);  // All parameters



            // Named Parameters
            void CreateUser(string name, int user_age, string email)
            {
                Console.WriteLine($"Created user: {name}, {user_age}, {email}");
            }

            // Using named arguments
            CreateUser(
                name: "John",
                user_age: 25,
                email: "john@email.com"
            );

            // Can be in any order
            CreateUser(
                email: "jane@email.com",
                name: "Jane",
                user_age: 30
            );
        }

        // Method Overloading
        static int AddValue(int a, int b)
        {
            return a + b;
        }

        static double AddValue(double a, double b)
        {
            return a + b;
        }

        static string AddValue(string a, string b)
        {
            return a + b;
        }
    }
}
