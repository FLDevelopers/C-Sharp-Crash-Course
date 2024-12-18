using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class OperatorsAndExpressions
    {
        void operatorsAndExpressions_Main()
        {
            // Operators & Expressions

            // Arithmetic Operators
            int x = 10;
            int y = 3;

            int sum = x + y;
            int difference = x - y;
            int product = x * y;
            int quotient = x / y;
            int remainder = x % y;

            // Comparison Operators
            int age = 25;
            int votingAge = 18;

            // Equal to
            bool result = age == 25;        // true
            // Greater than
            result = age > 20;              // true
            // Lesser than
            result = age < 20;              // false
            // Greater than or Equal to
            result = age >= votingAge;      // true
            // Lesser than or Equal to
            result = age <= votingAge;      //false
            // Not Equal to
            result = age != 0;              // true

            // Logical Operators
            bool hasLicense = true;
            bool hasInsurance = true;
            int person_age = 25;

            // AND (&&) Operator
            bool canDrive = hasLicense && hasInsurance;                  // true
            // OR (||) Operator
            bool canGetDiscount = person_age < 18 || person_age > 65;    // false
            // NOT (!) Operator
            bool isNotLicensed = !hasLicense;                            // false

            //Assignment Operators
            int score = 10;     // Basic assignment
            score += 5;         // Same as: score = score + 5
            score -= 3;         // Same as: score = score - 3
            score *= 2;         // Same as: score = score * 2
            score /= 4;         // Same as: score = score / 4
            score %= 3;         // Same as: score = score % 3

            // Operator Precedence
            int result1 = 5 + 3 * 2;        // 11 (not 16)
            int result2 = (5 + 3) * 2;      // 16
            int result3 = 10 - 2 + 3;       // 11 (left to right)

            // Complex example
            bool complexCheck = (age >= 18) && (score > 70 || !hasLicense);
        }
    }
}
