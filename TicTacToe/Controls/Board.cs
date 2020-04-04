using System;
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
    public partial class Board : UserControl
    {
        public event EventHandler OnPlayed, OnGetWinner;

        public Model.TicTacToe Game;

        public Board()
        {
            InitializeComponent();
        }

        public void Set(Model.TicTacToe game)
        {
            if (game != null)
            {
                Game = game;
                SetBoard();
            }
        }

        private void SetBoard()
        {
            if(Game!=null)
            {
                cell1.Bead = Game.Board[0];
                cell2.Bead = Game.Board[1];
                cell3.Bead = Game.Board[2];
                cell4.Bead = Game.Board[3];
                cell5.Bead = Game.Board[4];
                cell6.Bead = Game.Board[5];
                cell7.Bead = Game.Board[6];
                cell8.Bead = Game.Board[7];
                cell9.Bead = Game.Board[8];
            }
        }

        private void cell_OnSelectCell(object sender, EventArgs e)
        {
            Cell cell = (Cell)sender;
            cell.Bead = Game.Play(cell.CellIndex);
            if (!Game.HaveWin())
            {               
                OnPlayed?.Invoke(this, new EventArgs());
            }
            else
            {
                OnPlayed?.Invoke(this, new EventArgs());
                OnGetWinner?.Invoke(this, new EventArgs());
            }
        }
    }
}
