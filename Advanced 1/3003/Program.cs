namespace _3003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int KING = 1;
            const int QUEEN = 1;
            const int ROOK = 2;
            const int BISHOP = 2;
            const int KNIGHT = 2;
            const int PAWN = 8;

            string[] input = Console.ReadLine()!.Split(' ');
            int[] pieces = Array.ConvertAll(input, item => int.Parse(item));

            ToRightPieceNumber(ref pieces[0], KING);
            ToRightPieceNumber(ref pieces[1], QUEEN);
            ToRightPieceNumber(ref pieces[2], ROOK);
            ToRightPieceNumber(ref pieces[3], BISHOP);
            ToRightPieceNumber(ref pieces[4], KNIGHT);
            ToRightPieceNumber(ref pieces[5], PAWN);

            foreach (int piece in pieces)
            {
                Console.Write(piece + " ");
            }
            
        }
        static void ToRightPieceNumber(ref int input, int piece)
        {
            input = piece - input;
        }
    }
}