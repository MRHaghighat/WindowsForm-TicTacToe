using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class TicTacToe
    {
        bool mustStop;
        char CurrentBead;
        char[] board;

        public char[] Board { get=> board; }
        public bool IsContinuous { get => HaveWinner(); }
        public char Winner
        {
            get
            {
                if (IsContinuous)
                    return GetWinner();
                return '\0';
            }
        }
        public char TurnTaken { get => CurrentBead; }
        public char RecentPlayed { get => GetPlayedBead(); }

        public TicTacToe()
        {
            Reset();
        }

        public void Reset()
        {
            board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            CurrentBead = 'X';
            mustStop = false;
        }

        public void Set(string b, char cb)
        {
            board = b.ToArray();
            CurrentBead = cb;
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

        public char Play(int CellIndex)
        {
            if (!mustStop && CellIndex > -1 && CellIndex < 9)
            {
                board[CellIndex] = CurrentBead;
                GetTurn();
                return GetPlayedBead();
            }
            return board[CellIndex];
        }

        private char GetWinner()
        {
            if (HaveWinner())
                return GetPlayedBead();
            else
                return '\0' ;
        }

        private char GetTurn()
        {
            if (CurrentBead == 'X')
                CurrentBead = 'O';
            else
                CurrentBead = 'X';
            return CurrentBead;
        }

        private char GetPlayedBead()
        {
            if (CurrentBead == 'X')
                return 'O';
            else
                return 'X';
        }
    }
}
