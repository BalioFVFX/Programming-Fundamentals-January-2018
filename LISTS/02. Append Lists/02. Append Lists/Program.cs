using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> result = Console.ReadLine().Split('|').ToList();

            result.Reverse();

            for (int i = 0; i < result.Count; i++)
            {
                string[] arr = result[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string text = string.Join(" ", arr);
                Console.Write(text + " ");
            }

        }
    }
}
