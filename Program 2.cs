using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the time:");
            Console.Write("hours:");
            float hours = float.Parse(Console.ReadLine());
            if ((hours > 11) | (hours < 0))
            Console.WriteLine("Error");
            Console.ReadKey();
            Console.Write("min:");
            float min = float.Parse(Console.ReadLine());
            if ((min < 0) | (min>59))
            Console.WriteLine("Error");
            Console.ReadKey();
            Console.Write("sek:");
            float sek = float.Parse(Console.ReadLine());
            if ((sek > 59) | (sek < 0))
            Console.WriteLine("Error");
            Console.ReadKey();
            float andle=(hours*3600 + min * 60 + sek)/12/3600*360;
            Console.WriteLine ( andle  + " degree ");
            Console.ReadKey();




            

 
        }
    }
}
