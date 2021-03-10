using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class FactorsAvg
    {
        static void Main(string[] args)
        {
            FactorsAvg a = new FactorsAvg();
            Console.WriteLine(a.AverageOfFactor(10));
        }
        public int AverageOfFactor(int num)
        {
            int count = 0;
            int sum = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
            int avg = sum / count;
            return avg;
        }
    }
}
        

