using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "notepad";
            Console.WriteLine(str.ElementAt(0));
            Console.WriteLine(str.IndexOf('e'));
            Console.WriteLine(str.Contains("so"));
            Console.WriteLine(str.Substring(0));
            Console.WriteLine(str.Substring(1));
            Console.WriteLine(str.Substring(2));
            Console.WriteLine(str.Substring(3));
            Console.WriteLine(str.Substring(4));
            Console.WriteLine(str.Substring(5));
            Console.WriteLine(str.Substring(6));


            Console.WriteLine(str.Length);
            Console.WriteLine(str.Substring(0, str.Length));
            Console.WriteLine(str.Substring(0, str.Length - 1));
            Console.WriteLine(str.Substring(0, str.Length - 2));
            string dob = "9-June-1996";
            string[] res = dob.Split('-');
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.WriteLine(res[2]);

            Console.WriteLine("aaaa".CompareTo("aaaa"));
            Console.WriteLine(str.Equals("otepad"));


        }
    }
}
