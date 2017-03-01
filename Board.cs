using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Board
{
	private Player[,] board;

	public int nc { get; private set; }
	public int nr { get; private set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="Board"/> class.
	/// </summary>
	/// <param name='numcolumns'> Number of columns </param>
	/// <param name='numrows'> Number of rows </param>
	public Board (int numcolumns, int numrows)
	{
		nc = numcolumns;
		nr = numrows;
		board = new Player[nr, nc];
	  
	}
	
	/// <summary>
	/// Draws the board.
	/// </summary>
	public void drawBoard ()
	{ 
            
		int i, j;
         
		for (i = 0; i < nr; i++) {
			Console.Write ("  ");
			for (j = 0; j < nc; j++) {
				if (board [i, j] == Player.Undefined) {
					Console.Write ("_ ");
				} else if (board [i, j] == Player.One) { 
					Console.Write ("☻ ");
				} else {
					Console.Write ("☺ ");
				}
			}

			Console.WriteLine (); 	
        // Draw a line of numbers at bottom of board
		}
		Console.Write ("  ");
		for (j = 0; j < nc; j++) {
			Console.Write (j + 1 + " ");
		}
		

	}

	/// <summary>
	/// Iterate over rows and check if spot is occupied 
 	/// </summary>
	/// <returns> the updated row or -1 </returns>
	/// <param name='player'> player Enum element </param>
	/// <param name='numcol'> column number </param>
	public int updateBoard (Player player, int numcol)
	{ 
		int row;

		for (row = nr-1; row >= 0; row--) {
			if (board [row, numcol] == Player.Undefined) {
				board [row, numcol] = player;
				return row;
			}
		}

		return -1;

	}

	/// <summary>
	/// Gets current position on the board.
	/// </summary>
	/// <returns> Array element in said position. </returns>
	/// <param name='row'> Row. </param>
	/// <param name='column'> Column. </param>
	public Player getAt (int row, int column)
	{
		return board [row, column];	
	
	}

}
