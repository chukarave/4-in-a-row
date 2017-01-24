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

        public void drawboard()
        { 
            
            int  i, j;
         
            for (i = 0; i < nr; i++ )
            {
                for (j = 0; j < nc; j++ )
                {
                   if (board[i, j] == null)
		   {
		   
                    Console.Write("n");
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

        public bool updateboard(string color, int numcol)
        { 
            int row;
//	    bool updated = false;

       	//iterate over rows and check if spot is occupied 
            for (row = nr-1; row >= 0; row--)
            { 
			if (board[row, numcol] == null) 
			{
		  	    board[row, numcol] = color;
			    return true;
			}
            }

	    return false;

        }


    }
