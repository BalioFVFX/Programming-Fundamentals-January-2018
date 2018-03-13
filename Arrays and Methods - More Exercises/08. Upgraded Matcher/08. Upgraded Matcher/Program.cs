using System;
using System.Linq;

namespace _08._Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productsNames = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            bool canMakeOrder = false;
            string[] order = Console.ReadLine().Split(' ');

            while (order[0] != "done")
            {
                for (int i = 0; i < Math.Min(productsNames.Length, quantities.Length); i++)
                {
                    if (productsNames[i] == order[0] && quantities[i] >= long.Parse(order[1]))
                    {
                        Console.WriteLine($"{productsNames[i]} x {order[1]} costs {prices[i] * long.Parse(order[1]):f2}");
                        quantities[i] -= long.Parse(order[1]);
                        canMakeOrder = true;
                        break;
                    }
                }
                if(canMakeOrder == false)
                {
                    Console.WriteLine($"We do not have enough {order[0]}");
                }
                order = Console.ReadLine().Split(' ');
                canMakeOrder = false;
            }
        }
    }
}
