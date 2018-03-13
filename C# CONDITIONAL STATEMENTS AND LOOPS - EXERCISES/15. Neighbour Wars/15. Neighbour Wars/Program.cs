using System;

namespace _15._Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;
            
            int turnCounter = 0;

            while(true)
            {
                healthGosho -= damagePesho;
                turnCounter++;

                if (healthGosho <= 0)
                {
                    Console.WriteLine($"Pesho won in {turnCounter}th round.");
                    return;
                }

                Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");

                if (turnCounter % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }

                healthPesho -= damageGosho;
                turnCounter++;

                if (healthPesho <= 0)
                {
                    Console.WriteLine($"Gosho won in {turnCounter}th round.");
                    return;
                }

                Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");

                if (turnCounter % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
                
            }
        }
    }
}
