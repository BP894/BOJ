namespace _10810
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] NM = Console.ReadLine()!.Split(' ');
            int N = int.Parse(NM[0]);
            int M = int.Parse(NM[1]);

            int[] baskets = new int[N];

            for(int a = 0; a < M; a++)
            {
                string[] ijk = Console.ReadLine()!.Split(' ');
                int i = int.Parse(ijk[0]);
                int j = int.Parse(ijk[1]);
                int k = int.Parse(ijk[2]);

                for(int b = i; b <= j; b++)
                {
                    baskets[b - 1] = k; 
                }
            }
            
            foreach(int ball in baskets) 
            {
                Console.Write(ball + " ");
            }
        }
    }
}