namespace _9498
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int score = Int32.Parse(input);

            if (score >= 90 && score < 101)
                Console.Write("A");
            if (score >= 80 && score < 90)
                Console.Write("B");
            if (score >= 70 && score < 80)
                Console.Write("C");
            if (score >= 60 && score < 70)
                Console.Write("D");
            if (score < 60)
                Console.Write("F");
        }
    }
}