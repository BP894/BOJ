namespace _1008.AB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double a = Double.Parse(input[0]);
            double b = Double.Parse(input[1]);

            Console.Write("{0}", a / b);
        }
    }
}