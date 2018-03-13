using System;
using System.Text.RegularExpressions;

namespace _05._Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            string firstPattern = @"(\w+)([<\|\\]*)(.*)([<\|\\])(\w+)";


            string start = string.Empty;
            string end = string.Empty;

            Match startAndEndCollection = Regex.Match(firstInput, firstPattern);
            start = startAndEndCollection.Groups[1].Value;
            end = startAndEndCollection.Groups[5].Value;

            string secondInput = Console.ReadLine();
            string secondPattern = $@"({start})([a-zA-Z]*?)({end})";

            MatchCollection matches = Regex.Matches(secondInput, secondPattern);

            string result = string.Empty;

            foreach (Match match in matches)
            {
                result += match.Groups[2].Value;
            }
            if(result == "")
            {
                Console.WriteLine("Empty result");
                return;
            }
            Console.WriteLine(result);
        }
    }
}
