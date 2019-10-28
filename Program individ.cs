using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new string('_', 80);
            Console.WriteLine("Enter  author");
            string author = Console.ReadLine();
            Console.WriteLine("Enter title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter  year ");
            string year = Console.ReadLine();
            Console.WriteLine("Enter group");
            string group = Console.ReadLine();
            Console.WriteLine("Enter  author 2");
            string author2 = Console.ReadLine();
            Console.WriteLine("Enter title 2");
            string title2 = Console.ReadLine();
            Console.WriteLine("Enter year 2 ");
            string year2 = Console.ReadLine();
            Console.WriteLine("Enter  group 2");
            string group2 = Console.ReadLine();
            Console.WriteLine("Enter author 3");
            string author3 = Console.ReadLine();
            Console.WriteLine("Enter title 3");
            string title3 = Console.ReadLine();
            Console.WriteLine("Enter year 3 ");
            string year3 = Console.ReadLine();
            Console.WriteLine("Enter group 3");
            string group3 = Console.ReadLine();
            Console.WriteLine(a + "\n" + $"Human Resources Deportive \n" + a + "\n" + $" author" + " |  " + $"title" + "|" + $" year " + "|" + $"group" + "|\n" + a + "\n");
            Console.WriteLine($"{author,-10}" + "|" + $"{title,-10}" + " |  " + $"{year,-10}" + "|" + $"{group,-10}" + "|\n" + a);
            Console.WriteLine($"{author2,-10}" + "|" + $"{title2,-10}" + " |  " + $"{year2,-10}" + "|" + $"{group2,-10}" + "|\n" + a);
            Console.WriteLine($"{author3,-10}" + "|" + $"{title3,-10}" + " |  " + $"{year3,-10}" + "|" + $"{group3,-10}" + "|\n" + a);

        }
    }
}
