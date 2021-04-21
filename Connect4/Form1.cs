// Name: Michael Leonard
// CSC339 - Spring 2021
// Assignment 4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Connect4
{

    
    public partial class Form1 : Form
    {
        Board thisGame = new Board();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Init default radio button selection and hide the board until "New Game" is selected
            radioButtonRed.Checked = true;
            pictureBoxGameBoard.Enabled = false;
            pictureBoxGameBoard.Visible = false;
            ChooseColorGroupbox.Visible = false;

            //Get Names from players
            thisGame.player1 = getPlayerName("Player 1");
            thisGame.player2 = getPlayerName("Player 2");
        }

        private void pictureBoxGameBoard_Paint(object sender, PaintEventArgs e)
        {

            

        }

        /*Will prompt the player to enter a name and store in the Board object*/
        public String getPlayerName(string whichPlayer)
        {
            return Interaction.InputBox("Enter the name of " + whichPlayer + ":", "Enter " + whichPlayer + " Name:", "Enter name here", 500, 300);
        }

        /*This function handles when the game board is clicked on*/
        private void pictureBoxGameBoard_Click(object sender, EventArgs e)
        {
            MouseEventArgs eMouse = (MouseEventArgs)e;
            Pen p = new Pen(Color.Black);

            //Choose color based on the player going
            if (thisGame.currentTurn == Board.Player.Red)
                p = new Pen(Color.Red);
            else if (thisGame.currentTurn == Board.Player.Yellow)
                p = new Pen(Color.Yellow);

            //Translate click coordinates into a column number and make the move
            if(thisGame.getMove((eMouse.X / 50) + 1) != -1)
            {
                thisGame.printBoard();
                Console.WriteLine();
                drawBoard((int)Board.boardSize.cols, (int)Board.boardSize.rows);

                //Check for a win after each move
                if (thisGame.checkWin())
                {
                    if(thisGame.currentTurn == Board.Player.Red)
                        MessageBox.Show(string.Format(thisGame.player1 + " Wins!"));
                    else
                        MessageBox.Show(string.Format(thisGame.player2 + " Wins!"));

                    pictureBoxGameBoard.Enabled = false;

                }

                //Change the turn
                thisGame.nextTurn();
            }

            

        }


    /*This function handles when the "New Game" Button is clicked*/
    private void NewGameButton_Click(object sender, EventArgs e)
        {
            thisGame.resetGame();
            radioButtonRed.Text = thisGame.player1;
            radioButtonYellow.Text = thisGame.player2;
            radioButtonRed.ForeColor = Color.Red;
            radioButtonYellow.ForeColor = Color.Gold;
            ChooseColorGroupbox.Visible = true;
            ChooseColorGroupbox.Enabled = true;
            pictureBoxGameBoard.Visible = true;
            pictureBoxGameBoard.Enabled = false;
            drawBoard((int)Board.boardSize.cols, (int)Board.boardSize.rows);
        }

        /*This function handles when the player has selected a going first choice and clicks the "Choose" Button*/
        private void ChoosePlayerButton_Click(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked)
            {
                thisGame.currentTurn = Board.Player.Red;
            }
            else if (radioButtonYellow.Checked)
            {
                thisGame.currentTurn = Board.Player.Yellow;
            }

            //Turn off color choice
            ChooseColorGroupbox.Enabled = false;

            //Make Board interactable
            pictureBoxGameBoard.Enabled = true;
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*This Function will draw the game grid and then fill in circles for each move that has been made*/
        void drawBoard(int cols, int rows)
        {
            //Declare Bitmap and drawing tools with it
            Bitmap bitMapGameBoard = new Bitmap(pictureBoxGameBoard.Width, pictureBoxGameBoard.Height);
            int cellSize = 50;
            Pen penBlack = new Pen(Color.Black);
            SolidBrush solidBrushRed = new SolidBrush(Color.Red);
            SolidBrush solidBrushYellow = new SolidBrush(Color.Yellow);



            Graphics.FromImage(bitMapGameBoard).Clear(Color.White);

            //Draw the horizontal grid lines
            for (int y = 0; y < cols; ++y)
            {
                Graphics.FromImage(bitMapGameBoard).DrawLine(penBlack, 0, y * cellSize, cols * cellSize, y * cellSize);
            }

            //Draw the vertical grid lines
            for (int x = 0; x < rows + 2; ++x)
            {
                Graphics.FromImage(bitMapGameBoard).DrawLine(penBlack, x * cellSize, 0, x * cellSize, rows * cellSize);
            }

            //Draw the game pieces for moves that have been made
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (thisGame.board[j, i] == Board.Player.Red)
                    {
                        Graphics.FromImage(bitMapGameBoard).FillEllipse(solidBrushRed, new Rectangle(j * cellSize, i * cellSize, cellSize, cellSize));
                    }
                    else if (thisGame.board[j, i] == Board.Player.Yellow)
                    {
                        Graphics.FromImage(bitMapGameBoard).FillEllipse(solidBrushYellow, new Rectangle(j * cellSize, i * cellSize, cellSize, cellSize));
                    }

                }

            }

            //Assign the finsihed bitmap to be displayed in the picture box
            pictureBoxGameBoard.Image = bitMapGameBoard;
        }







    }
}
