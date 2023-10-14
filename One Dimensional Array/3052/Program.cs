using System.Runtime.Intrinsics.X86;

namespace _3052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] isExist = new bool[42];
            int result = 0;

            for(int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine()!);
                num %= 42;
                if (isExist[num] == true)
                    continue;
                result++;
                isExist[num] = true;
            }
            Console.WriteLine(result);
        }
    }
}