﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Controls
{
    public partial class Cell : UserControl
    {
        public event EventHandler OnChangedBead, OnSelectCell;

        public char Bead
        {
            get
            {
                return btnCell.Text[0];
            }
            set
            {
                if (value == 'X')
                    ForeColor = Color.Blue;
                else if (value == 'O')
                    ForeColor = Color.Red;
                else
                    ForeColor = Color.Black;

                btnCell.Text = value.ToString();
                OnChangedBead?.Invoke(this, new EventArgs());
            }
        }

        public int CellIndex { get; set; }

        public Cell()
        {
            InitializeComponent();
        }

        private void btnCell_Click(object sender, EventArgs e)
        {
            OnSelectCell?.Invoke(this, new EventArgs());
        }
    }
}
