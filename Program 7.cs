using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 435;
            string b = a.ToString();
            char[] ab = b.ToCharArray();
            Array.Reverse(ab);
            b = new string(ab);
            int reversed = Convert.ToInt32(b);
            Console.WriteLine("reversed=" + reversed);
            Console.ReadKey();
        }
    }
}
