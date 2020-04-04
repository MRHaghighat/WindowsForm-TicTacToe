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
        Model.TicTacToe Game;
        public Start()
        {
            InitializeComponent();
            Set();
        }

        public void Set()
        {
            Game = new Model.TicTacToe();
            board1.Set(Game);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiStart_Click(object sender, EventArgs e)
        {
            Set();
        }

        private void board1_OnGetWinner(object sender, EventArgs e)
        {
            if(MessageBox.Show("Winner is "+ Game.GetWinner()+"\nDo you want to start again?"
                ,""
                , MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                Set();
            }
        }
    }
}
