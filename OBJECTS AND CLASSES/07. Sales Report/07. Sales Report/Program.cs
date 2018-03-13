using System;
using System.Collections.Generic;

namespace _07._Sales_Report
{
    class Sale
    {

        public SortedDictionary<string, double> SalesByTown { get; set; }

        public Sale(SortedDictionary<string, double> sales)
        {

            SalesByTown = sales;

        }
       
        public static Sale readSale()
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, double> sales = new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string town = input[0];
                double price = double.Parse(input[2]);
                double quantity = double.Parse(input[3]);
                double priceTotal = price * quantity;

                if (sales.ContainsKey(town) == false)
                {
                    sales.Add(town, priceTotal);
                }
                else
                {
                    sales[town] += priceTotal;
                }

            }
            return new Sale(sales);
        }

        public void printSales()
        {
            foreach (var sale in SalesByTown)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sale sales = Sale.readSale();
            sales.printSales();
        }
    }
}
