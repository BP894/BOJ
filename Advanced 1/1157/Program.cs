using System.Net.Http.Headers;

namespace _1157
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] alpabet = new int[26];

            string input = Console.ReadLine()!.ToUpper();

            int max = int.MinValue;
            char max_ch = ' ';

            foreach (char ch in input)
                alpabet[ch - 'A']++;

            for (int i = 0; i < alpabet.Length; i++)
            {
                if (alpabet[i] > max )
                {
                    max = alpabet[i];
                    max_ch = (char)(i + 'A');
                }
                else if (max == alpabet[i])
                    max_ch = '?';
            }
            Console.WriteLine(max_ch);
        }
    }
}