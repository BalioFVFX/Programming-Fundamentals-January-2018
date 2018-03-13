using System;

namespace _03._Printing_Triangle
{
    class Program
    {
        static void PrintTriangle(int n)
        {
            string result = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += j + " ";
                }
                result = result.Remove(result.Length - 1);
                result += "\r\n";
            }

            Console.Write(result);
            result = string.Empty;

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += j + " ";
                }

                result = result.Remove(result.Length - 1);
                result += "\r\n";
            }

            Console.Write(result);
            result = string.Empty;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
    }
}
