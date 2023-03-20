namespace ChessBrains;

public class Board
{
    private const int MAX_DIMENSION = 8;
    public readonly Cell[,] Cells = new Cell[MAX_DIMENSION,MAX_DIMENSION];
    
    public Board()
    {
    }

    public void ResetPieces()
    {
        // White Pieces
        Cells[0,0] = new Cell(0, 0, new Rook(true));
        Cells[0,1] = new Cell(0, 1, new Knight(true));
        Cells[0,2] = new Cell(0, 2, new Bishop(true));
        Cells[0,3] = new Cell(0, 3, new Queen(true));
        Cells[0,4] = new Cell(0, 4, new King(true));
        Cells[0,5] = new Cell(0, 5, new Bishop(true));
        Cells[0,6] = new Cell(0, 6, new Knight(true));
        Cells[0,7] = new Cell(0, 7, new Rook(true));

        // Black Pieces
        Cells[7,0] = new Cell(7, 0, new Rook(false));
        Cells[7,1] = new Cell(7, 1, new Knight(false));
        Cells[7,2] = new Cell(7, 2, new Bishop(false));
        Cells[7,3] = new Cell(7, 3, new Queen(false));
        Cells[7,4] = new Cell(7, 4, new King(false));
        Cells[7,5] = new Cell(7, 5, new Bishop(false));
        Cells[7,6] = new Cell(7, 6, new Knight(false));
        Cells[7,7] = new Cell(7, 7, new Rook(false));
        
        // White + Black Pawns
        for (var i = 0; i < MAX_DIMENSION; i++)
        {
            Cells[1,i] = new Cell(1, i, new Pawn(true));
            Cells[6,i] = new Cell(6, i, new Pawn(false));
        }

        // Create empty Cells
        for (var i = 2; i < 6; i++) 
        {
            for (var j = 0; j < 8; j++) 
            {
                Cells[i,j] = new Cell(i, j, null);
            }
        }
        
    }
}