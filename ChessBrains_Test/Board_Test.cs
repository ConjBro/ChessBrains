using ChessBrains;

namespace ChessBrains_Test;

public class Board_Test
{

    [Theory]
    [InlineData(8, 8)]
    public void Board_Setup(int x, int y)
    {
        var correctSetup = new Cell[8,8];

        var board = new Board();
        Assert.Null(board.Cells);

        board.ResetPieces();
        Assert.Equal(board.Cells, correctSetup);
    }
}