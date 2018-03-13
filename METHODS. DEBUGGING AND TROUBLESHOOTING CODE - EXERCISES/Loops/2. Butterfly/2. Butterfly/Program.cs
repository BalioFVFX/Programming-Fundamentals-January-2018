using System;

namespace _2._Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int height = 2 * (n - 2) + 1;

            int numberOfStars = n - 2;

            for (int i = 0; i < height / 2; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < numberOfStars; j++)
                    {
                        Console.Write('*');
                    }
                    Console.Write("\\ /");
                    for (int k = 0; k < numberOfStars; k++)
                    {
                        Console.Write('*');
                    }
                }
                else
                {
                    for (int j = 0; j < numberOfStars; j++)
                    {
                        Console.Write('-');
                    }
                    Console.Write("\\ /");
                    for (int k = 0; k < numberOfStars; k++)
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write(' ');
            }
            Console.WriteLine(" @ ");

            for (int i = 0; i < height / 2; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < numberOfStars; j++)
                    {
                        Console.Write('*');
                    }
                    Console.Write("/ \\");
                    for (int k = 0; k < numberOfStars; k++)
                    {
                        Console.Write('*');
                    }
                }
                else
                {
                    for (int j = 0; j < numberOfStars; j++)
                    {
                        Console.Write('-');
                    }
                    Console.Write("/ \\");
                    for (int k = 0; k < numberOfStars; k++)
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
