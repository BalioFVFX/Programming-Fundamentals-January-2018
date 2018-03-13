using System;

namespace _06._Rectangle_Position
{
    class Rectangle
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public static Rectangle parseRect(string[] input)
        {
            return new Rectangle(double.Parse(input[0]), double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
        }

        public Rectangle(double left, double top, double width, double height)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;
            Right = Left + width;
            Bottom = top + height;
        }

        public bool IsInside(Rectangle r)
        {
            if(Left >= r.Left && Right <= r.Right && Top <= r.Top && Bottom <= r.Bottom)
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
            Rectangle rect1 = Rectangle.parseRect(input);
            input = Console.ReadLine().Split(' ');
            Rectangle rect2 = Rectangle.parseRect(input);
            
            if(rect1.IsInside(rect2) == true)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}
