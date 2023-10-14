namespace _25304
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input_1 = Console.ReadLine()!;
            string input_2 = Console.ReadLine()!;

            int totalSum = Int32.Parse(input_1);
            int numbersType = Int32.Parse(input_2);

            int sum = 0;
            for (int i = 0; i < numbersType; i++)
            {
                string[] tmp = Console.ReadLine()!.Split();
                int[] type = Array.ConvertAll(tmp, Int32.Parse);

                sum += type[0] * type[1];
            }
            if (sum == totalSum)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}