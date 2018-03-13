using System;
using System.Collections.Generic;
using System.Linq;
namespace _0._7_Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            SortedDictionary<string, SortedDictionary<string,long>> population = new SortedDictionary<string, SortedDictionary<string,long>>();
           
            while(input[0] != "report")
            {
                if (population.ContainsKey(input[1]) == false)
                {


                    SortedDictionary<string, long> placeInfo = new SortedDictionary<string, long>();
                    placeInfo.Add(input[0], long.Parse(input[2]));
                    population.Add(input[1], placeInfo);
                }
                else
                {
                    SortedDictionary<string, long> placeInfo = new SortedDictionary<string, long>();
                    placeInfo.Add(input[0], long.Parse(input[2]));
                    population[input[1]].Add(input[0], long.Parse(input[2]));
                }
                input = Console.ReadLine().Split('|');
            }

            var populationtest = population.Values.OrderByDescending(x => x);
            
            foreach (var places in population.OrderByDescending(x => x.Value.Values.Sum()))
            {
                long totalPopulation = 0;
                foreach (var populationLong in places.Value)
                {
                    totalPopulation += populationLong.Value;
                }
                Console.WriteLine(places.Key + " (total population: " + totalPopulation + ")");
                foreach (var place in places.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>" + place.Key + ": " + place.Value);
                }
            }

        }
    }
}
