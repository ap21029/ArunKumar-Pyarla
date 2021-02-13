using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Class3
    {
        static void Main(string[] args)
        {
            int P;
            double R, T, SI;
            P = 15000;
            R = 5;
            T = 0.6;
            SI = (P * R * T) / 100;
            Console.WriteLine("Simple Interest is: " + SI);
        }
    }
}
