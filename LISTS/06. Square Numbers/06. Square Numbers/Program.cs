using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNubmers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    squareNubmers.Add(numbers[i]);
                }
            }
            squareNubmers.Sort();
            squareNubmers.Reverse();
            Console.WriteLine(string.Join(" ", squareNubmers));
        }
    }
}
