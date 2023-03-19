using ChessBrains;

namespace ChessBrains_Test;

public class Board_Test
{

    [Theory]
    [InlineData(8, 8)]
    public void Board_Setup(int x, int y)
    {
        var board = new Board();
        Assert.Empty(board.Cells);
        
        board.ResetPieces();
        foreach (var cell in board.Cells)
        {
            
        }
    }
}