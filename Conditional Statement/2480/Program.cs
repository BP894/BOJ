namespace _2480
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] dice = Array.ConvertAll(input, Int32.Parse);
            Array.Sort(dice);

            int count = 0;
            int dice_reward = 0;
            for (int i = 0; i < dice.Length; i++)
                for (int j = i + 1; j < dice.Length; j++)
                    if (dice[i] == dice[j])
                    {
                        count++;
                        dice_reward = dice[i];
                    }

            int reward = 0;
            switch (count)
            {
                case 3:
                    reward = 10000 + 1000 * dice_reward;
                    break;
                case 1:
                    reward = 1000 + 100 * dice_reward;
                    break;
                default:
                    reward = 100 * dice[2];
                    break;
            }

            Console.Write("{0}", reward);
        }
    }
}