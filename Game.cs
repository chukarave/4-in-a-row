using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Game
{
	private Board board;

	/// <summary>
	/// Constructor for the <see cref="Game"/> class.
	/// </summary>
	/// <param name='board'> Board object </param>
	public Game(Board board)
	{
		this.board = board;
	}

	/// <summary>
	/// Checks if the same player symbol repeats 4 consective times in a column.
	/// </summary>
	/// <returns> True if sequence of 4 is found </returns>
	/// <param name='col'> Column to check </param>
	/// <param name='player'> player </param>
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

	/// <summary>
	/// Checks if the same player symbol repeats 4 consective times in a row.
	/// </summary>
	/// <returns> True if sequence of 4 is found </returns>
	/// <param name='col'> Column to check </param>
	/// <param name='player'> player </param>
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

	/// <summary>
	/// Checks if the same player symbol repeats 4 consective times diagonally from left to right.
	/// </summary>
	/// <returns> True if sequence of 4 is found </returns>
	/// <param name='row'> Row to start check from </param>
	/// <param name='col'> Column to start check from </param>
	/// <param name='player'> player </param>
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

	/// <summary>
	/// Checks if the same player symbol repeats 4 consective times diagonally from right to left.
	/// </summary>
	/// <returns> True if sequence of 4 is found </returns>
	/// <param name='row'> Row to start check from </param>
	/// <param name='col'> Column to start check from </param>
	/// <param name='player'> player </param>
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

	/// <summary>
	/// Declares the winner.
	/// </summary>
	/// <param name='player'> winning player.</param>
	public void declareWinner(Player player)
	{
		Console.WriteLine();
		Console.WriteLine("✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱"); 
		Console.WriteLine("   ♛♛♛ Player " + player + " wins! ♛♛♛");
		Console.WriteLine("✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱✲✱"); 
		Console.WriteLine();

	}

	/// <summary>
	/// Prints the instructions from file.
	/// </summary>
	public void showHelp()
	{
		string text = File.ReadAllText("instructions.txt");        
		Console.WriteLine(text);

	}

}
