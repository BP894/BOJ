using System.Text;

namespace _2675
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            int R = 0;
            string S = "";
            StringBuilder answer = new StringBuilder();

            for (int i = 0; i < T; i++)
            {
                string[] RS = Console.ReadLine()!.Split(' ');
                R = int.Parse(RS[0]);
                S = RS[1];

                foreach (char s in S)
                {
                    for (int j = 0; j < R; j++)
                    {
                        answer.Append(s);
                    }
                }
                answer.AppendLine();
            }
            Console.WriteLine(answer);
        }
    }
}