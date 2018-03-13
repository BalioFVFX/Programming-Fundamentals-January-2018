using System;

namespace _04._Draw_a_Filled_Square
{
    class Program
    {
        static void PrintTopAndBottom(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
        static void PrintMiddleRow(int n)
        {
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("-");
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
        }
        static void DrawAFilledSquare(int n)
        {
            PrintTopAndBottom(n);
            PrintMiddleRow(n);
            PrintTopAndBottom(n);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DrawAFilledSquare(n);
        }
    }
}
