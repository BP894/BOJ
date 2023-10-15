namespace _5622
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            int sum = 0;
            foreach (char i in input)
            {
                sum += (i) switch
                {
                    <= 'C' => 2 + 1,
                    <= 'F' => 3 + 1,
                    <= 'I' => 4 + 1,
                    <= 'L' => 5 + 1,
                    <= 'O' => 6 + 1,
                    <= 'S' => 7 + 1,
                    <= 'V' => 8 + 1,
                    <= 'Z' => 9 + 1,
                    _ => 0 + 10
                };
            }
            Console.WriteLine(sum);
        }
    }
}