﻿using System;

namespace _06._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeday = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double price = 0.00;

            if(typeday == "Weekday")
            {
                if(age >= 0 && age <= 18)
                {
                    price = 12;
                }
                else if(age > 18 && age <= 64)
                {
                    price = 18;
                }
                else if(age > 64 && age <= 122)
                {
                    price = 12;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }

            }
            else if(typeday == "Weekend")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 20;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 15;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }

            }
            else if(typeday == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
                else if (age > 64 && age <= 122)
                {
                    price = 10;
                }
                else
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }
 
                Console.WriteLine($"{price}$");
            
        }
    }
}
