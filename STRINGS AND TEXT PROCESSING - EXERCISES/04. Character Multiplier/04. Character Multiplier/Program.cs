using System;
using System.Linq;

namespace _04._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < Math.Min(input[0].Length, input[1].Length); i++)
            {
                sum += input[0][i] * input[1][i];
                counter++;
            }

            for (int i = counter; i < Math.Max(input[0].Length, input[1].Length); i++)
            {
                if(counter < input[0].Length)
                {
                    sum += input[0][i];
                }
                else
                {
                    sum += input[1][i];
                }
            }

            Console.WriteLine(sum);
        }  
    }
}
