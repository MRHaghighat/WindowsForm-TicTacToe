﻿namespace TicTacToe.Controls
{
    partial class InputPlayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbX = new System.Windows.Forms.RadioButton();
            this.rbO = new System.Windows.Forms.RadioButton();
            this.txtPlayerX = new System.Windows.Forms.TextBox();
            this.txtPlayerO = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlColorX = new System.Windows.Forms.Panel();
            this.pnlColorO = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Who wants to start first?";
            // 
            // rbX
            // 
            this.rbX.AutoSize = true;
            this.rbX.Checked = true;
            this.rbX.Location = new System.Drawing.Point(5, 27);
            this.rbX.Name = "rbX";
            this.rbX.Size = new System.Drawing.Size(41, 17);
            this.rbX.TabIndex = 1;
            this.rbX.TabStop = true;
            this.rbX.Text = "X : ";
            this.rbX.UseVisualStyleBackColor = true;
            // 
            // rbO
            // 
            this.rbO.AutoSize = true;
            this.rbO.Location = new System.Drawing.Point(5, 50);
            this.rbO.Name = "rbO";
            this.rbO.Size = new System.Drawing.Size(42, 17);
            this.rbO.TabIndex = 2;
            this.rbO.Text = "O : ";
            this.rbO.UseVisualStyleBackColor = true;
            // 
            // txtPlayerX
            // 
            this.txtPlayerX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerX.Location = new System.Drawing.Point(43, 26);
            this.txtPlayerX.Name = "txtPlayerX";
            this.txtPlayerX.Size = new System.Drawing.Size(198, 20);
            this.txtPlayerX.TabIndex = 3;
            this.txtPlayerX.TextChanged += new System.EventHandler(this.txtPlayer_TextChanged);
            // 
            // txtPlayerO
            // 
            this.txtPlayerO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlayerO.Location = new System.Drawing.Point(43, 49);
            this.txtPlayerO.Name = "txtPlayerO";
            this.txtPlayerO.Size = new System.Drawing.Size(198, 20);
            this.txtPlayerO.TabIndex = 3;
            this.txtPlayerO.TextChanged += new System.EventHandler(this.txtPlayer_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(43, 73);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(198, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlColorX
            // 
            this.pnlColorX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColorX.BackColor = System.Drawing.Color.Blue;
            this.pnlColorX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlColorX.Location = new System.Drawing.Point(245, 26);
            this.pnlColorX.Name = "pnlColorX";
            this.pnlColorX.Size = new System.Drawing.Size(19, 19);
            this.pnlColorX.TabIndex = 5;
            this.pnlColorX.BackColorChanged += new System.EventHandler(this.pnlColor_BackColorChanged);
            this.pnlColorX.Click += new System.EventHandler(this.pnlColor_Click);
            // 
            // pnlColorO
            // 
            this.pnlColorO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColorO.BackColor = System.Drawing.Color.Red;
            this.pnlColorO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColorO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlColorO.Location = new System.Drawing.Point(245, 50);
            this.pnlColorO.Name = "pnlColorO";
            this.pnlColorO.Size = new System.Drawing.Size(19, 19);
            this.pnlColorO.TabIndex = 5;
            this.pnlColorO.BackColorChanged += new System.EventHandler(this.pnlColor_BackColorChanged);
            this.pnlColorO.Click += new System.EventHandler(this.pnlColor_Click);
            // 
            // InputPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlColorO);
            this.Controls.Add(this.pnlColorX);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPlayerO);
            this.Controls.Add(this.txtPlayerX);
            this.Controls.Add(this.rbO);
            this.Controls.Add(this.rbX);
            this.Controls.Add(this.label1);
            this.Name = "InputPlayer";
            this.Size = new System.Drawing.Size(270, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbX;
        private System.Windows.Forms.RadioButton rbO;
        private System.Windows.Forms.TextBox txtPlayerX;
        private System.Windows.Forms.TextBox txtPlayerO;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlColorX;
        private System.Windows.Forms.Panel pnlColorO;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}