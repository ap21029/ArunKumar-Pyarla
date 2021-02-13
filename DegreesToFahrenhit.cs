using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit, celsius;
            celsius = 13;
            fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit is: " + fahrenheit);
        }
    }
}
