using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string product = Console.ReadLine();
            int reminder = 0;
            List<string> result = new List<string>();
            List<int> resultInt = new List<int>();
            number = number.TrimStart('0');
            product = product.TrimStart('0');
            if(number.Length >= product.Length)
            {

                while (true)
                {

                    string strResult = string.Empty;
                    int numberLastNum = int.Parse((number[number.Length - 1].ToString()));
                    int productLastNum = int.Parse((product[product.Length - 1].ToString()));
                    number = number.Remove(number.Length - 1);
                    if (product.Length != 1)
                    {
                        product = product.Remove(product.Length - 1);
                    }
                    else
                    {
                        product = "0";
                    }

                    if (number == "")
                    {
                        int finalResult = numberLastNum + productLastNum + reminder;
                        result.Insert(0, finalResult.ToString());
                        break;
                    }


                    numberLastNum += productLastNum + reminder;
                    reminder = 0;
                    if (numberLastNum >= 10)
                    {
                        reminder = int.Parse(numberLastNum.ToString()[0].ToString());
                        int secondNum = int.Parse(numberLastNum.ToString()[1].ToString());
                        result.Insert(0, secondNum.ToString());
                    }
                    else
                    {
                        strResult = numberLastNum.ToString();
                        result.Insert(0, strResult);
                    }



                }

                Console.WriteLine(string.Join("",result));
            }
            else
            {
                int counter = 0;
                int numCounter = 0;
                int loops = (product.Length - 1) - (number.Length - 1);
                while (numCounter != number.Length)
                {

                    

                    string strResult = string.Empty;


                    if(counter >= loops)
                    {
                        reminder = 0;
                        int numberLastNum = int.Parse((number[numCounter].ToString()));
                        int productLastNum = int.Parse((product[counter].ToString()));

                        int numberProdResult = numberLastNum + productLastNum;
                        if(numberProdResult >= 10)
                        {
                            reminder = int.Parse(numberProdResult.ToString()[0].ToString());
                            resultInt[counter - 1] += reminder;
                            numberProdResult = int.Parse(numberProdResult.ToString()[1].ToString());
                        }
                        resultInt.Add(numberProdResult);
                        numCounter++;
                    }
                    else
                    {
                        resultInt.Add(int.Parse(product[counter].ToString()));
                    }

                    counter++;


                }
                Console.WriteLine(string.Join("", resultInt));

            }
            
        }
    }
}
