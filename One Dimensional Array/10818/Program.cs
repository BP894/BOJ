using System.ComponentModel;

namespace _10818
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine()!);
            string[] inputs = Console.ReadLine()!.Split(' ');
            int min = int.MaxValue; int max = int.MinValue;

            foreach (string input in inputs)
            {
                if(int.Parse(input) < min)
                {
                    min = int.Parse(input);
                }
                if(int.Parse(input) > max)
                {
                    max = int.Parse(input);
                }
            }
            Console.WriteLine($"{min} {max}");
        }
        
    }
}