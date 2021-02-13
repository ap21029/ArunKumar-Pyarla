using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Class3
    {
        static void Main(string[] args)
        {
            int[] array = { 100,101,111,110,001};
            Console.WriteLine("Array elements before sorting");
            foreach (int k in array)
            {
                Console.WriteLine(k);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int copy = array[i];
                        array[i] = array[j];
                        array[j] = copy;
                    }
                }
            }
            Console.WriteLine("Array elements after sorting");
            foreach (int k in array)
            {
                Console.WriteLine(k);
            }
        }
    }
}

