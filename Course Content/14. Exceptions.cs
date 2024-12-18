using System;
using System.IO;

namespace ConsoleApp1.Course_Content
{
    public class Exceptions
    {
        static void exceptionsMain(string[] args)
        {
            // Try Catch Block
            string message = "Hello!";

            try
            {
                int number = int.Parse(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid format error: {ex.Message}");
            }

            // Multiple Catch Blocks
            int[] numbers = { 1, 2, 3 };
            try
            {
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: Array index out of bounds. {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            // Finally Block
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("example.txt");
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    Console.WriteLine("Stream closed.");
                }
            }

            // Throwing Exception
            try
            {
                CheckAge(15);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Custom Exception
            try
            {
                customAgeException(16);
            }
            catch (AgeException ex)
            {
                Console.WriteLine($"Custom Exception: {ex.Message}");
            }
        }

        // Throwing Exception
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("Age must be at least 18.");
            }
            else
            {
                Console.WriteLine("Age is valid.");
            }
        }

        // Custom Exception
        public class AgeException : Exception
        {
            public AgeException(string message) : base(message) { }
        }

        static void customAgeException(int age)
        {
            if (age < 18)
            {
                throw new AgeException("Age must be at least 18.");
            }
            else
            {
                Console.WriteLine("Age is valid.");
            }
        }
    }
}
