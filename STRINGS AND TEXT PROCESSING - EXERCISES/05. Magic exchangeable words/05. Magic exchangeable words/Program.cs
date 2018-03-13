using System;
using System.Linq;

namespace _05._Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string word1 = input[0];
            string word2 = input[1];

            int word1Length = word1.Distinct().Count();
            int word2Length = word2.Distinct().Count();

            if(word1Length == word2Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
