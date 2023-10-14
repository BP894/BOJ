namespace _18108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int year1 = Int32.Parse(input);
            int year2 = year1 - 2541 + 1998;
            Console.Write("{0}", year2);
        }
    }
}