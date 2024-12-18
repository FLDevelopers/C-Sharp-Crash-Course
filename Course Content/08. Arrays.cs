using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class Arrays
    {
        void arrays_Main()
        {
            // Arrays


            // Single Dimensional Array
            int[] numbers = { 6, 5, 4, 3, 2, 1 };   // A simple list of numbers
            Console.WriteLine(numbers[0]);          // Accessing the specific element

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Single Array (for loop): {numbers[i]}");
            }

            foreach (var num in numbers)             // Using foreach loop access all elements
            {
                Console.WriteLine($"Single Array (foreach loop): {num}");
            }

            //Multi-Dimensional Array

            // Declaring a 3x3 matrix
            int[,] matrix = new int[3, 3]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
            };

            // Short hand way to create arrays
            int[,] newMatrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
            };

            // Accessing spefic elements
            Console.WriteLine(matrix[0, 0]);
            Console.WriteLine(matrix[1, 2]);

            // Access all elements using foreach loop
            foreach (var num in matrix)
            {
                Console.WriteLine($"Elements of the matrix (foreach loop): {num}");
            }

            // Access all elements using nested for loop
            for (int i = 0; i < matrix.GetLength(0); i++) // Represents Rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Represents Columns
                {
                    Console.WriteLine($"Elements of the matrix (nested for loop): {matrix[i, j]}");
                }
            }

            // Array methods

            // Sort the array
            Array.Sort(numbers);

            Console.Write("Sorted Array: ");
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            // Reverse the array
            Array.Reverse(numbers);

            Console.Write("Reversed Array: ");
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            // IndexOf method to fetch specific number
            int index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Index of 3: " + index);
        }
    }
}
