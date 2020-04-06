using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicTacToe.Controls
{
    public partial class Board : UserControl
    {
        public event EventHandler OnPlayed, OnGetWinner;
        public Model.Bead Winner
        {
            get => Game.Winner;
        }

        private Model.TicTacToe Game;

        public Board()
        {
            InitializeComponent();
            Reset();
        }

        public void Reset(Model.Bead bead=null)
        {
            Game = new Model.TicTacToe(3, bead);
            Set();
        }

        private void Set()
        {
            if(Game!=null)
            {
                cell1.Bead = Game.Board.GetFromBoard(0);
                cell2.Bead = Game.Board.GetFromBoard(1);
                cell3.Bead = Game.Board.GetFromBoard(2);
                cell4.Bead = Game.Board.GetFromBoard(3);
                cell5.Bead = Game.Board.GetFromBoard(4);
                cell6.Bead = Game.Board.GetFromBoard(5);
                cell7.Bead = Game.Board.GetFromBoard(6);
                cell8.Bead = Game.Board.GetFromBoard(7);
                cell9.Bead = Game.Board.GetFromBoard(8);
            }
        }

        private void cell_OnSelectCell(object sender, EventArgs e)
        {
            Cell cell = (Cell)sender;
            cell.Bead = Game.Play(cell.CellIndex);
            if (!Game.IsContinuous)
            {               
                OnPlayed?.Invoke(this, new EventArgs());
            }
            else
            {
                OnPlayed?.Invoke(this, new EventArgs());
                OnGetWinner?.Invoke(this, new EventArgs());
            }
        }

        public void Save(string path)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Model.Bead b in Game.Board.GetOnBoardBeads)
                stringBuilder.Append(b.Symbol);

            stringBuilder.Append(Game.TurnTaken.Symbol);

            File.WriteAllText(path, stringBuilder.ToString());
        }

        public void LoadGame(string path)
        {
            string g = File.ReadAllText(path);

            if(g.Length>9 && g.Length<11)
            {
                Game = new Model.TicTacToe(3);
                Game.Set(g.Substring(0, 9), g[9]);
                Set();
                if(Game.IsContinuous)
                    OnGetWinner?.Invoke(this, new EventArgs());
            }
        }
    }
}
