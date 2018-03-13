using System;

namespace _04._Distance_between_Points
{

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Point p1 = new Point(double.Parse(input[0]), double.Parse(input[1]));
            input = Console.ReadLine().Split(' ');
            Point p2 = new Point(double.Parse(input[0]), double.Parse(input[1]));

            Console.WriteLine($"{Point.CalculateDistance(p1, p2):f3}");
        }
    }
}
