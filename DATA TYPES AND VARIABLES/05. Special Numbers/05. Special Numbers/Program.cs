using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool isSpecial = false;

            for (int i = 1; i <= n; i++)
            {
                number = i;
                while(number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                isSpecial = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {isSpecial}");

                sum = 0;
            }
        }
    }
}
