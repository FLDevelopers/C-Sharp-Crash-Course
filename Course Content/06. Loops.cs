using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class Loops
    {
        void loops_Main()
        {
            // Loops

            // Basic for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Basic Count: {i}");
            }

            // Counting down
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Countdown: {i}");
            }

            // Stepping by different amounts
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            // For-each Loop
            int[] numbers = { 10, 20, 30, 40, 50 };
            // Using foreach loop to iterate through the array
            foreach (int num in numbers)
            {
                Console.WriteLine("Current number: " + num);
            }

            // While Loops
            // Basic while loop
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine($"While loop Count is: {count}");
                // increment
                count++;
            }

            // Do-While Loops
            int number = 0;
            do
            {
                Console.WriteLine($"Do-While loop Count is: {number}");
                // increment
                number++;
            } while (number < 5);

            //Difference Between While loop and Do-While Loop
            int score = 0;
            while (score < 0)
            {
                Console.WriteLine("While loop runs 0 or multiple times");
                score++;
            }

            do
            {
                Console.WriteLine("Do-While loop runs at least one time.");
                score++;
            } while (score < 0);

            // Break & Continue Statements
            // Break example - breaks the loop
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Reached to value 5.");
                    break;
                }
                Console.WriteLine(i);
            }

            // Continue example - skip to next iteration
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
