namespace _2588
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            int c = a * (b % 10);
            int d = a * ((b / 10) % 10);
            int e = a * ((b / 10) / 10);

            Console.WriteLine("{0}", c);
            Console.WriteLine("{0}", d);
            Console.WriteLine("{0}", e);
            Console.WriteLine("{0}", c + d * 10 + e * 100);
        }
    }
}