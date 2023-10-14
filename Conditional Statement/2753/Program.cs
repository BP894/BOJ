namespace _2753
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());

            if (input % 4 == 0)
            {
                if (input % 100 != 0 || input % 400 == 0)
                    Console.Write("1");
                else
                    Console.Write("0");
            }
            else
                Console.Write("0");
        }
    }
}