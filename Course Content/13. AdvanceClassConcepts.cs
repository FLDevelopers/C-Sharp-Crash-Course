using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class AdvanceClassConcepts
    {
        static void advanceClassConcepts_Main(string[] args)
        {
            // Advance Class Concepts

            // Accessing Static Member & Methods
            Console.WriteLine(MathUtility.Pi);
            Console.WriteLine(MathUtility.CalculateCircleArea(5));

            // Access Modifiers
            Messages myMessages = new Messages();
            // Accessing public member
            Console.WriteLine(myMessages.PublicMessage);
            // Accessing private member via a public method
            myMessages.ShowPrivateMessage();
            // Accessing internal member
            Console.WriteLine(myMessages.InternalMessage);
            // Accessing Protected member through derived class
            DerivedMessages derived = new DerivedMessages();
            derived.ShowProtectedMessage();

            // Constructor Chaining
            Vehicle1 vehicle = new Vehicle1();
            Console.WriteLine(vehicle.Type);

        }
    }

    // Class With Static Members
    public class MathUtility
    {
        public static double Pi = 3.14159;

        public static double CalculateCircleArea(double radius)
        {
            return Pi * radius * radius;
        }
    }

    // Access Modifiers
    public class Messages
    {
        // Public: Accessible everywhere
        public string PublicMessage = "I am Public";

        // Private: Accessible only within this class
        private string PrivateMessage = "I am Private";

        // Protected: Accessible within this class and derived classes
        protected string ProtectedMessage = "I am Protected";

        // Internal: Accessible within the same assembly
        internal string InternalMessage = "I am Internal";

        // Method to show the private member (indirect access)
        public void ShowPrivateMessage()
        {
            Console.WriteLine(PrivateMessage);
        }
    }

    public class DerivedMessages : Messages
    {
        public void ShowProtectedMessage()
        {
            // Accessing protected member from base class
            Console.WriteLine(ProtectedMessage);
        }
    }

    // Constructor Chaining
    public class Vehicle1
    {
        public string Type { get; set; }
        public Vehicle1(string type)
        {
            Type = type;
        }

        public Vehicle1() : this("Car")
        {
        }
    }
}
