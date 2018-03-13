using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (var number in numbers)
            {
                if(counts.ContainsKey(number) == false)
                {
                    counts[number] = 0;
                }
                counts[number]++;
            }

            foreach (var number in counts)
            {
                Console.WriteLine("{0} -> {1}", number.Key, number.Value);
            }
        }
    }
}
