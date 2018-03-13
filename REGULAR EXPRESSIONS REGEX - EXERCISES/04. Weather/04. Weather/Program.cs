using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._Weather
{
    class Program
    {
        static Dictionary<string, List<string>> ReadWeathers()
        {
            string pattern = @"([A-Z]{2})([0-9]+)\.([0-9]+)([A-Za-z]+)\|";
            string input = Console.ReadLine();
            Dictionary<string, List<string>> matches = new Dictionary<string, List<string>>();

            while (input != "end")
            {

                if (Regex.IsMatch(input, pattern) == true)
                {
                    Match currentMatch = Regex.Match(input, pattern);
                    if (matches.ContainsKey(currentMatch.Groups[1].Value) == false)
                    {
                        List<string> matchedList = new List<string>();

                        string temperature = currentMatch.Groups[2].Value + "." + currentMatch.Groups[3].Value;
                        string weather = currentMatch.Groups[4].Value;
                        matchedList.Add(temperature);
                        matchedList.Add(weather);

                        matches.Add(currentMatch.Groups[1].Value, matchedList);
                    }
                    else
                    {
                        List<string> matchedList = new List<string>();
                        string temperature = currentMatch.Groups[2].Value + "." + currentMatch.Groups[3].Value;
                        string weather = currentMatch.Groups[4].Value;
                        matchedList.Add(temperature);
                        matchedList.Add(weather);

                        matches[currentMatch.Groups[1].Value].Clear();
                        matches[currentMatch.Groups[1].Value] = matchedList;
                    }
                }

                input = Console.ReadLine();
            }

            return matches;
        }

        static void PrintWeathers(Dictionary<string, List<string>> weathers)
        {
                                                        // Treatng the temperature as double se we can order the temperatures (strings) as numbers and not as texts
            foreach (var item in weathers.OrderBy(x => double.Parse(x.Value[0])))
            {
                                                    // Treating the temperatures (string) as a double so we can format the output
                Console.WriteLine($"{item.Key} => {double.Parse(item.Value[0]):f2} => {item.Value[1]}");
            }
        }

        static void Main(string[] args)
        {

            Dictionary<string, List<string>> weathers = new Dictionary<string, List<string>>();

            weathers = ReadWeathers();
            PrintWeathers(weathers);
        }
    }
}
