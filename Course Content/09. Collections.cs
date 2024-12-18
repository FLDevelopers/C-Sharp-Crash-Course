using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class Collections
    {
        void collections_Main()
        {
            //Collections
            // Lists

            // Creating a List of strings
            List<string> students = new List<string>();

            // Adding data on initialization
            List<string> studentNames = new List<string>()
            {
                "John",
                "Doe",
                "Alex",
            };

            // Adding element to list
            studentNames.Add("Harry");

            // Adding element at specific location
            studentNames.Insert(0, "Sarah");

            // Fetching data using index
            Console.WriteLine(studentNames[0]);

            // Fetching data using foreach loop
            foreach (string studentName in studentNames)
            {
                Console.WriteLine($"Foreach loop: {studentName}");
            }

            // Fetching data using for loop
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine($"For loop: {studentNames[i]}");
            }

            // Delete an element from list
            studentNames.Remove("Doe");

            // Delete an element from specific location
            studentNames.RemoveAt(1);

            // Printing updated list
            foreach (string studentName in studentNames)
            {
                Console.WriteLine($"Updated item: {studentName}");
            }

            // Searching in the list
            bool hasMike = studentNames.Contains("Mike");

            // Get index of an element
            int alexPosition = studentNames.IndexOf("Alex");

            Console.WriteLine(hasMike);
            Console.WriteLine(alexPosition);


            // Dictionaries

            // Creating dictionary
            Dictionary<int, string> studentsDictionary = new Dictionary<int, string>();

            // Add Data on initialization
            Dictionary<int, string> studentDirectory = new Dictionary<int, string>()
            {
                { 1 , "John" },
                { 2 , "Doe" },
                { 3 , "Alex" }
            };

            // Add data using "Add" method
            studentDirectory.Add(4, "Sarah");
            studentDirectory.Add(5, "Harry");

            // Updating values
            studentDirectory[5] = "Harry got replaced.";

            // It creates new key-value pair if key does not exists.
            studentDirectory[6] = "John Smith";

            // Accessing values
            string student1 = studentDirectory[1];
            Console.WriteLine(student1);

            // Safer way to access values
            if (studentDirectory.TryGetValue(2, out string studentsName))
            {
                Console.WriteLine($"Found student: {studentsName}");
            }
            else
            {
                Console.WriteLine("Student not found");
            }

            // Get all key-value pairs
            foreach (var student in studentDirectory)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }

            // Removing entries
            studentDirectory.Remove(6);

            // Printing updated dictionary
            foreach (var student in studentDirectory)
            {
                Console.WriteLine($"New ID: {student.Key}, Name: {student.Value}");
            }

            // Getting all keys or values
            List<int> allKeys = studentDirectory.Keys.ToList();
            List<string> allValues = studentDirectory.Values.ToList();

            // Print keys and values
            foreach (var key in allKeys)
            {
                Console.WriteLine($"{key} ");
            }
            foreach (var value in allValues)
            {
                Console.WriteLine($"{value} ");
            }

            // HashSets

            // Creating a HashSet
            HashSet<string> courses = new HashSet<string>();

            // Add Data on initialization
            HashSet<string> uniqueCourses = new HashSet<string>()
            {
                "English",
                "Math",
                "Biology",
                "Chemistry",
            };

            // Add items using "Add" method
            bool result = uniqueCourses.Add("Physics");
            Console.WriteLine(result);

            result = uniqueCourses.Add("English");
            Console.WriteLine(result);

            // foreach loop to access all elements
            foreach (var course in uniqueCourses)
            {
                Console.WriteLine($"Hashset item: {course}");
            }

            // Removing elements
            result = uniqueCourses.Remove("Biology");
            Console.WriteLine(result);

            //Operation

            HashSet<string> scienceCourses = new HashSet<string>()
            {
                "English",
                "Math",
                "Computer Science",
                "Programming",
                "Numerical Analysis"
            };

            // Set operations

            //Combine Sets
            uniqueCourses.UnionWith(scienceCourses);       // Combines both sets

            foreach (var course in uniqueCourses)
            {
                Console.WriteLine($"Combining Set: {course}");
            }

            // Intersect Sets
            uniqueCourses.IntersectWith(scienceCourses);   // Keeps only common elements

            foreach (var course in uniqueCourses)
            {
                Console.WriteLine($"Intersecting Set: {course}");
            }

            // Except with method
            uniqueCourses.ExceptWith(scienceCourses);      // Removes elements that exist in scienceCourses

            foreach (var course in uniqueCourses)
            {
                Console.WriteLine($"New Set Item: {course}");
            }
        }
    }
}
