using System;

namespace _03._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            double discount = 0.00;
            double packagePrice = 0.00;
            double hallPrice = 0.00;
            double totalPrice = 0.00;
            double pricePerPerson = 0.00;
            string hallName = string.Empty;

            switch (package)
            {
                case "Normal":
                    discount = 0.05;
                    packagePrice = 500;
                    break;
                case "Gold":
                    discount = 0.10;
                    packagePrice = 750;
                    break;
                case "Platinum":
                    discount = 0.15;
                    packagePrice = 1000;
                    break;
                default:
                    break;
            }

            if(groupSize <= 50)
            {
                hallName = "Small Hall";
                hallPrice = 2500;
            }
            else if(groupSize > 50 && groupSize <= 99)
            {
                hallName = "Terrace";
                hallPrice = 5000;
            }
            else if(groupSize >= 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                hallPrice = 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            totalPrice = hallPrice + packagePrice;

            discount = totalPrice * discount;

            totalPrice -= discount;

            pricePerPerson = totalPrice / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
