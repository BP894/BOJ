namespace _2439
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            for(int i = 1; i <= N; i++)
            {
                for(int j = 1; j <= N; j++)
                {
                    if (j < N - i + 1)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}