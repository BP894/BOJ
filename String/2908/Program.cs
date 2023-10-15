namespace _2908
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()!.Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            ReverseNumber(ref A);
            ReverseNumber(ref B);

            Console.WriteLine(A > B ? A : B);
        }
        static void ReverseNumber(ref int num)
        {
            num = num / 100 + ((num % 100) / 10) * 10 + (num % 10) * 100;
        }
    }
}