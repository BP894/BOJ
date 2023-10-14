namespace _10950
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine()!);
            int[] results = new int[T];
            
            for(int i = 0; i < T; i++)
            {
                string[] inputs = Console.ReadLine()!.Split(' ');
                int A = int.Parse(inputs[0]);
                int B = int.Parse(inputs[1]);

                results[i] = A + B;
            }

            for(int i = 0; i < T; i++)
                Console.WriteLine(results[i]);
        }
    }
}