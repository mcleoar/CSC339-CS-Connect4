using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Board
    {
        public enum Player { None = 'O', Red = 'R', Yellow = 'Y' }
        public enum boardSize{ cols = 7, rows = 6 }
        public Player[,] board = new Player[(int)boardSize.cols, (int)boardSize.rows];
        bool win = false;
        public Player currentTurn = Player.None;
        public Player goingFirst = Player.None;
        public string player1, player2;


        public int getMove(int moveChoice)
        {
            //Find correct position in the column after the game piece is dropped
            for (int i = 0; i < (int)boardSize.rows; i++)
            {

                //If we find a colored piece then we place the dropped piece above it
                if ((char)board[moveChoice - 1, i] != (char)Player.None)
                {
                    if (i > 0)
                    {
                        board[moveChoice - 1, i - 1] = currentTurn;
                        return 0;
                    }
                    else
                        return -1;
                }
                //If no color is found and the bottom of the board is reached then the game piece is dropped to the bottom of the board
                else if (i == (int)boardSize.rows - 1)
                {
                    board[moveChoice - 1, i] = currentTurn;
                    return 0;
                }
            }
            return -1;
        }

        //This function prints the current state of the board to stdout
        public void printBoard()
        {
            for (int i = 0; i < (int)boardSize.rows; i++)
            {
                for (int j = 0; j < (int)boardSize.cols; j++)
                    Console.Write((char)board[j, i]);

                Console.WriteLine();
            }
        }

        //This function changes the currentTurn variable from red to yellow or vise-versa
        public void nextTurn()
        {
            if (currentTurn == Player.Red)
                currentTurn = Player.Yellow;
            else
                currentTurn = Player.Red;
        }

        //This function returns true is the Player sent in is Yellow or Red and false otherwise
        bool  isColor(Player gamePiece)
        {
            return (gamePiece == Player.Red || gamePiece == Player.Yellow);
        }

        //This function checks the board for a horizontal win.
        bool checkHorizontalWin()
        {
            int count;

            for (int i = 0; i < (int)boardSize.rows; i++)
            {
                count = 0;
                for (int j = 0; j < (int)boardSize.cols; j++)
                {
                    if (board[j, i] == currentTurn)
                        count++;
                    else
                        count = 0;

                    if (count == 4)
                        return true;
                }
            }
            return false;
        }

        //This function checks the board for a vertical win
        bool checkVerticalWin()
        {
            int count;

            for (int i = 0; i < (int)boardSize.cols; i++)
            {
                count = 0;
                for (int j = 0; j < (int)boardSize.rows; j++)
                {
                    if (board[i, j] == currentTurn)
                        count++;
                    else
                        count = 0;

                    if (count == 4)
                        return true;
                }
            }
            return false;
        }

        //This function checks the board for a diagonal win in the downward (top left to bottom right) direction.
        bool checkDownDiagonalWin()
        {
            int count = 0;
            bool stillTraversing = true;
            int startRow = (int)boardSize.rows - 4, startCol = 0;

            while (stillTraversing)
            {
                count = 0;
                for (int i = startRow, j = startCol; i < (int)boardSize.rows && j < (int)boardSize.cols; i++, j++)
                {
                    if (board[j, i] == currentTurn)
                        count++;
                    else
                        count = 0;

                    if (count == 4)
                        return true;
                }
                if (startRow > 0)
                    startRow--;
                else if (startCol < (int)boardSize.cols - 4)
                    startCol++;
                else
                    stillTraversing = false;
            }
            return false;
        }

        //This function checks the board for a diagonal win in the upward (bottom left to top right) direction.
        bool checkUpDiagonalWin()
        {
            int count = 0;
            bool stillTraversing = true;
            int startRow = 3, startCol = 0;

            while (stillTraversing)
            {
                count = 0;
                for (int i = startRow, j = startCol; i >= 0 && j < (int)boardSize.cols; i--, j++)
                {
                    if (board[j, i] == currentTurn)
                        count++;
                    else
                        count = 0;

                    if (count == 4)
                        return true;
                }
                if (startRow < (int)boardSize.rows - 1)
                    startRow++;
                else if (startCol < (int)boardSize.cols - 4)
                    startCol++;
                else
                    stillTraversing = false;
            }
            return false;
        }

        //This function checks the board for a win in any possible way
        public bool checkWin()
        {
            if (checkHorizontalWin() || checkVerticalWin() || checkUpDiagonalWin() || checkDownDiagonalWin())
            {
                win = true;
                return win;
            }
            return false;
        }

        //This function will reset to board to an empty state with no game pieces on it, set the currentTurn to None, and reset the win variable to false.
        public void resetGame()
        {
            currentTurn = Player.None;
            board = new Player[(int)boardSize.cols, (int)boardSize.rows];

            //Initialize gameboard to contain only None Player enums
            for (int i = 0; i < (int)boardSize.rows; i++)
            {
                for (int j = 0; j < (int)boardSize.cols; j++)
                    this.board[j,i] = Board.Player.None;
            }

            win = false;
        }









    }
}
