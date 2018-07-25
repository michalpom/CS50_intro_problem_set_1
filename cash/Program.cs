using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cash
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double money = -1;
            int r_5 = 0, r_2 = 0, r_1 = 0, r_50 = 0, r_20 = 0, r_10 = 0, r_05 = 0, r_02 = 0, r_01 = 0;
            do
            {
                var h = Console.ReadLine();

                bool isdigit = float.TryParse(h, out float r); //checking 

                if (isdigit == true)
                {
                    money = float.Parse(h);
                }

            } while (!(money > 0));

            while (money > 0)
            {
                if (money >= 5)
                {
                    money = money - 5;
                    counter = counter + 1;
                    r_5 = r_5 + 1;
                }
                else if (money >= 2)
                {
                    money = money - 2;
                    counter = counter + 1;
                    r_2 = r_2 + 1;
                }
                else if (money >= 1)
                {
                    money = money - 1;
                    counter = counter + 1;
                    r_1 = r_1 + 1;
                }
                else if (money >= 0.5)
                {
                    money = money - 0.5;
                    counter = counter + 1;
                    r_50 = r_50 + 1;
                }
                else if (money >= 0.2)
                {
                    money = money - 0.2;
                    counter = counter + 1;
                    r_20 = r_20 + 1;
                }
                else if (money >= 0.1)
                {
                    money = money - 0.1;
                    counter = counter + 1;
                    r_10 = r_10 + 1;
                }
                else if (money >= 0.05)
                {
                    money = money - 0.05;
                    counter = counter + 1;
                    r_05 = r_05 + 1;
                }
                else if (money >= 0.02)
                {
                    money = money - 0.02;
                    counter = counter + 1;
                    r_02 = r_02 + 1;
                }
                else if (money >= 0.01)
                {
                    money = money - 0.01;
                    counter = counter + 1;
                    r_01 = r_01 + 1;
                }
                else
                {
                    money = 0; //to aviod trash
                    break;
                }
            }

            Console.WriteLine("Kasa: {0}, monety: {1} ", money, counter);
            Console.WriteLine("Monety 5zl: {0}", r_5);
            Console.WriteLine("Monety 2zl: {0}", r_2);
            Console.WriteLine("Monety 1zl: {0}", r_1);
            Console.WriteLine("Monety 0,50zl: {0}", r_50);
            Console.WriteLine("Monety 0,20zl: {0}", r_20);
            Console.WriteLine("Monety 0,10zl: {0}", r_10);
            Console.WriteLine("Monety 0,05zl: {0}", r_05);
            Console.WriteLine("Monety 0,02zl: {0}", r_02);
            Console.WriteLine("Monety 0,01zl: {0}", r_01);
        }
    }
}
