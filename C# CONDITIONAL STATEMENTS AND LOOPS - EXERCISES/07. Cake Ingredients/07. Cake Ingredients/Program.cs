using System;

namespace _07._Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int ingredients = 0;
            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                ingredients++;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {ingredients} ingredients.");
        }
    }
}
