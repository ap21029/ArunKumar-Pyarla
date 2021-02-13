using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter rupees:");
            double rupees = Convert.ToDouble(Console.ReadLine());
            double dollars = rupees / 64;
            Console.WriteLine(dollars + " Dollars");
        }

    }
    }

