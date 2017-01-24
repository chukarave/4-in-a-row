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

	static void play(Board board)
	{
		board.drawboard();
		Console.WriteLine();
		Console.WriteLine("Please choose column to play: ");
		int numcol = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Please enter X or O: ");
		string color = Console.ReadLine();
		board.updateboard(color, numcol);
	}
    }
