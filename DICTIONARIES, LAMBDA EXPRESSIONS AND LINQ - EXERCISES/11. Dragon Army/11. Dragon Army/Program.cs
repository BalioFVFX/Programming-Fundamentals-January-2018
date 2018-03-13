using System;
using System.Collections.Generic;

namespace _11._Dragon_Army
{
    class Program
    {
        static List<double> orderPoweres(string[] input)
        {
            List<double> powers = new List<double>();
            if (input[2] == "null")
            {
                powers.Add(45);
            }
            else
            {
                powers.Add(double.Parse(input[2]));
            }
            if (input[3] == "null")
            {
                powers.Add(250);
            }
            else
            {
                powers.Add(double.Parse(input[3]));
            }
            if (input[4] == "null")
            {
                powers.Add(10);
            }
            else
            {
                powers.Add(double.Parse(input[4]));
            }

            return powers;
            
        }

        static Dictionary<string, string> calculateAvreages(Dictionary<string, SortedDictionary<string, List<double>>> heroes)
        {
            Dictionary<string, string> averages = new Dictionary<string, string>();

            double totalDamage = 0;
            double totalHealth = 0;
            double totalArmor = 0;
            string output = string.Empty;

            foreach (var hero in heroes)
            {


                foreach (var heroInfo in hero.Value)
                {

                    for (int i = 0; i < heroInfo.Value.Count; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                totalDamage += heroInfo.Value[i];
                                break;
                            case 1:
                                totalHealth += heroInfo.Value[i];
                                break;
                            case 2:
                                totalArmor += heroInfo.Value[i];
                                break;
                            default:
                                break;
                        }

                    }
                }

                totalDamage /= hero.Value.Count;
                totalHealth /= hero.Value.Count;
                totalArmor /= hero.Value.Count;

                output = "::(" + $"{totalDamage:f2}" + "/" + $"{totalHealth:f2}" + "/" + $"{totalArmor:f2}" + ")";
                averages.Add(hero.Key, output);
                totalDamage = 0;
                totalHealth = 0;
                totalArmor = 0;
                output = string.Empty;
            }

            return averages;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, List<double>>> heroes = new Dictionary<string, SortedDictionary<string, List<double>>>();
            Dictionary<string, string> typesInfo = new Dictionary<string, string>();
            string output = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                if (heroes.ContainsKey(input[0]) == false)
                {
                    List<double> powers = orderPoweres(input);
                    SortedDictionary<string, List<double>> heroesInfo = new SortedDictionary<string, List<double>>();

                    heroesInfo.Add(input[1], powers);
                    heroes.Add(input[0], heroesInfo);
                }
                else
                {
                    List<double> powers = orderPoweres(input);
                    if(heroes[input[0]].ContainsKey(input[1]) == false)
                    {
                        heroes[input[0]].Add(input[1], powers);
                    }
                    else
                    {
                        heroes[input[0]][input[1]] = powers;
                    }
                    
                }
            }

            typesInfo = calculateAvreages(heroes);

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key + typesInfo[hero.Key]);
                string currentPower = string.Empty;
                foreach (var heroInfo in hero.Value)
                {
                    for (int i = 0; i < heroInfo.Value.Count; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                currentPower = "damage";
                                break;
                            case 1:
                                currentPower = "health";
                                break;
                            case 2:
                                currentPower = "armor";
                                break;
                            default:
                                break;
                        }

                        output += currentPower + ": " + heroInfo.Value[i] + ", ";
                    }
                    output = output.Remove(output.Length - 1);
                    output = output.Remove(output.Length - 1);
                    Console.WriteLine("-" + heroInfo.Key + " -> " + output);
                    output = string.Empty;
                }
            }
        }
    }
}
