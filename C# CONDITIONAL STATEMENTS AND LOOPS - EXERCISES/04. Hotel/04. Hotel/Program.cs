using System;

namespace _04._Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceForStudioNight = 0.00;
            double priceForDoubleNight = 0.00;
            double priceForSuiteNight = 0.00;
            double discount = 0;



            if(month == "May" || month == "October")
            {
                priceForStudioNight = 50;
                priceForDoubleNight = 65;
                priceForSuiteNight = 75;

                if(nightsCount > 7)
                {
                    discount = 0.05 * priceForStudioNight;

                    priceForStudioNight -= discount;
                }
            }
            else if(month == "June" || month == "September")
            {
                priceForStudioNight = 60;
                priceForDoubleNight = 72;
                priceForSuiteNight = 82;

                if(nightsCount > 14)
                {
                    discount = 0.10 * priceForDoubleNight;

                    priceForDoubleNight -= discount;
                }
            }
            else if(month == "July" || month == "August" || month == "December")
            {
                priceForStudioNight = 68;
                priceForDoubleNight = 77;
                priceForSuiteNight = 89;
                
                if(nightsCount > 14)
                {
                    discount = 0.15 * priceForSuiteNight;

                    priceForSuiteNight -= discount;
                }
            }

            if(month == "September" || month == "October" && nightsCount > 7)
            {
                double freeNight = nightsCount - 1;
                priceForStudioNight *= freeNight;
            }
            else
            {
                priceForStudioNight *= nightsCount;
            }
 
          
            priceForDoubleNight *= nightsCount;
            priceForSuiteNight *= nightsCount;

           

            Console.WriteLine($"Studio: {priceForStudioNight:f2} lv.");
            Console.WriteLine($"Double: {priceForDoubleNight:f2} lv.");
            Console.WriteLine($"Suite: {priceForSuiteNight:f2} lv.");

        }
    }
}
