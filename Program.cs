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
	
	// Plays the game using a while loop until one of the check methods returns.
	static void play(Board board)
	{
		Game game = new Game(board);
           	string[] colors = {"X","O"};
		int i = 0;
		while (true) {
			board.drawBoard();
			Console.WriteLine();
			Console.WriteLine("Please choose column to play: ");
			int numcol = Convert.ToInt32(Console.ReadLine());
			string color = colors[i];
			int row = board.updateBoard(color, numcol);
			if (row != -1) {
				if (game.checkHorizontal(row, color)) {
					board.drawBoard();
					Console.WriteLine();
					Console.WriteLine("Woohoo! Player " + color + " wins!");
					return;			
				} else if (game.checkVertical(numcol, color)) {
					board.drawBoard();
					Console.WriteLine();
					Console.WriteLine("Woohoo! Player " + color + " wins!");
					return;			
				} else if (game.checkDiagonalRtl(row, numcol, color)) {
					board.drawBoard();
					Console.WriteLine();
					Console.WriteLine("Woohoo! Player " + color + " wins!");
					return;			
				} else if (game.checkDiagonalLtr(row, numcol, color)) {
					board.drawBoard();
					Console.WriteLine();
					Console.WriteLine("Woohoo! Player " + color + " wins!");
					return;			
				}

			    	i = 1-i;
			} else {
			    Console.WriteLine("This column is full, please select another one");
	
			}
		}
		
	}
    }
