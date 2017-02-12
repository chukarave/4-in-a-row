using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Board
    {
	string[,] board; 
	int nc;	
	int nr;	

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

	// Check if the same color repeats 4 consective times in a column.
	public bool checkVertical(int col, string color)
	{
		int row;
		int counter = 0;
		for (row = 0; row < nr; row++){
			if (color.Equals(board[row, col])) {
			    counter++;		
			    if (counter == 4)
			   	 { return true; }
			} else {
			    counter = 0;
			}
		}

		return false;
	}
	
	// Check if the same color repeats 4 consective times in a row.
	public bool checkHorizontal(int row, string color)
	{
		int col;
		int counter = 0;
		for (col = 0; col < nc; col++){
			if (color.Equals(board[row, col])) {
			    counter++;		
			    if (counter == 4)
			   	 { return true; }
			} else {
			    counter = 0;
			}
		}

		return false;
	}

    }
