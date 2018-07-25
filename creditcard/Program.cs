using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creditcard
{
    class Program
    {
        static void Main(string[] args)
        {
            string ccnumber = Console.ReadLine();
            //378282246310005
            int temp1 = 0;
            int temp2 = 0;
            int dd = ccnumber.Length;
            Console.WriteLine(dd);
            for (int i = 1; i < ccnumber.Length; i = i + 2)
            {
                //temp1 = temp1 + (ccnumber[i] * 2) % 10;

                double xx =char.GetNumericValue(ccnumber,i);
                int n = Convert.ToInt32(xx)*2;

                if (n > 10)
                {
                    int b = (n - n % 10) / 10;
                    int a = n % 10;
                    temp1 = temp1 + a + b;
                }
                else
                {
                    temp1 = temp1 + n;
                }

                Console.WriteLine(ccnumber[i]);
            }
            for (int i = 0; i < ccnumber.Length; i = i + 2)
            {
                double xx = char.GetNumericValue(ccnumber, i);
                int n = Convert.ToInt32(xx);
                temp2 = temp2 + n;
            }

            Console.WriteLine(temp1+temp2);
        }
    }
}
