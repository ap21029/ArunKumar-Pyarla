using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  number1 : ");
            int num1 = int.Parse(Console.ReadLine());//10
            Console.Write("Enter  number2 : ");
            int num2 = int.Parse(Console.ReadLine());//12
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", num1 + num2, num1 - num2, num1 * num2, num1 / num2, num1 % num2);
        }
    }
}
