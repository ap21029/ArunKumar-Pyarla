using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        public static string FactorsofNumber(int num)
        {
            string str = string.Empty;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    str = str + i + "\n";
                }
            }
            return str;
        }
        static void Main(string[] args)
        {



            Console.WriteLine(FactorsofNumber(6));
        }


    }
}
