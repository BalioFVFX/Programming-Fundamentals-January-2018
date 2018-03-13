using System;

namespace _06._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            for (int i = 0; i < words.Length / 2; i++)
            {
                string lastWord = words[words.Length - 1 - i];
                words[words.Length - i - 1] = words[i];
                words[i] = lastWord;
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
