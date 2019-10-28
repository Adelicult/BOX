using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b=Convert.ToDouble(Console.ReadLine());
            double c=Math.Sqrt(a*a+b*b);
            double Perimeter=a+b+c;
            Console.WriteLine("c={0},Perinter={1}",c,Perimeter);
            Console.ReadLine();
        }
    }
}
