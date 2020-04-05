namespace TicTacToe.Forms
{
    partial class GetInitiales
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
            this.inputPlayer1 = new TicTacToe.Controls.InputPlayer();
            this.SuspendLayout();
            // 
            // inputPlayer1
            // 
            this.inputPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPlayer1.Location = new System.Drawing.Point(0, 0);
            this.inputPlayer1.Name = "inputPlayer1";
            this.inputPlayer1.Size = new System.Drawing.Size(349, 106);
            this.inputPlayer1.TabIndex = 0;
            // 
            // GetInitiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 106);
            this.Controls.Add(this.inputPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GetInitiales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetInitiales";
            this.ResumeLayout(false);

        }

        #endregion

        public Controls.InputPlayer inputPlayer1;
    }
}