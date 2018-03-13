using System;

namespace _09._Multiply_Evens_by_Odds
{
    class Program
    {
        static int GetSumOfOddDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            while (number > 0)
            {
                if (number % 2 != 0)
                {
                    sum += number % 10;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;

            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    sum += number % 10;
                }

                number /= 10;
            }

            return sum;
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            return GetSumOfOddDigits(number) * GetSumOfEvenDigits(number);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetMultipleOfEvensAndOdds(int.Parse(Console.ReadLine())));
        }
    }
}
