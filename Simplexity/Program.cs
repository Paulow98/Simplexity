using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            /** Settings various variables and classes */
            GameManager gamemanager = new GameManager();
            Board board = new Board(gamemanager);
            Player[] players = new Player[] { new Player(), new Player() };
            /** Show the user what he can do and asks him a question */
            Console.WriteLine("Player 1 want to play with wich color?" + "\n" + "1) White" + "\n" + "2)Red");
            /** If's that will check for inputs of the user */
            if (Console.ReadKey().Key == ConsoleKey.NumPad1)
            {
                players[0].AssignColor(Color.White);
                players[1].AssignColor(Color.Red);
            }
            else
            {
                players[0].AssignColor(Color.Red);
                players[1].AssignColor(Color.White);
            }
            /** While that will check if the win conditions are met. */
            while (!board.CheckForWin())
            {
                gamemanager.Update(board, players[gamemanager.CurrentPlayer]);

                board.Draw();
                if (players[gamemanager.CurrentPlayer].Play(board.Columns))
                {
                    gamemanager.NextTurn();
                };
                gamemanager.Update(board, players[gamemanager.CurrentPlayer]);

                board.Draw();
            }
            Console.ReadKey();
        }

    }
}

