using System;

namespace _1000.A_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = Int32.Parse(input[0]);
            int b = Int32.Parse(input[1]);

            Console.Write("{0}", a + b);
        }
    }
}