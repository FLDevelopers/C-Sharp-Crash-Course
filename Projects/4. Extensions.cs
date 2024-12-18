using System;
using System.Linq;

namespace ConsoleApp1.Projects
{
    public class Extensions
    {
        void extensions_Main()
        {
            // String Extensions
            string word = "Racecar";
            Console.WriteLine($"Is \"{word}\" a palindrome? {word.IsPalindrome()}");
            string phrase = "hello world!";
            Console.WriteLine($"Title Case: {phrase.ToTitleCase()}");

            // DateTime Extensions
            DateTime birthDate = new DateTime(1990, 5, 15);
            Console.WriteLine($"Age: {birthDate.Age()}");
            Console.WriteLine($"Is today a weekend? {DateTime.Today.IsWeekend()}");

            // Numeric Extensions
            int number = 17;
            Console.WriteLine($"{number} is prime? {number.IsPrime()}");
            double fraction = 0.4567;
            Console.WriteLine($"As percentage: {fraction.ToPercentage()}%");
            Console.WriteLine();
        }
    }

    public static class StringExtensions
    {
        public static bool IsPalindrome(this string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            string reversed = new string(input.Reverse().ToArray());
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        public static string ToTitleCase(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }

    public static class DateTimeExtensions
    {
        public static int Age(this DateTime birthDate)
        {
            var today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age)) age--;
            return age;
        }

        public static bool IsWeekend(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }
    }

    public static class NumericExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static double ToPercentage(this double value, int decimalPlaces = 2)
        {
            return Math.Round(value * 100, decimalPlaces);
        }
    }
}
