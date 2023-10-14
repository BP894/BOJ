namespace _5597
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] students = new int[31];
            for (int i = 0; i < 28; i++)
            {
                int student = Int32.Parse(Console.ReadLine()!);
                students[student] = 1;
            }
            for (int i = 1; i < students.Length; i++)
            {
                if (students[i] != 1)
                    Console.WriteLine(i);
            }
        }
    }
}