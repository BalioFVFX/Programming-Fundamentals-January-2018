using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            int takeElement = numbers.Length;

            int numberOfElements = numbers.Length;
            
            if(takeElement == 1)
            {
                Console.WriteLine(numbers[0]);
                return;
            }

            if(numberOfElements % 2 == 0)
            {
                takeElement = (numberOfElements / 2) - 1;
                Console.Write("{ " + numbers[takeElement] + ", ");
                takeElement = numberOfElements / 2;
                Console.WriteLine(numbers[takeElement] + " }");
            }
            else
            {
                takeElement = (numberOfElements / 2) - 1;
                Console.Write("{ " + numbers[takeElement] + ", ");
                takeElement = numberOfElements / 2;
                Console.Write(numbers[takeElement] + ", ");
                takeElement = (numberOfElements / 2) + 1;
                Console.WriteLine(numbers[takeElement] + " }");
            }
                
        }
    }
}
