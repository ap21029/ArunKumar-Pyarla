using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        public static double AverageOfDigits(int num)
        {
            int sum = 0;

            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
                count++;
            }
            double avg = sum / count;

            return avg;
        }
        static void Main(string[] args)
        { 

            Console.WriteLine(AverageOfDigits(456));
        }
    }
}
