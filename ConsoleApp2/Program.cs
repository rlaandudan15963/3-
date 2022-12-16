using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            int a;
            try
            {
                Console.Write("write number : ");
                a = int.Parse(Console.ReadLine());
                if (a > 0) { Console.WriteLine("this number is positive number "); }
                else if (a == 0) { Console.WriteLine("this number is zero"); }
                else if (a < 0) { Console.WriteLine("this number is negative number"); }
            }
            catch { Console.WriteLine("this is not a number"); }       
        }
    }
}
