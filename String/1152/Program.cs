using System.Diagnostics.Tracing;

namespace _1152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!.Trim();
            string[] words = input.Split(' ');
            int answer = words.Length;
            if (words[0].Equals(""))
                answer--;
            Console.WriteLine(answer);
        }
    }
}