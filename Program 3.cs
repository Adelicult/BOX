using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many seconds are gone ?");
            int sec = Convert.ToInt32((Console.ReadLine()));
            int hours = (int) (sec / 3600);
            int difference=(sec-(hours*3600));
            int minutes = ((int)(difference / 60));
            Console.WriteLine("Time are gone:" + hours + "hours " + minutes + "minutes ");

        }
    }
}
