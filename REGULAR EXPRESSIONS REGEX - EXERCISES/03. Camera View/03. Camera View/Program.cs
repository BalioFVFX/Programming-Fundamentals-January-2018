using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            string firstNumber = numbers[0].ToString();
            string secondNumber = numbers[1].ToString();
            string pattern = @"\|<([\w]{" + firstNumber + @"})([\w]{" + 0 + "," + secondNumber + @"})";
                             //   [\|<] ([a - zA - z]{9})([a - zA - Z]{0,7})
            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> matchedList = new List<string>();
            foreach (Match match in matches)
            {
                matchedList.Add(match.Groups[2].Value);
            }

            Console.WriteLine(string.Join(", ", matchedList));
        }
    }
}
