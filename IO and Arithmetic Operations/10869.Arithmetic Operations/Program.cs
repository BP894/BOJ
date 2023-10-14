namespace _10869.Arithmetic_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = Int32.Parse(input[0]);
            int b = Int32.Parse(input[1]);

            Console.Write("{0}\n{1}\n{2}\n{3}\n{4}", a + b, a - b, a * b, a / b, a % b);
        }
    }
}