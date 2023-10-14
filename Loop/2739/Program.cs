namespace _2739
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine()!);
            int i = 0;

            while(true)
            {
                if (++i >= 10)
                    break;

                Console.WriteLine($"{a} * {i} = {a * i}");
            }
        }
    }
}