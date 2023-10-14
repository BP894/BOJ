namespace _11720
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string inputs = Console.ReadLine()!;
            int sum = 0;

            foreach (var input in inputs)
            {
                sum += int.Parse(input.ToString());
            }
            Console.WriteLine(sum);
        }
    }
}