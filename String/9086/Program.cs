using System.Text;

namespace _9086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            StringBuilder answer = new StringBuilder();
            for(int i = 0; i < T; i++)
            {
                string t = Console.ReadLine()!;
                answer.Append(t.First());
                answer.Append(t.Last());
                answer.AppendLine();
            }
            Console.WriteLine(answer);
        }
    }
}