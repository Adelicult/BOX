using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3;
            float delta, deltx, delty, deltz, mainx, mainy, mainz;
            Console.WriteLine("Для системы уравнений\na1*x+b1*y+c1*z=d1\na2*x+b2*y+c2*z=d2\na3*x+b3*y+c3*c=d3\nВведите значение a(1,2,3);b(1,2,3);c(1,2,3)");
            a1= int.Parse(Console.ReadLine());
            a2= int.Parse(Console.ReadLine());
            a3= int.Parse(Console.ReadLine());
            b1= int.Parse(Console.ReadLine());
            b2= int.Parse(Console.ReadLine());
            b3= int.Parse(Console.ReadLine());
            c1= int.Parse(Console.ReadLine());
            c2= int.Parse(Console.ReadLine());
            c3= int.Parse(Console.ReadLine());
            d1= int.Parse(Console.ReadLine());
            d2= int.Parse(Console.ReadLine());
            d3= int.Parse(Console.ReadLine());
            Console.WriteLine($"Cистема уравнения:\n{a1}*x+{b1}*y+{c1}*z=d1\n{a2}*x+{b2}*y+{c2}*z=d2\n{a3}*x+{b3}*y+{c3}*c=d3\n" );
            delta = a1 * b2 * c3 + a3 * b1 * c2 + a2 * b3 * c1 - a3 * b2 * c1 - a1 * b3 * c2 - a2 * b1 * c3 ;
            if (delta != 0)
            deltx= d1 * b2 * c3 + d3 * b1 * c2 + d2 * b3 * c1 - d3 * b2 * c1 - d1 * b3 * c2 - d2 * b1 * c3;
            delty= a1 * d2 * c3 + a3 * d1 * c2 + a2 * d3 * c1 - a3 * d2 * c1 - a1 * d3 * c2 - a2 * d1 * c3;
            deltz = a1 * b2 * d3 + a3 * b1 * d2 + a2 * b3 * d1 - a3 * b2 * d1 - a1 * b3 * d2 - a2 * b1 * d3;
            mainx = deltx / delta;
            mainy = delty / delta;
            mainz = deltz / delta;
            Console.WriteLine($"Ответ системы уравнений:x={mainx};y={mainy};z{mainz}\n");
            else
                Console.WriteLine("ERROR");
            Console.ReadKey();
        }
           

        }
    }
}
