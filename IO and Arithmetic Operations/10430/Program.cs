namespace _10430
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = Int32.Parse(input[0]);
            int b = Int32.Parse(input[1]);
            int c = Int32.Parse(input[2]);

            Console.WriteLine("{0}", (a + b) % c);
            Console.WriteLine("{0}", ((a % c) + (b % c)) % c);
            Console.WriteLine("{0}", (a * b) % c);
            Console.WriteLine("{0}", ((a % c) * (b % c)) % c);
        }
    }
}