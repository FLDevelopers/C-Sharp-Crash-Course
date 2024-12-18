using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class ConditionalStatements
    {
        void conditionalStatements_Main()
        {
            // Conditional Statements

            // If-else Statements
            int score = 85;

            if (score > 80)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (score <= 80 && score >= 60)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (score < 60 && score >= 45)
            {
                Console.WriteLine("Your grade is C");
            }
            else
            {
                Console.WriteLine("You need to study more");
            }

            // Switch Statements
            int dayNumber = 3;

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    break;
            }

            // Switch on Strings
            String Grades = "B";

            switch (Grades)
            {
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Great");
                    break;
                case "C":
                    Console.WriteLine("Good");
                    break;
                case "d":
                    Console.WriteLine("Study More");
                    break;
                default:
                    Console.WriteLine("Fail");
                    break;
            }

            // Ternary Operator 
            int age = 20;
            string message = age >= 18 ? "Adult" : "Minor";
            Console.WriteLine(message);

            age = 16;
            string new_message = age >= 18 ? "Adult" : "Minor";
            Console.WriteLine(new_message);

            int grade = 75;
            string result = grade >= 60 ? "Pass" : "Fail";
            Console.WriteLine(result);
        }
    }
}
