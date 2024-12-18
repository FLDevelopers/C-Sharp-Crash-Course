using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Projects
{
    public class TodoApp
    {
        private static List<Task> tasks = new List<Task>();
        //DON'T FORGET TO CHANGE THIS FILE PATH
        private static readonly string filePath = "H:\\Youtube\\C# Crash Course\\ConsoleApp1\\tasks.txt"; 

        void todoApp_Main()
        {
            LoadTasks();
            Console.WriteLine("Welcome to the Todo List Application!");

            while (true)
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Remove");
                Console.WriteLine("3. List");
                Console.WriteLine("4. Complete");
                Console.WriteLine("5. Save");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        RemoveTask();
                        break;
                    case "3":
                        ListTasks();
                        break;
                    case "4":
                        MarkTaskComplete();
                        break;
                    case "5":
                        SaveTasks();
                        break;
                    case "6":
                        SaveTasks();
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        private static void AddTask()
        {
            Console.Write("Enter the task description: ");
            string description = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(description))
            {
                Console.WriteLine("Task description cannot be empty.");
                return;
            }

            tasks.Add(new Task { Description = description, IsComplete = false });
            Console.WriteLine("Task added.");
        }

        private static void RemoveTask()
        {
            ListTasks();
            Console.Write("Enter the task number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
            {
                tasks.RemoveAt(index - 1);
                Console.WriteLine("Task removed.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        private static void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("\nYour tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = tasks[i].IsComplete ? "[Completed]" : "[Pending]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i].Description}");
            }
        }

        private static void MarkTaskComplete()
        {
            ListTasks();
            Console.Write("Enter the task number to mark as complete: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
            {
                tasks[index - 1].IsComplete = true;
                Console.WriteLine("Task marked as complete.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        private static void SaveTasks()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var task in tasks)
                {
                    writer.WriteLine($"{task.Description}|{task.IsComplete}");
                }
            }
            Console.WriteLine("Tasks saved to file.");
        }

        private static void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 2 && bool.TryParse(parts[1], out bool isComplete))
                        {
                            tasks.Add(new Task { Description = parts[0], IsComplete = isComplete });
                        }
                    }
                }
            }
        }
    }

    class Task
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}
