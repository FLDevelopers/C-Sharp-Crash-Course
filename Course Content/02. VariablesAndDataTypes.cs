using System;

namespace ConsoleApp1
{
    public class VariablesAndDataTypes
    {
        void variablesAndDataTypes_Main()
        {
            // Variables & Data Types
            string message = "Hello World";

            int score;     // Declaration
            score = 100;   // Assignment

            // Integer
            int age = 25;

            // Long
            long worldPopulation = 8000000000;

            // Float
            float length = 4.3f;

            // Double
            double height = 5.11;
            double width = 8.5d;

            // Decimal
            decimal accountBalance = 1234.56m;

            // String
            string firstName = "John";

            //Boolean
            bool isStudent = true;

            // Implicit Type Conversion
            int number = 100;
            double biggerNumber = number;

            // Explicit Type Conversion
            double price = 99.99;
            int roundedPrice = (int)price;
            String value = roundedPrice.ToString();

            // Constant
            const double TAX_RATE = 0.07;
            const string COMPANY_NAME = "Tech Corp";
            const int MAX_ATTEMPTS = 3;

            //var
            var greeting = "Hello"; // String
            var studentCount = 30;  // Integer
            var temperature = 98.6; // Double
        }
    }
}
