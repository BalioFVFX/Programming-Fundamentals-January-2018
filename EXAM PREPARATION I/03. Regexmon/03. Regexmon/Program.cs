using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace _03._Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patternOfBojomon = @"\b([A-Za-z]+)-([A-Za-z]+)\b";
            string patternOfDidimon = @"[^A-Za-z-]+";            

            while (true)
            {
                if(Regex.IsMatch(input, patternOfDidimon) == true)
                {
                    Match currentMatch = Regex.Match(input, patternOfDidimon);
                    input = input.Remove(0,input.IndexOf(currentMatch.Value) + currentMatch.Value.Length);
                    Console.WriteLine(currentMatch.Value);
                }
                else
                {
                    return;
                }
                if(Regex.IsMatch(input, patternOfBojomon) == true)
                {
                    Match currentMatch = Regex.Match(input, patternOfBojomon);
                    input = input.Remove(0, input.IndexOf(currentMatch.Value) + currentMatch.Value.Length);
                    Console.WriteLine(currentMatch.Value);
                }
                else
                {
                    return;
                }
            }
        }
    }
}
