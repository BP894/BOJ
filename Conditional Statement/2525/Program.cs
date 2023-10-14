namespace _2525
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()!.Split(' ');
            int h = Int32.Parse(input[0]);
            int m = Int32.Parse(input[1]);

            int ct = Int32.Parse(Console.ReadLine()!);

            m = m + ct;

            if(m >= 60)
            {
                h = h + m / 60;
                m = m % 60;
            }

            if(h >= 24)
            {
                h -= 24;
            }

            Console.Write("{0} {1}", h, m);
        }
    }
}