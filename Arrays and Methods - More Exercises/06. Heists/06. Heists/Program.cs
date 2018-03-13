using System;
using System.Linq;

namespace _06._Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] prices = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();


            long totalEarnings = 0;
            long totalExpenses = 0;

            string input = Console.ReadLine();

            while (input != "Jail Time")
            {
                long foundedJewelsEarnings = 0;
                long foundedGoldEarnings = 0;
                
                long currentExpenses = long.Parse(input.Remove(0, input.IndexOf(' ') + 1));
                for (int i = 0; i < input.Length; i++)
                {
                    if(input[i] == '%')
                    {
                        foundedJewelsEarnings += prices[0];
                    }
                    else if(input[i] == '$')
                    {
                        foundedGoldEarnings += prices[1];
                    }
                }

                totalEarnings += foundedJewelsEarnings + foundedGoldEarnings;
                totalExpenses += currentExpenses;
                input = Console.ReadLine();
            }

            if(totalEarnings >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - totalEarnings}.");
            }

        }
    }
}
