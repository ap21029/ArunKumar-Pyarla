using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    
             class MaxNumber
        {
            static void Main(string[] args)
            {
                Console.WriteLine(MaxDigitOfNum(896));
            }
            public static int MaxDigitOfNum(int v)
            {
                int max = v % 10;
                while (v > 0)
                {
                    int digit = v % 10;
                    if (max < digit)
                    {
                        max = digit;
                    }
                    v /= 10;
                }
                return max;
            }
    }
}
