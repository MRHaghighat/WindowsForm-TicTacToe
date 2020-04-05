using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class TicTacToe
    {
        Bead X = new Bead("X", 'X', System.Drawing.Color.Blue);
        Bead O = new Bead("O", 'O', System.Drawing.Color.Red);
        bool mustStop;
        Bead CurrentBead;
        Bead[] board;

        public Bead[] Board { get=> board; }
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
        public Bead TurnTaken { get => CurrentBead; }
        public Bead RecentPlayed { get => GetPlayedBead(); }

        public TicTacToe()
        {
            Reset();
        }

        public void Reset()
        {
            board = new Bead[9];
            for(int i=0; i<9; i++)
            {
                board[i] = new Bead((i+1).ToString());
            }
            CurrentBead = X;
            mustStop = false;
        }

        public void Set(string b, char cb)
        {
            for (int i = 0; i < 9; i++)
            {
                switch (b[i])
                {
                    case 'X':
                        board[i] = X;
                        break;
                    case 'O':
                        board[i] = O;
                        break;
                    default:
                        board[i] = new Bead(b[i].ToString());
                        break;
                }
            }

            CurrentBead = cb == 'X' ? X : O;
            mustStop = false;
        }

        private bool HaveWinner()
        {
            mustStop = board[0] == board[1] && board[1] == board[2]
                || board[3] == board[4] && board[4] == board[5]
                || board[6] == board[7] && board[7] == board[8]
                || board[0] == board[3] && board[3] == board[6]
                || board[1] == board[4] && board[4] == board[7]
                || board[2] == board[5] && board[5] == board[8]
                || board[0] == board[4] && board[4] == board[8]
                || board[2] == board[4] && board[4] == board[6];

            return mustStop;
        }

        public Bead Play(int CellIndex)
        {
            if (!mustStop && CellIndex > -1 && CellIndex < 9)
            {
                board[CellIndex] = CurrentBead;
                GetTurn();
                return GetPlayedBead();
            }
            return board[CellIndex];
        }

        private Bead GetWinner()
        {
            if (HaveWinner())
                return GetPlayedBead();
            else
                return null ;
        }

        private Bead GetTurn()
        {
            if (CurrentBead == X)
                CurrentBead = O;
            else
                CurrentBead = X;
            return CurrentBead;
        }

        private Bead GetPlayedBead()
        {
            if (CurrentBead == X)
                return O;
            else
                return X;
        }
    }
}
