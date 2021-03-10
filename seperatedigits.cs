using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        public  string SeparateDigit(int num)
        {
            string str = string.Empty;
            while (num != 0)
            {
                str = str + num % 10 + ",";
                num /= 10;
            }
            return str.Substring(0,str.Length-1)+".";
        }
        static void Main(string[] args)
        {
            Program s = new Program();
            //s.SeperateDigit(123):
            Console.WriteLine(s.SeparateDigit(123));
        }


    }
}
       
