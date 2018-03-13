using System;

namespace _08._House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long total = 0;

            try
            {
                sbyte value = sbyte.Parse(input);
                total += value * 4;
            }
            catch (Exception)
            {
                total += long.Parse(input) * 10;
            }

            input = Console.ReadLine();

            try
            {
                sbyte value = sbyte.Parse(input);
                total += value * 4;
            }
            catch (Exception)
            {
                total += long.Parse(input) * 10;
            }

            Console.WriteLine(total);
        }
    }
}
