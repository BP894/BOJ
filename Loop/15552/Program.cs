using System.Text;

namespace _15552
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();

            int num = Int32.Parse(Console.ReadLine()!);

            int[] sum = new int[num];
            for (int i = 0; i < num; i++)
            {
                string[] inputs = Console.ReadLine()!.Split();
                int[] numbers = Array.ConvertAll(inputs, Int32.Parse);

                sum[i] = numbers[0] + numbers[1];

                answer.AppendLine(sum[i].ToString());
            }
            Console.WriteLine(answer);
        }
    }
}