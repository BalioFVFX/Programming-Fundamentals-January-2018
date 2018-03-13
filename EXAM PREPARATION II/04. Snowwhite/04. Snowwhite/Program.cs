using System;
using System.Collections.Generic;
using System.Linq;
namespace _04._Snowwhite
{
    class DwarfData
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        public decimal Physics { get; set; }
        public static bool containsName(string name, List<DwarfData> dwarfData)
        {
            foreach (DwarfData dwarf in dwarfData)
            {
                if (dwarf.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<DwarfData> dwarfs = new List<DwarfData>();
            while (input != "Once upon a time")
            {
                string[] formattedInput = input.Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string currentName = formattedInput[0];
                string currentHatColor = formattedInput[1];
                decimal currentPhysics = decimal.Parse(formattedInput[2]);

                if (DwarfData.containsName(currentName, dwarfs) == false)
                {
                    DwarfData currentDwarf = new DwarfData();
                    currentDwarf.Name = currentName;
                    currentDwarf.HatColor = currentHatColor;
                    currentDwarf.Physics = currentPhysics;
                    dwarfs.Add(currentDwarf);
                }
                else
                {
                    bool sameColors = false;
                    foreach (var dwarf in dwarfs)
                    {
                        if (dwarf.Name == currentName)
                        {
                            if (dwarf.HatColor == currentHatColor)
                            {
                                sameColors = true;
                                if (currentPhysics > dwarf.Physics)
                                {
                                    dwarf.Physics = currentPhysics;
                                    break;
                                }
                            }
                        }
                    }
                    if (sameColors == false)
                    {
                        DwarfData currentDwarf = new DwarfData();
                        currentDwarf.Name = currentName;
                        currentDwarf.HatColor = currentHatColor;
                        currentDwarf.Physics = currentPhysics;
                        dwarfs.Add(currentDwarf);
                    }
                }


                input = Console.ReadLine();

            }
            Dictionary<string, int> colors = new Dictionary<string, int>();

            foreach (var dwarf in dwarfs)
            {
                if (colors.ContainsKey(dwarf.HatColor) == false)
                {
                    colors.Add(dwarf.HatColor, 0);
                }
                else
                {
                    colors[dwarf.HatColor]++;
                }
            }

            foreach (var color in colors.OrderByDescending(color => color.Value))
            {
                if (color.Value != 0)
                {
                    foreach (var dwarf in dwarfs.Where(hatColor => hatColor.HatColor == color.Key).OrderByDescending(physics => physics.Physics))
                    {
                        Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
                        dwarfs.Remove(dwarf);
                    }
                }
                else
                {
                    foreach (var dwarf in dwarfs.OrderByDescending(physics => physics.Physics))
                    {
                        Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
                        dwarfs.Remove(dwarf);
                    }
                }

            }
        }
    }
}