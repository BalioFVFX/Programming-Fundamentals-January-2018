using System;

namespace _17._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int lastIndex = int.Parse(Console.ReadLine());

            for (int symbol = startIndex; symbol <= lastIndex; symbol++)
            {
                Console.Write((char)symbol + " ");
            }
        }
    }
}
