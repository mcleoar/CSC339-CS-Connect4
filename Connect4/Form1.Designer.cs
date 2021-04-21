namespace Connect4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.newGameButton = new System.Windows.Forms.Button();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonYellow = new System.Windows.Forms.RadioButton();
            this.ChooseColorGroupbox = new System.Windows.Forms.GroupBox();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            this.pictureBoxGameBoard = new System.Windows.Forms.PictureBox();
            this.boardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChooseColorGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(944, 12);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(111, 23);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.Location = new System.Drawing.Point(944, 51);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(111, 23);
            this.ExitGameButton.TabIndex = 1;
            this.ExitGameButton.Text = "Exit Game";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(29, 35);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(55, 21);
            this.radioButtonRed.TabIndex = 2;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonYellow
            // 
            this.radioButtonYellow.AutoSize = true;
            this.radioButtonYellow.Location = new System.Drawing.Point(29, 62);
            this.radioButtonYellow.Name = "radioButtonYellow";
            this.radioButtonYellow.Size = new System.Drawing.Size(69, 21);
            this.radioButtonYellow.TabIndex = 3;
            this.radioButtonYellow.TabStop = true;
            this.radioButtonYellow.Text = "Yellow";
            this.radioButtonYellow.UseVisualStyleBackColor = true;
            // 
            // ChooseColorGroupbox
            // 
            this.ChooseColorGroupbox.Controls.Add(this.radioButtonYellow);
            this.ChooseColorGroupbox.Controls.Add(this.buttonChooseColor);
            this.ChooseColorGroupbox.Controls.Add(this.radioButtonRed);
            this.ChooseColorGroupbox.Location = new System.Drawing.Point(864, 109);
            this.ChooseColorGroupbox.Name = "ChooseColorGroupbox";
            this.ChooseColorGroupbox.Size = new System.Drawing.Size(200, 130);
            this.ChooseColorGroupbox.TabIndex = 4;
            this.ChooseColorGroupbox.TabStop = false;
            this.ChooseColorGroupbox.Text = "Choose who goes first:";
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(60, 101);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(75, 23);
            this.buttonChooseColor.TabIndex = 5;
            this.buttonChooseColor.Text = "Choose";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.ChoosePlayerButton_Click);
            // 
            // pictureBoxGameBoard
            // 
            this.pictureBoxGameBoard.Location = new System.Drawing.Point(60, 90);
            this.pictureBoxGameBoard.Name = "pictureBoxGameBoard";
            this.pictureBoxGameBoard.Size = new System.Drawing.Size(470, 370);
            this.pictureBoxGameBoard.TabIndex = 5;
            this.pictureBoxGameBoard.TabStop = false;
            this.pictureBoxGameBoard.Click += new System.EventHandler(this.pictureBoxGameBoard_Click);
            this.pictureBoxGameBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxGameBoard_Paint);
            // 
            // boardBindingSource
            // 
            this.boardBindingSource.DataSource = typeof(Connect4.Board);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBoxGameBoard);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.ChooseColorGroupbox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Connect 4 - Michael Leonard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ChooseColorGroupbox.ResumeLayout(false);
            this.ChooseColorGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGameBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonYellow;
        private System.Windows.Forms.GroupBox ChooseColorGroupbox;
        private System.Windows.Forms.Button buttonChooseColor;
        private System.Windows.Forms.BindingSource boardBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxGameBoard;
    }
}

