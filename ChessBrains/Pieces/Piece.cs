namespace ChessBrains;

public abstract class Piece
{
    public bool isWhite { get; }

    protected Piece(bool isWhite)
    {
        this.isWhite = isWhite;
    }
}