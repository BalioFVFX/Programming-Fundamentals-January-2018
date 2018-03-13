using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static double GetTriangleArea(double width, double height)
        {
            return (width * height) / 2;
        }

        static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        static double GetSquareArea(double side)
        {
            return side * side;
        }

        static double GetCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius,2);
        }

        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "triangle":
                    Console.WriteLine($"{GetTriangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())):f2}");
                    return;
                case "square":
                    Console.WriteLine($"{GetSquareArea(double.Parse(Console.ReadLine())):f2}");
                    return;
                case "rectangle":
                    Console.WriteLine($"{GetRectangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())):f2}");
                    return;
                case "circle":
                    Console.WriteLine($"{GetCircleArea(double.Parse(Console.ReadLine())):f2}");
                    return;
                default:
                    return;
            }
        }
    }
}
