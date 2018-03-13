using System;

namespace _02._Max_Method
{
    class Program
    {
        static int GetMax(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                return a;
            }
            else if(b >= a && b >= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
    }
}
