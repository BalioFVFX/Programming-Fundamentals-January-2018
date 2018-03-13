using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            string[] command = Console.ReadLine().Split(' ');

            while(command[0] != "Odd" && command[0] != "Even")
            {
                if(command[0] == "Delete")
                {
                    numbers.RemoveAll(number => number == long.Parse(command[1]));
                }
                else if(command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), long.Parse(command[1]));
                }

                command = Console.ReadLine().Split(' ');
            }

            if(command[0] == "Even")
            {
                foreach (var item in numbers)
                {
                    if(item % 2 == 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            else
            {
                foreach (var item in numbers)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
