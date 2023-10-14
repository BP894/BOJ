namespace _10809
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] alpabets = new int[26];
            for (int i = 0; i < alpabets.Length; i++)
            {
                alpabets[i] = -1;
            }
            string input = Console.ReadLine()!;
            for (int i = 0; i < input.Length; i++)
            {
                if(alpabets[(input[i] - 'a')] == -1)
                    alpabets[(input[i] - 'a')] = i;
            }
            foreach(int alpabet in alpabets)
            {
                Console.Write(alpabet + " ");
            }
        }
    }
}