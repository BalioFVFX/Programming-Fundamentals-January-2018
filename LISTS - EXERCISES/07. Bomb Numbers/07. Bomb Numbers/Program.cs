using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            decimal[] bomb = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            decimal sum = 0;
            int bombPosition = numbers.IndexOf(bomb[0]);
            
            while (numbers.Contains(bomb[0]))
            {
                for (int i = 0; i < bomb[1]; i++)
                {
                    if(bombPosition - 1 >= 0)
                    {
                        numbers.RemoveAt(bombPosition - 1);
                        bombPosition = numbers.IndexOf(bomb[0]);
                    }

                    if(bombPosition + 1 <= numbers.Count)
                    {
                        numbers.RemoveAt(bombPosition + 1);
                        bombPosition = numbers.IndexOf(bomb[0]);
                    }
                    
                }

                numbers.Remove(bomb[0]);
                bombPosition = numbers.IndexOf(bomb[0]);
            }

            foreach (var item in numbers)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
