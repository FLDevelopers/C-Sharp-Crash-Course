using System;
using System.Collections.Generic;

namespace ConsoleApp1.Projects
{
    public class ShapeCalculator
    {
        void shapeCalculator_Main()
        {
            //Shape Calculator
            Console.WriteLine("Welcome to the Shape Calculator!");
            List<Shape> shapes = new List<Shape>();

            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\nChoose a shape to calculate:");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. View all shape details");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        shapes.Add(CreateCircle());
                        break;
                    case "2":
                        shapes.Add(CreateRectangle());
                        break;
                    case "3":
                        shapes.Add(CreateTriangle());
                        break;
                    case "4":
                        DisplayShapes(shapes);
                        break;
                    case "5":
                        keepRunning = false;
                        Console.WriteLine("Thank you for using the Shape Calculator. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        abstract class Shape
        {
            public abstract double CalculateArea();
            public abstract double CalculatePerimeter();
        }

        class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }

            public override double CalculatePerimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }

        class Rectangle : Shape
        {
            public double Length { get; set; }
            public double Width { get; set; }

            public Rectangle(double length, double width)
            {
                Length = length;
                Width = width;
            }

            public override double CalculateArea()
            {
                return Length * Width;
            }

            public override double CalculatePerimeter()
            {
                return 2 * (Length + Width);
            }
        }

        class Triangle : Shape
        {
            public double SideA { get; set; }
            public double SideB { get; set; }
            public double SideC { get; set; }

            public Triangle(double sideA, double sideB, double sideC)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }

            public override double CalculateArea()
            {
                double s = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }

            public override double CalculatePerimeter()
            {
                return SideA + SideB + SideC;
            }
        }


        static Circle CreateCircle()
        {
            Console.WriteLine("\nEnter the radius of the circle:");
            double radius = GetValidDouble();
            Circle circle = new Circle(radius);
            Console.WriteLine($"Circle created with radius {radius}.");
            return circle;
        }

        static Rectangle CreateRectangle()
        {
            Console.WriteLine("\nEnter the length of the rectangle:");
            double length = GetValidDouble();
            Console.WriteLine("Enter the width of the rectangle:");
            double width = GetValidDouble();
            Rectangle rectangle = new Rectangle(length, width);
            Console.WriteLine($"Rectangle created with length {length} and width {width}.");
            return rectangle;
        }

        static Triangle CreateTriangle()
        {
            Console.WriteLine("\nEnter the three sides of the triangle:");
            double sideA = GetValidDouble();
            double sideB = GetValidDouble();
            double sideC = GetValidDouble();
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Console.WriteLine($"Triangle created with sides {sideA}, {sideB}, and {sideC}.");
            return triangle;
        }

        static void DisplayShapes(List<Shape> shapes)
        {
            if (shapes.Count == 0)
            {
                Console.WriteLine("\nNo shapes created yet.");
                return;
            }

            Console.WriteLine("\nShape Details:");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Type: {shape.GetType().Name}");
                Console.WriteLine($"Area: {shape.CalculateArea():F2}");
                Console.WriteLine($"Perimeter: {shape.CalculatePerimeter():F2}");
                Console.WriteLine();
            }
        }

        static double GetValidDouble()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number:");
                }
            }
        }
    }
}
