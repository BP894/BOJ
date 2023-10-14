namespace _10813
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input_1 = Console.ReadLine()!.Split();
            int n = Int32.Parse(input_1[0]);
            int m = Int32.Parse(input_1[1]);
            int[] baskets = new int[n];
            for (int a = 0; a < baskets.Length; a++)
            {
                baskets[a] = a + 1;
            }
            for (int a = 0; a < m; a++)
            {
                string[] ij = Console.ReadLine()!.Split();
                int i = Int32.Parse(ij[0]);
                int j = Int32.Parse(ij[1]);

                int tmp = 0;
                tmp = baskets[i - 1];
                baskets[i - 1] = baskets[j - 1];
                baskets[j - 1] = tmp;
            }

            for (int a = 0; a < baskets.Length; a++)
            {
                Console.Write(baskets[a] + " ");
            }
        }
    }
}