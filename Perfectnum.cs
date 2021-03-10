using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        public static int Perfect(int num)
        {

            int sum = 0;
            int copy = num;
            while (num > 0)
            {
                int c = num % 10;
                sum = sum + c;
                num /= 10;
            }
            return sum;
        }
        public static bool Isperfect(int num)
        {
            return num == Perfect(num);
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Isperfect(8));

            Console.WriteLine(Isperfect(26));

        }
    }
}

    

