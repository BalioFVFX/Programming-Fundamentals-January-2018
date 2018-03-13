using System;
using System.Linq;

namespace _07._Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productsNames = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            string input = Console.ReadLine();

            while(input != "done")
            {
                for (int i = 0; i < productsNames.Length; i++)
                {
                    if(productsNames[i] == input)
                    {
                        Console.WriteLine($"{productsNames[i]} costs: {prices[i]}; Available quantity: {quantities[i]}");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
