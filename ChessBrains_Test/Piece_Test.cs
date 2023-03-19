using ChessBrains;

namespace ChessBrains_Test;

public class Piece_Test
{

    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Piece_Creation(bool isWhite)
    {
        var pawn = new Pawn(isWhite);
        Assert.IsType<Piece>(pawn);
        Assert.True(pawn.isWhite == isWhite);

        var rook = new Rook(isWhite);
        Assert.IsType<Piece>(rook);
        Assert.True(rook.isWhite == isWhite);

        var knight = new Knight(isWhite);
        Assert.IsType<Piece>(knight);
        Assert.True(knight.isWhite == isWhite);

        var bishop = new Bishop(isWhite);
        Assert.IsType<Piece>(bishop);
        Assert.True(bishop.isWhite == isWhite);

        var king = new King(isWhite);
        Assert.IsType<Piece>(king);
        Assert.True(king.isWhite == isWhite);
        
        var queen = new Queen(isWhite);
        Assert.IsType<Piece>(queen);
        Assert.True(queen.isWhite == isWhite);
    }
}