using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
        public Customer(string name)
        {
            Name = name;
            Bill = 0;
            ShopList = new Dictionary<string, int>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();
            Dictionary<string, Customer> customers = new Dictionary<string, Customer>();
            int n = int.Parse(Console.ReadLine());
            decimal totalBill = 0.00m;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                if(shop.ContainsKey(input[0]) == false)
                {
                    shop.Add(input[0], decimal.Parse(input[1]));
                }
                else
                {
                    shop[input[0]] = decimal.Parse(input[1]);
                }
            }


            string[] command = Console.ReadLine().Split(new char[] { '-', ',' });

            
            while(command[0] != "end of clients")
            {
                if(shop.ContainsKey(command[1]) == true)
                {
                    Customer currentCustomer = new Customer(command[0]);
                    if (customers.ContainsKey(command[0]) == false)
                    {
                        
                        currentCustomer.ShopList.Add(command[1], int.Parse(command[2]));
                        currentCustomer.Bill += shop[command[1]] * int.Parse(command[2]);
                        customers.Add(command[0], currentCustomer);
                    }
                    else
                    {

                        if (customers[command[0]].ShopList.ContainsKey(command[1]) == false)
                        {
                            customers[command[0]].ShopList.Add(command[1], int.Parse(command[2]));
                        }
                        else
                        {
                            customers[command[0]].ShopList[command[1]] += int.Parse(command[2]);
                        }
                        customers[command[0]].Bill += shop[command[1]] * int.Parse(command[2]);
                    }

                }
                command = Console.ReadLine().Split(new char[] { '-', ',' });
            }

            foreach (var customer in customers.Values.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);

                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
                totalBill += customer.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
