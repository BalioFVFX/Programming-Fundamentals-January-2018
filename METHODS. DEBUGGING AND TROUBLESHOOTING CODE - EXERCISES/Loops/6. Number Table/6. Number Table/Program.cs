using System;

namespace _6._Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = n;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write(j + " ");
                }

                for (int k = (counter + i) - 2; k >= counter; k--)
                {
                    Console.Write(k + " ");
                }
                counter--;
                Console.WriteLine();
            }
        }
    }
}
