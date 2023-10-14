namespace _1546
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] scores = Array.ConvertAll(Console.ReadLine()!.Split(' '), i => int.Parse(i));
            Array.Sort<int>(scores);
            double M = scores[N - 1];

            double sum = 0;
            for(int i = 0; i < scores.Length; i++) 
            {
                double score = Math.Round(scores[i] / M * 100, 2);
                sum += score;
            }

            Console.WriteLine(sum / N);
        }
    }
}