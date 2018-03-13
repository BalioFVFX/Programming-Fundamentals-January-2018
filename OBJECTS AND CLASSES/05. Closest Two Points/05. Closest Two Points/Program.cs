using System;

namespace _05._Closest_Two_Points
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static Point[] FindClosestPoints(Point[] points)
        {
            double distance = 0;
            double bestDistance = double.MaxValue;
            Point[] distPoint = new Point[2];

            for (int i = 0; i < 2; i++)
            {
                distPoint[i] = new Point();
            }

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    distance = Math.Sqrt(Math.Pow(points[i].X - points[j].X, 2) + Math.Pow(points[i].Y - points[j].Y, 2));
                    if(distance < bestDistance)
                    {
                        distPoint[0].X = points[i].X;
                        distPoint[0].Y = points[i].Y;
                        distPoint[1].X = points[j].X;
                        distPoint[1].Y = points[j].Y;

                        bestDistance = distance;
                    }
                }
            }
            Console.WriteLine($"{bestDistance:f3}");
            return distPoint;
        }

        public Point()
        {
            X = 0;
            Y = 0;
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
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
           
            
            for (int i = 0; i < n; i++)
            {
                points[i] = new Point();
            }

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                points[i].X = double.Parse(input[0]);
                points[i].Y = double.Parse(input[1]);
            }

            Point[] distPoints = Point.FindClosestPoints(points);
            Console.WriteLine($"({distPoints[0].X}, {distPoints[0].Y})");
            Console.WriteLine($"({distPoints[1].X}, {distPoints[1].Y})");
        }
    }
}
