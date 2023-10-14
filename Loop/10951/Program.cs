using System.Text;

namespace _10951
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();

                if (input is null)
                    break;

                string[] inputs = input.Split(' ');
                int A = int.Parse(inputs[0]);
                int B = int.Parse(inputs[1]);

                answer.AppendLine((A + B).ToString());
            }
            Console.WriteLine(answer);
        }
    }
}