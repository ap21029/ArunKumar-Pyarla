using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Class1
    {
        static void Main(string[] args)
        {

            int[] array = { 9,9,9,9,9};
            Console.WriteLine(array.Length);
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
