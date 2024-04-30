namespace Logic
{
    public class Board
    {
        public int[] Row = Enumerable.Range(0, 8).ToArray();
        public int[] Coloumn = Enumerable.Range(0, 8).ToArray();


    }

    public class Location
    {
        public int Row { get; }
        public int Coloumn { get; }

        public Location(int row, int coloumn) 
        {
            Row = row;
            Coloumn = coloumn;
        }

    }

    

    public enum PlayerColor
    {
        Black,
        White,
        Menu
    }

    public enum PieceType
    {
        King,
        Queen,
        Rook,
        Bishop,
        Knight,
        Pawn
    }

    public class WhoPlaysNext
    {
        public WhoPlaysNext(PlayerColor playerColor)
        {
            switch(playerColor)
            {
                case PlayerColor.Black:
                    return PlayerColor.White;
                case PlayerColor.White:
                    return PlayerColor.Black;
                default: return PlayerColor.Menu;
            }
        }
    }

    public abstract class Piece
    {
        bool hasMoved;
        Location location;
        readonly PlayerColor pc;
        readonly PieceType pt;
    }
}