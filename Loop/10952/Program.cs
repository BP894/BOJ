using System.Text;

namespace _10952
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();

            while (true)
            {
                string[] inputs = Console.ReadLine()!.Split(' ');
                int A = int.Parse(inputs[0]);
                int B = int.Parse(inputs[1]);

                if (A == 0 && B == 0)
                    break;

                answer.AppendLine((A + B).ToString());
            }

            Console.WriteLine(answer);
        }
    }
}