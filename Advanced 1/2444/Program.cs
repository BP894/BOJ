﻿namespace _2444
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            for(int i = 1; i <= N; i++)
            {
                for(int j = 0; j < N - i; j++)
                    Console.Write(" ");
                for (int j = 0; j < 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            for(int i = N - 1; i >= 1; i--)
            {
                for (int j = 0; j < N - i; j++)
                    Console.Write(" ");
                for(int j = 0; j < 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}