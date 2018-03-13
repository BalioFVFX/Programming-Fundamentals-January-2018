using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, int> detailedWords = new Dictionary<string, int>();
            List<string> results = new List<string>();

            foreach (var word in words)
            {
                if(detailedWords.ContainsKey(word.ToLower()) == false)
                {
                    detailedWords[word.ToLower()] = 0;
                }
                detailedWords[word.ToLower()]++;
            }

            foreach (var word in detailedWords)
            {
                if(word.Value % 2 != 0)
                {
                    results.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
