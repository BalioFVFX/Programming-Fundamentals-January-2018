using System;

namespace _1._Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfStars = 1;
            int whiteSpaces = n;

            for (int i = 0; i < whiteSpaces; i++)
            {
                Console.Write(' ');
            }

            Console.Write(" | ");
            Console.WriteLine();
            whiteSpaces--;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < whiteSpaces; j++)
                {
                    Console.Write(' ');
                }
                for (int k = 0; k < numberOfStars; k++)
                {
                    Console.Write('*');
                }
                Console.Write(" | ");
                for (int l = 0; l < numberOfStars; l++)
                {
                    Console.Write('*');
                }

                Console.WriteLine(" ");

                numberOfStars++;
                whiteSpaces--;
            }
        }
    }
}
