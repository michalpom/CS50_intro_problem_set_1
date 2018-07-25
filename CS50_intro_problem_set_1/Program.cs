using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50_intro_problem_set_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the high of the pyramid?");

            int high = -2;
            do
            {
                var h = Console.ReadLine();
                bool alldigit = h.All(char.IsDigit);

                if (alldigit == true)
                {
                    high = int.Parse(h);
                }

            } while (!(high > 0 && high < 24));


            Console.WriteLine("The high is " + high + " and this is how it looks:");
            int level = high;

            for (int i = 0; i < high; i++)
            {
                string space = new string(' ', level - 1);
                Console.Write(space);
                string brick = new string('#', i + 2);
                Console.Write(brick);
                Console.WriteLine();
                level = level - 1;

            }


        }
    }
}
