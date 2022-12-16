using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 54093422;
            double b = 3.54;
            Console.WriteLine("{0}, {1}", a, b);
            Console.WriteLine("a = {0}, 0Xa = {0:X}", a);
            Console.WriteLine("b = {0} = {0:E}", b);
            Console.WriteLine("a = {0:X} = {0:E} = {0:N} = {0:C}", a);
            Console.WriteLine(a + b);
        }
    }
}
