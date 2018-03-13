using System;
using System.Collections.Generic;

namespace _07._Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int reminder = 0;
            string input = Console.ReadLine();
            input = input.TrimStart('0');
            byte multiplier = byte.Parse(Console.ReadLine());
            List<int> result = new List<int>();

            if(multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (true)
            {
                string numberStr = input[input.Length - 1].ToString();
                input = input.Remove(input.Length - 1);

                int numbResult = (int.Parse(numberStr) * multiplier) + reminder;

                reminder = 0;
                if(input == "")
                {
                    result.Insert(0, numbResult);
                    Console.WriteLine(string.Join("", result));
                    break;
                }
                if (numbResult >= 10)
                {
                    
                    reminder = int.Parse(numbResult.ToString()[0].ToString());
                    result.Insert(0, int.Parse(numbResult.ToString()[1].ToString()));
                }
                else
                {
                    result.Insert(0, int.Parse(numbResult.ToString()[0].ToString()));
                }
            }
            
        }
    }
}
