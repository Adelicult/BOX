using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y ");
            int b = Convert.ToInt32(Console.ReadLine());
             a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
            Console.WriteLine("b=" + b);
            Console.WriteLine("a=" + a);
            Console.ReadKey();


        }
    }
}
