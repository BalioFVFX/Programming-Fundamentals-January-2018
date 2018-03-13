using System;

namespace _11._Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double granica = double.Parse(Console.ReadLine());

            double last = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double current = double.Parse(Console.ReadLine());
                double difference = Precent(last, current);
                bool isSignificantDifference = isThereDifference(difference, granica);

                string message = GetMessage(current, last, difference, isSignificantDifference);
                Console.WriteLine(message);

                last = current;
            }
        }

        private static string GetMessage(double current, double last, double difference, bool isSignificantDifference)
        {
            string message = "";

            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", current);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, current, difference * 100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, current, difference * 100);
            }
            else if (isSignificantDifference && (difference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, current, difference * 100);
            }
                
            return message;
        }
        private static bool isThereDifference(double granica, double difference)
        {
            if (Math.Abs(granica) >= difference)
            {
                return true;
            }
            return false;
        }

        private static double Precent(double last, double current)
        {
            double difference = (current - last) / last;
            return difference;
        }
    }
    
}
