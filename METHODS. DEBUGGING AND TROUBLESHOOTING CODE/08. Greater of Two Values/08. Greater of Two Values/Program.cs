using System;

namespace _08._Greater_of_Two_Values
{
    class Program
    {
        static int getMax(int first, int second)
        {
            return Math.Max(first, second);
        }

        static char getMax(char first, char second)
        {
            if(first >= second)
            {
                return first;
            }

            return second;
        }

        static string getMax(string first, string second)
        {
            if(first.CompareTo(second) >= 0)
            {
                return first;
            }

            return second;
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    Console.WriteLine(getMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case "char":
                    Console.WriteLine(getMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
                    break;
                case "string":
                    Console.WriteLine(getMax(Console.ReadLine(), Console.ReadLine()));
                    break;
                default:
                    break;
            }
        }
    }
}
