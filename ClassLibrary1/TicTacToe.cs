using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TicTacToe
    {
        Bead currentBead;
        Board board;

        public Board Board { get => board; }
        public Bead Winner { get => GetWinner(); }
        public Bead CurrentPlayer { get => currentBead; }
        public Bead RecentPlayer { get => DidPlay(); }
        public bool IsContinuous { get => GetWinner() == null; }

        public TicTacToe(int size, Bead bead = null)
        {
            currentBead = bead == null ? Bead.X : bead.Name == "X" ? Bead.X : Bead.O;
            Reset(size);
        }

        public void Reset(int size)
        {
            board = new Board(size);
            for (int i = 0; i < size * size; i++)
            {
                board.SetOnBoard(i, new Bead((i + 1).ToString()));
            }
        }

        public void LoadFromString(string b, char cb)
        {
            for (int i = 0; i < 9; i++)
            {
                switch (b[i])
                {
                    case 'X':
                        board.SetOnBoard(i, Bead.X);
                        break;
                    case 'O':
                        board.SetOnBoard(i, Bead.O);
                        break;
                    default:
                        board.SetOnBoard(i, new Bead(b[i].ToString()));
                        break;
                }
            }
            currentBead = cb == 'X' ? Bead.X : Bead.O;
        }

        public Bead Play(int CellIndex)
        {
            if (IsContinuous && CellIndex > -1 && CellIndex < 9)
            {
                board.SetOnBoard(CellIndex, WillPlay());
            }
            return Winner;
        }

        private Bead GetWinner()
        {
            return board.HaveMatche ? DidPlay() : null;
        }

        private Bead WillPlay()
        {
            Bead temp = currentBead;
            currentBead = currentBead == Bead.X ? Bead.O : Bead.X;
            return temp;
        }

        private Bead DidPlay()
        {
            return currentBead == Bead.X ? Bead.O : Bead.X;
        }
    }
}
