using ChessBrains;

namespace ChessBrains_Test;

public class Cell_Test
{
    [Fact]
    public void Cell_Creation()
    {
        var examplePiece = new Pawn(true);
        const int x = 8;
        const int y = 8;
        
        var cell = new Cell(x, y, examplePiece);
        Assert.Equal(y, cell.y);
        Assert.Equal(x, cell.x);
        Assert.Equal(examplePiece, cell.occupantPiece);
    }
}