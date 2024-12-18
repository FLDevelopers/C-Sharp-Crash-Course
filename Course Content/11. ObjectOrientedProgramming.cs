using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Course_Content
{
    public class ObjectOrientedProgramming
    {
        void objectOrientedProgramming_Main()
        {
            //Encapsulation
            BankAccount myBankAccount = new BankAccount();
            myBankAccount.Deposit(5000);
            Console.WriteLine($"Account Balance: {myBankAccount.Balance}");
            myBankAccount.Withdraw(2000);
            Console.WriteLine($"Account Balance: {myBankAccount.Balance}");


            //Inheritance
            Car car = new Car ("Toyota", "Camry", 2024, 4 );
            car.DisplayInfo();


            //Polymorphism

            // Method overloading
            MathOperations math = new MathOperations();
            Console.WriteLine(math.Add(3,4));
            Console.WriteLine(math.Add(3, 4, 5));
            Console.WriteLine(math.Add(3.5, 4.5));

            // Method overriding
            Animal myAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            myAnimal.Speak();
            dog.Speak();
            cat.Speak();

            
            //Abstraction
            Shape myCircle = new Circle(5);
            Shape mySquare = new Square(4);

            myCircle.Display();
            Console.WriteLine("Area of circle: " + myCircle.CalculateArea());

            mySquare.Display();
            Console.WriteLine("Area of square: " + mySquare.CalculateArea());

            // Interfaces
            IMovable myCar = new MotorCar();
            IMovable myRobot = new Robot();

            myCar.Move();
            myRobot.Move();
        }
    }
    // Encapsulation
    public class BankAccount
    {
        private decimal balance; // Private field

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= balance && amount > 0)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. New balance: ${balance}");
                return true;
            }
            Console.WriteLine("Insufficient funds or invalid amount");
            return false;
        }
    }


    // Inheritance
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        protected int Year { get; set; }
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{Brand} {Model} {Year}");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, int year, int doors) : base(brand, model, year)
        {
            NumberOfDoors = doors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
        }
    }


    // Polymorphism
    //Method Overloading
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    // Method Overriding
    public class Animal
    {
        // Virtual method that can be overridden
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        // Override the Speak method for Dog
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    public class Cat : Animal
    {
        // Override the Speak method for Cat
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }


    // Abstraction

    //Abstract Classes
    public abstract class Shape
    {
        // Abstract method (no implementation)
        public abstract double CalculateArea();

        // Concrete method (with implementation)
        public void Display()
        {
            Console.WriteLine("Calculating area of the shape.");
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implementation of abstract method
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        // Implementation of abstract method
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }


    // Interfaces
    public interface IMovable
    {
        void Move();
    }

    public class MotorCar : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car moves forward.");
        }
    }

    public class Robot : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The robot rolls forward.");
        }
    }
}
