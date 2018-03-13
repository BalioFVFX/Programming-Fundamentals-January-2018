using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int counter = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i; j <= numbers.Count; j++)
                {
                    if (j == numbers.Count)
                    {
                        Console.WriteLine(numbers[i] + " -> " + counter);
                        return;
                    }

                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine(numbers[i] + " -> " + counter);
                        counter = 0;
                        i = j - 1;
                        break;
                    }

                }
            }
        }
    }
}
