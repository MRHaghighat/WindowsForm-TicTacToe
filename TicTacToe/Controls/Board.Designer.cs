namespace TicTacToe.Controls
{
    partial class Board
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cell1 = new TicTacToe.Controls.Cell();
            this.cell2 = new TicTacToe.Controls.Cell();
            this.cell3 = new TicTacToe.Controls.Cell();
            this.cell4 = new TicTacToe.Controls.Cell();
            this.cell5 = new TicTacToe.Controls.Cell();
            this.cell6 = new TicTacToe.Controls.Cell();
            this.cell7 = new TicTacToe.Controls.Cell();
            this.cell8 = new TicTacToe.Controls.Cell();
            this.cell9 = new TicTacToe.Controls.Cell();
            this.SuspendLayout();
            // 
            // cell1
            // 
            this.cell1.CellIndex = 0;
            this.cell1.Location = new System.Drawing.Point(3, 3);
            this.cell1.Name = "cell1";
            this.cell1.Size = new System.Drawing.Size(75, 75);
            this.cell1.TabIndex = 0;
            this.cell1.OnSelectCell += new System.EventHandler(this.cell_OnSelectCell);
            // 
            // cell2
            // 
            this.cell2.CellIndex = 1;
            this.cell2.Location = new System.Drawing.Point(84, 3);
            this.cell2.Name = "cell2";
            this.cell2.Size = new System.Drawing.Size(75, 75);
            this.cell2.TabIndex = 1;
            this.cell2.OnSelectCell += new System.EventHandler(this.cell_OnSelectCell);
            // 
            // cell3
            // 
            this.cell3.CellIndex = 2;
            this.cell3.Location = new System.Drawing.Point(165, 3);
            this.cell3.Name = "cell3";
            this.cell3.Size = new System.Drawing.Size(75, 75);
            this.cell3.TabIndex = 2;
            this.cell3.OnSelectCell += new System.EventHandler(this.cell_OnSelectCell);
            // 
            // cell4
            // 
            this.cell4.CellIndex = 3;
            this.cell4.Location = new System.Drawing.Point(3, 84);
            this.cell4.Name = "cell4";
            this.cell4.Size = new System.Drawing.Size(75, 75);
            this.cell4.TabIndex = 0;
            this.cell4.OnSelectCell += new System.EventHandler(this.cell_OnSelectCell);
            // 
            // cell5
            // 
            this.cell5.CellIndex = 4;
            this.cell5.Location = new System.Drawing.Point(84, 84);
            this.cell5.Name = "cell5";
            this.cell5.Size = new System.Drawing.Size(75, 75);
            this.cell5.TabIndex = 1;
            this.cell5.OnSelectCell += new System.EventHandler(this.cell_OnSelectCell);
            // 
            // cell6
            // 
            this.cell6.CellIndex = 5;
            this.cell6.Location = new System.Drawing.Point(165, 84);
            this.cell6.Name = "cell6";
            this.cell6.Size = new System.Drawing.Size(75, 75);
            this.cell6.TabIndex = 2;
            this.cell6.OnSelectCell += new System.EventHandler(this.cell_OnSelectCell);
            // 
            // cell7
            // 
            this.cell7.CellIndex = 6;
            this.cell7.Location = new System.Drawing.Point(3, 165);
            this.cell7.Name = "cell7";
            this.cell7.Size = new System.Drawing.Size(75, 75);
            this.cell7.TabIndex = 0;
            this.cell7.OnSelectCell += new System.EventHandler(this.cell_OnSelectCell);
            // 
            // cell8
            // 
            this.cell8.CellIndex = 7;
            this.cell8.Location = new System.Drawing.Point(84, 165);
            this.cell8.Name = "cell8";
            this.cell8.Size = new System.Drawing.Size(75, 75);
            this.cell8.TabIndex = 1;
            this.cell8.OnSelectCell += new System.EventHandler(this.cell_OnSelectCell);
            // 
            // cell9
            // 
            this.cell9.CellIndex = 8;
            this.cell9.Location = new System.Drawing.Point(165, 165);
            this.cell9.Name = "cell9";
            this.cell9.Size = new System.Drawing.Size(75, 75);
            this.cell9.TabIndex = 2;
            this.cell9.OnSelectCell += new System.EventHandler(this.cell_OnSelectCell);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cell9);
            this.Controls.Add(this.cell6);
            this.Controls.Add(this.cell3);
            this.Controls.Add(this.cell8);
            this.Controls.Add(this.cell5);
            this.Controls.Add(this.cell2);
            this.Controls.Add(this.cell7);
            this.Controls.Add(this.cell4);
            this.Controls.Add(this.cell1);
            this.Name = "Board";
            this.Size = new System.Drawing.Size(243, 243);
            this.ResumeLayout(false);

        }

        #endregion

        private Cell cell1;
        private Cell cell2;
        private Cell cell3;
        private Cell cell4;
        private Cell cell5;
        private Cell cell6;
        private Cell cell7;
        private Cell cell8;
        private Cell cell9;
    }
}
