using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Board
    {
	private string[,] board; 
	public int nc {get; private set;} 
	public int nr {get; private set;}  

	public Board(int numcolumns, int numrows)
	
	{
	    nc = numcolumns;
	    nr = numrows;
	    board = new string[nr,nc];
	  
	}
	
	// Draw initial board.
        public void drawBoard()
        { 
            
            int  i, j;
         
            for (i = 0; i < nr; i++ )
            {
                for (j = 0; j < nc; j++ )
                {
                   if (board[i, j] == null)
		   {
		   
                    Console.Write("_");
		   } 
                    Console.Write(board[i, j]+" ");
               }

               Console.WriteLine(); 	
            }
            for (j = 0; j < nc; j++ )
	    {
                Console.Write( j + " ");
	    }
		

        }

        public int updateBoard(string color, int numcol)
        { 
            int row;

       	//iterate over rows and check if spot is occupied 
            for (row = nr-1; row >= 0; row--)
            { 
		if (board[row, numcol] == null) {
	  	    board[row, numcol] = color;
		    return row;
		}
            }

	    return -1;

        }

	public string getAt(int row, int column)
	{
		return board[row, column];	
	
	}

}
