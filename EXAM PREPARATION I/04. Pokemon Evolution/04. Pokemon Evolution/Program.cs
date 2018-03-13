using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {'-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();
            
            while (input[0] != "wubbalubbadubdub")
            {

                if (pokemons.ContainsKey(input[0].Trim()) == true && input.Length == 1)
                {
                    Console.WriteLine($"# {input[0]}");

                    foreach (var pokemon in pokemons[input[0]])
                    {
                        Console.WriteLine(pokemon);
                    }

                    input = Console.ReadLine().Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                try
                {
                    int.Parse(input[2]);
                }
                catch (Exception)
                {
                    input = Console.ReadLine().Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                if (pokemons.ContainsKey(input[0].Trim()) == false)
                {
                    List<string> currentList = new List<string>();
                    string listString = input[1].Trim() + " <-> " + input[2].Trim();
                    currentList.Add(listString);
                   
                    pokemons.Add(input[0].Trim(), currentList);
                }
                else
                {
                    string listString = input[1].Trim() + " <-> " + input[2].Trim();
                    pokemons[input[0].Trim()].Add(listString);
                }

                input = Console.ReadLine().Split(new char[] { '-', ',', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            


            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Key}");

                foreach (var pokemonInList in pokemon.Value.OrderByDescending(x => int.Parse(x.Remove(0, x.IndexOf("->") + 2).Trim())))
                {
                    Console.WriteLine(pokemonInList);
                }
            }
        }
    }
}
