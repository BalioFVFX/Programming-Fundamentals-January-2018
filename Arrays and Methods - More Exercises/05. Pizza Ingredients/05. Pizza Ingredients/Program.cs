using System;

namespace _05._Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            int allowedLength = int.Parse(Console.ReadLine());
            int ingredientsCount = 0;
            string products = string.Empty;
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToString().Length == allowedLength)
                {
                    Console.WriteLine($"Adding {words[i]}.");
                    products += words[i] + " ";
                    ingredientsCount++;
                    counter++;
                    if (counter == 10)
                    {
                        break;
                    }
                }
            }
            
            products = products.Remove(products.Length - 1);
            string[] ingredients = products.Split(' ');
            Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");
            Console.WriteLine("The ingredients are: " + string.Join(", ", ingredients) + ".");
            
        }
    }
}
