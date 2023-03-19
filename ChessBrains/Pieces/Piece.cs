namespace ChessBrains;

public abstract class Piece
{
    public bool isWhite { get; }

    public Piece(bool isWhite)
    {
        this.isWhite = isWhite;
    }
}