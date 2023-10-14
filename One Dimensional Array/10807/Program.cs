namespace _10807
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input_1 = Console.ReadLine()!;
            int num_1 = Int32.Parse(input_1);

            string[] input_2 = Console.ReadLine()!.Split(' ');
            int[] num_2 = Array.ConvertAll(input_2, Int32.Parse);

            string input_3 = Console.ReadLine()!;
            int num_3 = Int32.Parse(input_3);

            int result = 0;
            foreach (int i in num_2)
                if (i == num_3)
                    result++;

            Console.WriteLine(result);
        }
    }
}