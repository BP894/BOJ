namespace _2562
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int index = 0;

            for(int i = 1; i <= 9; i++)
            {
                int num = int.Parse(Console.ReadLine()!);
                if(num > max)
                {
                    max = num;
                    index = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(index);
        }
    }
}