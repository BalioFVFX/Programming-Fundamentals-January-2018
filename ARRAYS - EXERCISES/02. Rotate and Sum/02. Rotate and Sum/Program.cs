using System;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {

        static void reverse(long[] numbers)
        {
            string numberStr = string.Empty;
            numberStr = numbers[0].ToString();
            for (int i = 1; i < numbers.Length; i++)
            {

            }
        }

        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long rotations = long.Parse(Console.ReadLine());
            long[] sum = new long[numbers.Length];
            long[] rotated = new long[numbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                for (int j = 1; j < numbers.Length; j++)
                {
                    rotated[j] = numbers[j - 1];
                }

                rotated[0] = numbers[numbers.Length - 1];

                for (int k = 0; k < rotated.Length; k++)
                {
                    sum[k] += rotated[k];
                }

                for (int l = 0; l < numbers.Length; l++)
                {
                    numbers[l] = rotated[l];
                }
            }

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
