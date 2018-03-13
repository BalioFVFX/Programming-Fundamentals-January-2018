using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContentPer100ml = int.Parse(Console.ReadLine());
            int sugarContentPer100ml = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{(double)energyContentPer100ml * volume / 100}kcal, {(double)sugarContentPer100ml * volume / 100}g sugars");
        }
    }
}
