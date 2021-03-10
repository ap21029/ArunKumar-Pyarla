using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
   
         class Prime
        {
            static void Main(string[] args)
            {
                Console.WriteLine(IsPrime(5));
          
            }
            private static bool IsPrime(int j)
            {
                int count = 0;
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                    }
                }
                return count == 1;

            }
    }
}
