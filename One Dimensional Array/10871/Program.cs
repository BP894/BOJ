using System.Text;

namespace _10871
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine()!.Split(' ');
            int N = int.Parse(inputs[0]);
            int X = int.Parse(inputs[1]);

            string[] A = Console.ReadLine()!.Split(' ');

            StringBuilder answer = new StringBuilder();
            foreach(string a in A)
            {
                if(int.Parse(a) < X)
                    answer.Append(a + " ");
            }
            Console.WriteLine(answer);
        }
    }
}