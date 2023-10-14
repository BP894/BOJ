namespace _25314
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            int num = Int32.Parse(input);

            num /= 4;
            for (int i = 0; i < num; i++)
            {
                Console.Write("long ");
            }
            Console.Write("int");
        }
    }
}