using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Board
    {
	private Player[,] board; 
	public int nc {get; private set;} 
	public int nr {get; private set;}  

	public Board(int numcolumns, int numrows)
	
	{
	    nc = numcolumns;
	    nr = numrows;
	    board = new Player[nr,nc];
	  
	}
	
	// Draw initial board.
        public void drawBoard()
        { 
            
            int  i, j;
         
            for (i = 0; i < nr; i++ )
            {
                   Console.Write("  ");
                for (j = 0; j < nc; j++ )
                {
                   if (board[i, j] == Player.Undefined) {
		              Console.Write("_ ");
		           } 
                   else if (board[i, j] == Player.One) { 
                      Console.Write("☻ ");
                   } else {
                      Console.Write("☺ ");
                   }
               }

               Console.WriteLine(); 	
            }
            Console.Write("  ");
            for (j = 0; j < nc; j++ )
	    {
                Console.Write( j + 1 + " ");
	    }
		

        }

        public int updateBoard(Player player, int numcol)
        { 
            int row;

       	//iterate over rows and check if spot is occupied 
            for (row = nr-1; row >= 0; row--)
            {
		if (board[row, numcol] == Player.Undefined) {
	  	    board[row, numcol] = player;
		    return row;
		}
            }

	    return -1;

        }

	public Player getAt(int row, int column)
	{
		return board[row, column];	
	
	}

}
