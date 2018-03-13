using System;
using System.Linq;

namespace _04._Grab_and_Go
{
    class Program
    {
        static int getLastPosition(long[] arr, long number)
        {
            int lastPosition = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == number)
                {
                    lastPosition = i;
                }
            }
            return lastPosition;
        }

        static long sumToNumber(long[] arr, long number)
        {
            long sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long number = long.Parse(Console.ReadLine());
            int position = getLastPosition(numbers, number);
            if(position == 0)
            {
                Console.WriteLine("No occurrences were found!");
                return;
            }
            Console.WriteLine(sumToNumber(numbers, position));
        }
    }
}
