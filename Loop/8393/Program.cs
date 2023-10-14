namespace _8393
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            int num = Int32.Parse(input);
            int sum = 0;

            while (num > 0)
            {
                sum += num;
                num--;
            }

            Console.WriteLine("{0}", sum);
        }
    }
}