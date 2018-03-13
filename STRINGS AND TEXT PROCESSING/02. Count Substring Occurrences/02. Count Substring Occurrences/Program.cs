using System;

namespace _02._Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string searchWord = Console.ReadLine().ToLower();
            int index = input.IndexOf(searchWord);
            int counter = 0;
            while (index != -1)
            {

                index = input.IndexOf(searchWord, index + 1);
                counter++;

            }
            Console.WriteLine(counter);
        }
    }
}
