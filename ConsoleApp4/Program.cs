using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("++, -- program : ");
            a = int.Parse(Console.ReadLine());
            int b = a, c = a;
            for(int i = 0; i < 5; i++)
            {
                ++b;
                Console.WriteLine($"{b}");
            }
            Console.WriteLine("");
            int l = 0;
            while(l != 5)
            {
                --c;
                Console.WriteLine($"{c}");
                ++l;
            }
        }
    }
}
