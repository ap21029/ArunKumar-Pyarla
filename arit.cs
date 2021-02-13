using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("enter num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1+num2}\t {num1-num2}\t{num1*num2}\t{num1/num2}\t{num1%num2}");
             
        }
    }
}
