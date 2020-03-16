using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Interface_Manipulation_Project__SIMP_
{
    class Backend
    {
        static void Functions(string[] args)
        {
            Console.WriteLine(Multi(20, 4));
            Console.WriteLine(Mod(20, 3)[0]);
            Console.WriteLine(Mod(20, 3)[1]);
            Console.WriteLine(Div(20, 3, 3));
            Console.ReadLine();

            long Multi(long number, long multiplier)
            {
                long result = 0;
                for (int i = 0; i < multiplier; i++)
                {
                    result += number;
                }
                return result;
            }

            long[] Mod(long dividend, long divisor)
            {
                long[] result = { dividend, 0 };
                while (result[0] >= divisor)
                {
                    result[0] -= divisor;
                    result[1]++;
                }
                return result;
            }

            int NumberLength(long n)
            {
                if (n >= 0)
                {
                    if (n < 10L) return 1;
                    if (n < 100L) return 2;
                    if (n < 1000L) return 3;
                    if (n < 10000L) return 4;
                    if (n < 100000L) return 5;
                    if (n < 1000000L) return 6;
                    if (n < 10000000L) return 7;
                    if (n < 100000000L) return 8;
                    if (n < 1000000000L) return 9;
                    if (n < 10000000000L) return 10;
                    if (n < 100000000000L) return 11;
                    if (n < 1000000000000L) return 12;
                    if (n < 10000000000000L) return 13;
                    if (n < 100000000000000L) return 14;
                    if (n < 1000000000000000L) return 15;
                    if (n < 10000000000000000L) return 16;
                    if (n < 100000000000000000L) return 17;
                    if (n < 1000000000000000000L) return 18;
                    return 19;
                }
                else
                {
                    if (n > -10L) return 2;
                    if (n > -100L) return 3;
                    if (n > -1000L) return 4;
                    if (n > -10000L) return 5;
                    if (n > -100000L) return 6;
                    if (n > -1000000L) return 7;
                    if (n > -10000000L) return 8;
                    if (n > -100000000L) return 9;
                    if (n > -1000000000L) return 10;
                    if (n > -10000000000L) return 11;
                    if (n > -100000000000L) return 12;
                    if (n > -1000000000000L) return 13;
                    if (n > -10000000000000L) return 14;
                    if (n > -100000000000000L) return 15;
                    if (n > -1000000000000000L) return 16;
                    if (n > -10000000000000000L) return 17;
                    if (n > -100000000000000000L) return 18;
                    if (n > -1000000000000000000L) return 19;
                    return 20;
                }
            }

            decimal Div(long dividend, long divisor, long decimals)
            {
                string result;
                long tempResult = 0;
                long[] store = { dividend, 0 };
                int count = 0;
                string temp = "";
                while (store[0] > 0 && count < decimals)
                {
                    tempResult = Multi(tempResult, 10);
                    store = Mod(store[0] * 10, divisor);
                    count++;
                    tempResult = tempResult + store[1];
                    temp = temp + "0";
                }
                result = temp + Convert.ToString(tempResult);
                //Console.WriteLine(result);

                result = result.Insert((result.Length - count), ",");
                //Console.WriteLine(result);
                return Convert.ToDecimal(result);
            }
        }
    }
}
