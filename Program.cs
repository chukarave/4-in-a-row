using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{

	static void Main(string[] args)
	{
		Board board = new Board(7,7);
		play(board);

	}

	/// <summary>
	/// Plays the game using a while loop until one of the check methods returns.
	/// </summary>
	/// <param name='numcolumns'> board </param>
	static void play(Board board)
	{
		Game game = new Game(board);
		Player[] players = {Player.One, Player.Two};
		int i = 0;
		Console.WriteLine("╔═════════════════╗");
		Console.WriteLine("║  𝑭𝑶𝑼𝑹 𝑰𝑵 𝑨 𝑹𝑶𝑾  ║");
		Console.WriteLine("╚═════════════════╝");

		while (true) {
			Player player = players[i];
			Console.WriteLine();
			Console.WriteLine("   Player " + player);
			board.drawBoard();
			Console.WriteLine();
			char input;
			do {
				Console.WriteLine();
				Console.WriteLine("Please choose column to play or h for instructions: ");
				input = Console.ReadKey().KeyChar;
			} while (input != 'h' && input != 'H' && (input < '1' || input > '7')); 
			if (input == 'h' || input == 'H'){
				Console.WriteLine();
				game.showHelp();
				continue;
			}
			int numcol = (input - '0') - 1;
			int row = board.updateBoard(player, numcol);
			if (row != -1) {
				if (game.checkHorizontal(row, player)) {
					Console.WriteLine();
					board.drawBoard();
					Console.WriteLine(); 
					game.declareWinner(player);
					return;			
				} else if (game.checkVertical(numcol, player)) {
					Console.WriteLine();
					board.drawBoard();
					Console.WriteLine();
					game.declareWinner(player);
					return;			
				} else if (game.checkDiagonalRtl(row, numcol, player)) {
					Console.WriteLine();
					board.drawBoard();
					Console.WriteLine();
					game.declareWinner(player);
					return;			
				} else if (game.checkDiagonalLtr(row, numcol, player)) {
					Console.WriteLine();
					board.drawBoard();
					Console.WriteLine();
					game.declareWinner(player);
					return;			
				}

				i = 1-i;
			} else {
				Console.WriteLine("This column is full, please select another one");

			}
		}

	}
}
