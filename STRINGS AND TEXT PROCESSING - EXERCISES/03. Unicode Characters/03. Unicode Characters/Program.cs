using System;

namespace _03._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u" + ((int)charArray[i]).ToString("x4"));
            }
            
        }
    }
}
