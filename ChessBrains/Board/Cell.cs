namespace ChessBrains;

public class Cell
{
    public int y { get; } // Column
    public int x { get; } // Row
    public Piece occupantPiece { get; }

    public Cell(int x, int y, Piece occupantPiece)
    {
        this.x = x;
        this.y = y;
        this.occupantPiece = occupantPiece;
    }
}