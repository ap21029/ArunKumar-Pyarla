using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
       public static int CountDigits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                count++;
            }
            return count;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountDigits(123));
        }
        
    }
}
