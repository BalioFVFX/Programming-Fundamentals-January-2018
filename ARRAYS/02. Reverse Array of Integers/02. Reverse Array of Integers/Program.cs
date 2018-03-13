using System;

namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
