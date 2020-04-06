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
        bool mustStop;
        Bead currentBead;
        Board board;

        public Board Board { get => board; }
        public bool IsContinuous { get => HaveWinner(); }
        public Bead Winner
        {
            get
            {
                if (IsContinuous)
                    return GetWinner();
                return null;
            }
        }
        public Bead TurnTaken { get => currentBead; }
        public Bead RecentPlayed { get => DidPlay(); }

        public TicTacToe(int size, Bead bead=null)
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
            mustStop = false;
        }

        public void Set(string b, char cb)
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
            mustStop = false;
        }

        private bool HaveWinner()
        {
            mustStop = board.HaveMatche;
            return mustStop;
        }

        public Bead Play(int CellIndex)
        {
            if (!mustStop && CellIndex > -1 && CellIndex < 9)
            {
                board.SetOnBoard(CellIndex, currentBead);
                WillPlay();
                return DidPlay();
            }
            return board.GetFromBoard(CellIndex);
        }

        private Bead GetWinner()
        {
            if (HaveWinner())
                return DidPlay();
            else
                return null;
        }

        private Bead WillPlay()
        {
            if (currentBead == Bead.X)
                currentBead = Bead.O;
            else
                currentBead = Bead.X;
            return currentBead;
        }

        private Bead DidPlay()
        {
            if (currentBead == Bead.X)
                return Bead.O;
            else
                return Bead.X;
        }
    }
}
