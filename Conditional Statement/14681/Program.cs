namespace _14681
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            if (a > 0)
            {
                if (b > 0)
                    Console.Write("1");
                if (b < 0)
                    Console.Write("4");
            }

            if (a < 0)
            {
                if (b > 0)
                    Console.Write("2");
                if (b < 0)
                    Console.Write("3");
            }
        }
    }
}