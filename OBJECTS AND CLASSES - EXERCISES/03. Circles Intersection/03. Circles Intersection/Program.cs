using System;

namespace _03._Circles_Intersection
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Circle
    {
        public Point Center = new Point();
        public double Radius { get; set; }
        public double Distance { get; set; }
        public Circle(double x, double y, double radius)
        {
            Center.X = x;
            Center.Y = y;
            Radius = radius;
        }
        public double GetDistance(Circle circle)
        {
            double distance = Math.Sqrt(Math.Pow(Center.X - circle.Center.X, 2) + Math.Pow(Center.Y - circle.Center.Y, 2));
            return distance;
        }

        public bool Intersect(Circle circle)
        {
            double distance = Math.Sqrt(Math.Abs(Math.Pow((circle.Center.X - Center.X),2) + Math.Pow(Math.Abs(circle.Center.Y - Center.Y),2)));
            if(distance <= circle.Radius + Radius)
            {
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Circle circle1 = new Circle(double.Parse(input[0]), double.Parse(input[1]), double.Parse(input[2]));
            input = Console.ReadLine().Split(' ');
            Circle circle2 = new Circle(double.Parse(input[0]), double.Parse(input[1]), double.Parse(input[2]));
            if(circle1.Intersect(circle2) == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
