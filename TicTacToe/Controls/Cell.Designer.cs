namespace TicTacToe.Controls
{
    partial class Cell
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
            this.btnCell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCell
            // 
            this.btnCell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCell.Location = new System.Drawing.Point(0, 0);
            this.btnCell.Name = "btnCell";
            this.btnCell.Size = new System.Drawing.Size(100, 100);
            this.btnCell.TabIndex = 0;
            this.btnCell.UseVisualStyleBackColor = true;
            this.btnCell.Click += new System.EventHandler(this.btnCell_Click);
            // 
            // Cell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCell);
            this.Name = "Cell";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCell;
    }
}
