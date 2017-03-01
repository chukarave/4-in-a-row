using System;
using System.IO;
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
	
	// Check if the same player symbol repeats 4 consective times in a column.
	public bool checkVertical(int col, Player player)
	{
		int row;
		int counter = 0;
		
		for (row = 0; row < board.nr; row++){
			if (player.Equals(board.getAt(row, col))) {
			    counter++;		
			    if (counter == 4)
			   	 { return true; }
			} else {
			    counter = 0;
			}
		}

		return false;
	}
	
	// Check if the same player symbol repeats 4 consective times in a row.
	public bool checkHorizontal(int row, Player player)
	{
		int col;
		int counter = 0;
		for (col = 0; col < board.nc; col++){
			if (player.Equals(board.getAt(row, col))) {
			    counter++;		
			    if (counter == 4)
			   	 { return true; }
			} else {
			    counter = 0;
			}
		}

		return false;
	}

	public bool checkDiagonalLtr(int row, int col, Player player)
	{
		int counter = 0;
		int i;

		for (i = -3; i <= 3; i++){
			if (row + i < 0 || row + i >= board.nr
			    || col + i < 0 || col + i >= board.nc) { 
				continue;
			} else if (player.Equals(board.getAt(row + i, col + i))){
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

	public bool checkDiagonalRtl(int row, int col, Player player)
	{
		int counter = 0;
		int i;

		for (i = 3; i <= -3; i--){
			if (row + i < 0 || row + i >= board.nr
			    || col + i < 0 || col + i >= board.nc) { 
				continue;
			} else if (player.Equals(board.getAt(row + i, col + i))){
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
    
    public void callWinner(Player player)
    {
        Console.WriteLine();
	    Console.WriteLine("✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱"); 
		Console.WriteLine("   ♛♛♛ Player " + player + " wins! ♛♛♛");
		Console.WriteLine("✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱"); 
        Console.WriteLine();

    }

    public void showHelp()
    {
        string text = File.ReadAllText("instructions.txt");        
        Console.WriteLine(text);

    }

}
