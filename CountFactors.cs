using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(CountFactors(4));
        }
        public static int CountFactors(int num)
        {
            num = 6;
            int Count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Count++;
                }
            }
            return Count;

        }
    }
}
