using System;
using System.Linq;

namespace ConsoleApp1.Course_Content
{
    public class ClassesTypes
    {
        static void classesTypes_Main()
        {
            // Standard Class
            Cars car = new Cars { Make = "Toyota" };
            car.Drive();

            // Static Class
            StaticMessage.Message();

            // Abstract Classes
            Shapes shape = new Circles { Radius = 5 };
            Console.WriteLine(shape.Area());

            // Sealed Classes
            Logger logger = new Logger();
            logger.Log();

            // Partial Classes
            MyPartialClass obj = new MyPartialClass();
            obj.Method1();
            obj.Method2();

            // Nested Classes
            OuterClass.InnerClass inner = new OuterClass.InnerClass();
            inner.Display();

            // Anonymous Classes
            var person = new { Name = "John", Age = 30 };
            Console.WriteLine($"{person.Name} is {person.Age} years old.");

            // Extension Classes
            string word = "madam";
            Console.WriteLine(word.IsPalindrome());
        }
    }


    // Standard Class
    public class Cars
    {
        public string Make { get; set; }
        public void Drive()
        {
            Console.WriteLine($"{Make} is driving.");
        }
    }


    // Static Classes
    public static class StaticMessage
    {
        public static void Message()
        {
            Console.WriteLine("This is static class.");
        }
    }


    // Abstract Classes
    public abstract class Shapes
    {
        public abstract double Area();
    }
    public class Circles : Shapes
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }


    // Sealed Classes
    public sealed class Logger
    {
        public void Log()
        {
            Console.WriteLine("Sealed class example.");
        }
    }


    // Partial Classes
    public partial class MyPartialClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
    }

    public partial class MyPartialClass
    {
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }


    // Nested Classes
    public class OuterClass
    {
        public class InnerClass
        {
            public void Display()
            {
                Console.WriteLine("Inner class method.");
            }
        }
    }


    // Extension Classes
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string str)
        {
            string reversed = new string(str.Reverse().ToArray());
            return str == reversed;
        }
    }
}
