using System;

namespace _09._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int lastValue = 0;
            bool isSpecial = false;

            for (int i = 1; i <= numbers; i++)
            {
                lastValue = i;

                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }

                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{lastValue} -> {isSpecial}");
                sum = 0;
                i = lastValue;
            }

        }
    }
}
