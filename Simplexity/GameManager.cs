using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    /** Enums to handle the colors. */
    public enum Color
    {
        White, Red, None
    }
    /** Enums to handle the shapes. */
    public enum Shape
    {
        Round, Square, None
    }
    /** Class that handles almost all of the game related variables and info. */
    class GameManager
    {
        /* Various variables for storing info. */
        private int currentPlayer = 0;
        private Color currentPlayerColor = Color.None;
        /* Read only propertys */
        public int CurrentPlayer { get { return this.currentPlayer; }  }
        public Color CurrentPlayerColor { get { return this.currentPlayerColor; } }
        private Player[] players = new Player[2] { new Player(), new Player() };

        /** Method that changes that cycles the player's turn. */
        public void NextTurn()
        {
                if (currentPlayer == 1)
                    currentPlayer = 0;
                else if (currentPlayer == 0)
                    currentPlayer = 1;
        }
        /** Updates the board. */
        public void Update(Board board, Player player)
        {
            this.currentPlayerColor = player.Color;
            board.shapeC = player.shapeC;
            board.posC = player.posC;
        }
        
    }
}
