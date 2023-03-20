using ChessBrains;

namespace ChessBrains_Test;

public class Board_Test
{
    [Theory]
    [InlineData(8, 8)]
    public void Board_Setup(int x, int y)
    {
        const int MAX_DIMENSION = 8;

        var board = new Board();
        Assert.Equal( new Cell[MAX_DIMENSION,MAX_DIMENSION],board.Cells);
        
        var correctSetup = new Cell[MAX_DIMENSION,MAX_DIMENSION];
        // White Pieces
        correctSetup[0,0] = new Cell(0, 0, new Rook(true));
        correctSetup[0,1] = new Cell(0, 1, new Knight(true));
        correctSetup[0,2] = new Cell(0, 2, new Bishop(true));
        correctSetup[0,3] = new Cell(0, 3, new Queen(true));
        correctSetup[0,4] = new Cell(0, 4, new King(true));
        correctSetup[0,5] = new Cell(0, 5, new Bishop(true));
        correctSetup[0,6] = new Cell(0, 6, new Knight(true));
        correctSetup[0,7] = new Cell(0, 7, new Rook(true));

        // Black Pieces
        correctSetup[7,0] = new Cell(7, 0, new Rook(false));
        correctSetup[7,1] = new Cell(7, 1, new Knight(false));
        correctSetup[7,2] = new Cell(7, 2, new Bishop(false));
        correctSetup[7,3] = new Cell(7, 3, new Queen(false));
        correctSetup[7,4] = new Cell(7, 4, new King(false));
        correctSetup[7,5] = new Cell(7, 5, new Bishop(false));
        correctSetup[7,6] = new Cell(7, 6, new Knight(false));
        correctSetup[7,7] = new Cell(7, 7, new Rook(false));
        
        // White + Black Pawns
        for (var i = 0; i < MAX_DIMENSION; i++)
        {
            correctSetup[1,i] = new Cell(1, i, new Pawn(true));
            correctSetup[6,i] = new Cell(6, i, new Pawn(false));
        }
        
        // Create empty Cells
        for (var i = 2; i < 6; i++) 
        {
            for (var j = 0; j < 8; j++) 
            {
                correctSetup[i,j] = new Cell(i, j, null);
            }
        }

        board.ResetPieces();

        for (var i = 0; i < MAX_DIMENSION; i++)
        {
            for (var j = 0; j < MAX_DIMENSION; j++)
            {
                Assert.Equivalent(correctSetup, board.Cells);
            }
        }
    }
}