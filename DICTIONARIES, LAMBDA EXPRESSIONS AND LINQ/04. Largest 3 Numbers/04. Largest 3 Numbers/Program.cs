using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

             var result = numbers.OrderByDescending(x => x).Take(3);

            Console.WriteLine(string.Join(" ", result));
            
        }
    }
}
