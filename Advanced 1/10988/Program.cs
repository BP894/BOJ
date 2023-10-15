namespace _10988
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            int split_standard = input.Length / 2;

            string string_01 = input.Substring(0, split_standard);
            string string_02 = input.Substring(input.Length - split_standard);

            string_02 = new string(string_02.Reverse().ToArray());

            if (string_01.Equals(string_02))
                Console.WriteLine("1");
            else
                Console.WriteLine("0");
        }
    }
}