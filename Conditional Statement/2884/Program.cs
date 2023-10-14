namespace _2884
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Input = Console.ReadLine()!.Split(' ');
            int h = Int32.Parse(Input[0]);
            int m = Int32.Parse(Input[1]);

            m -= 45;

            if (m < 0)
            {
                m = m + 60;
                h--;
            }

            if (h < 0)
            {
                h = h + 24;
            }

            Console.WriteLine($"{h} {m}");
        }
    }
}