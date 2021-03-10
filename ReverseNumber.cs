using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        public static double ReverseNumber(int num)
        {
            int rev = 0;
            while(num>0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            return rev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseNumber(246));
        }
        
    }
}
