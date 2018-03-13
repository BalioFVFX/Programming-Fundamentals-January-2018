using System;

namespace _5._Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n;
            int height = (n + 1) / 2;
            int numberOfTopAndBottomStars = 0;
            int numberOfDashes = (n - 1) / 2;
            int numberOfMiddleDashes = 0;

            if(n == 1)
            {
                Console.WriteLine("*");
                return;
            }
            else if(n == 2)
            {
                Console.WriteLine("**");
                return;
            }

            if(n % 2 == 0)
            {
                numberOfTopAndBottomStars = 2;
                numberOfMiddleDashes = 2;
            }
            else
            {
                numberOfTopAndBottomStars = 1;
                numberOfMiddleDashes = 1;
            }

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < numberOfDashes; j++)
                {
                    Console.Write('-');
                }

                for (int k = 0; k < numberOfTopAndBottomStars; k++)
                {
                    Console.Write('*');
                }

                for (int l = 0; l < numberOfDashes; l++)
                {
                    Console.Write('-');
                }
                
            }
            Console.WriteLine();
            numberOfDashes--;
        
            for (int i = 0; i < height - 1; i++)
            {
                for (int j = 0; j < numberOfDashes; j++)
                {
                    Console.Write('-');
                }

                Console.Write('*');

                for (int k = 0; k < numberOfMiddleDashes; k++)
                {
                    Console.Write('-');
                }

                Console.Write('*');

                for (int l = 0; l < numberOfDashes; l++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
                numberOfDashes--;
                numberOfMiddleDashes += 2;

            }

            numberOfDashes = 1;
            numberOfMiddleDashes -= 4;

            for (int i = 0; i < height - 2; i++)
            {
                for (int j = 0; j < numberOfDashes; j++)
                {
                    Console.Write('-');
                }

                Console.Write('*');

                for (int k = 0; k < numberOfMiddleDashes; k++)
                {
                    Console.Write('-');
                }

                Console.Write('*');

                for (int l = 0; l < numberOfDashes; l++)
                {
                    Console.Write('-');
                }
                Console.WriteLine();
                numberOfDashes++;
                numberOfMiddleDashes -= 2;

            }

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < numberOfDashes; j++)
                {
                    Console.Write('-');
                }

                for (int k = 0; k < numberOfTopAndBottomStars; k++)
                {
                    Console.Write('*');
                }

                for (int l = 0; l < numberOfDashes; l++)
                {
                    Console.Write('-');
                }

            }
            Console.WriteLine();

        }
    }
}
