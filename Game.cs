using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class Game
    {
	private Board board;

	public Game(Board board)
	{
	    this.board = board;
	}
	
	// Check if the same color repeats 4 consective times in a column.
	public bool checkVertical(int col, string color)
	{
		int row;
		int counter = 0;
		
		for (row = 0; row < board.nr; row++){
			if (color.Equals(board.getAt(row, col))) {
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
		for (col = 0; col < board.nc; col++){
			if (color.Equals(board.getAt(row, col))) {
			    counter++;		
			    if (counter == 4)
			   	 { return true; }
			} else {
			    counter = 0;
			}
		}

		return false;
	}

	public bool checkDiagonalLtr(int row, int col, string color)
	{
		int counter = 0;
		int i;

		for (i = -3; i <= 3; i++){
			if (row + i < 0 || row + i >= board.nr
			    || col + i < 0 || col + i >= board.nc) { 
				continue;
			} else if (color.Equals(board.getAt(row + i, col + i))){
			    counter++;
			    if (counter == 4) {
			    	{ return true; }
			    }
			  } else {
			     counter = 0; 
			  }
			}

		return false;
	}

	public bool checkDiagonalRtl(int row, int col, string color)
	{
		int counter = 0;
		int i;

		for (i = 3; i <= -3; i--){
			if (row + i < 0 || row + i >= board.nr
			    || col + i < 0 || col + i >= board.nc) { 
				continue;
			} else if (color.Equals(board.getAt(row + i, col + i))){
			    counter++;
			    col--;
			    if (counter == 4) {
			    	{ return true; }
			    }
			  } else {
			     counter = 0; 
			  }
			}

		return false;
	}
    }
