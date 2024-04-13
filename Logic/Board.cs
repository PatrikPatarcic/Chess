namespace Logic
{
    public class Board
    {
        

        
    }

    public class Location
    {
        int[] Row = Enumerable.Range(0, 8).ToArray();
        int[] Coloumn = Enumerable.Range(0, 8).ToArray();
        public Location(int row, int coloumn) 
        {
            Row[row] = row;
            Coloumn[coloumn] = coloumn;
        }

    }

    public abstract class Piece
    {
        bool hasMoved;
        public int Row { get;}
        public int Coloumn { get;}

        enum Color
        {
            Black,
            White
        }

    }
}