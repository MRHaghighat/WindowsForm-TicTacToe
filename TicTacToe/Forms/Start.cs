using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Forms
{
    public partial class Start : Forms.Master
    {
        public Start()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiStart_Click(object sender, EventArgs e)
        {
            board1.Reset();
        }

        private void board1_OnGetWinner(object sender, EventArgs e)
        {
            if(MessageBox.Show("Winner is "+ board1.Winner.Symbol+"\nDo you want to start again?"
                ,""
                , MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                board1.Reset();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                board1.Save(saveFileDialog.FileName);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                board1.LoadGame(openFileDialog.FileName);
            }
        }
    }
}
