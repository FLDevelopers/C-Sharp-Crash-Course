using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class ClassesObjects
    {
        public void classesObjects_Main()
        {
            // Classes

            Person person = new Person();

            Person person1 = new Person("John", 28);

            person.Introduce();

            person1.Introduce();
        }

        public class Person
        {
            // Fields (variables)
            //public string Name;
            //public int Age;

            //Properties
            public string Name { get; set; }
            public int Age { get; set; }

            // Constructor
            public Person()
            {
                Console.WriteLine("Empty Constructor");
            }

            // Parameterized Constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }


            // Methods
            public void Introduce()
            {
                Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old.");
            }
        }

        public class BankAccount
        {
            // Private field
            private decimal _balance;

            // Public property
            public decimal Balance
            {
                // Getter to get value
                get
                {
                    return _balance;
                }

                // Setter to set value
                set
                {
                    if (value < 0)
                        _balance = 0;
                    else
                        _balance = value;
                }
            }

            public void Deposit(decimal amount)
            {
                Balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                Balance -= amount;
            }
        }
    }
}
