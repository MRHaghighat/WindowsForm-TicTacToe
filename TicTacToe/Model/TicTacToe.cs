using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class TicTacToe
    {
        public char[] Board;
        public char CurrentBead;
        bool mustStop;

        public TicTacToe()
        {
            Set();
        }

        public void Set()
        {
            Board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            CurrentBead = 'X';
            mustStop = false;
        }

        public void Set(string b, char cb)
        {
            Board = b.ToArray();
            CurrentBead = cb;
            mustStop = false;
        }

        public bool HaveWin()
        {
            mustStop = Board[0] == Board[1] && Board[1] == Board[2]
                || Board[3] == Board[4] && Board[4] == Board[5]
                || Board[6] == Board[7] && Board[7] == Board[8]
                || Board[0] == Board[3] && Board[3] == Board[6]
                || Board[1] == Board[4] && Board[4] == Board[7]
                || Board[2] == Board[5] && Board[5] == Board[8]
                || Board[0] == Board[4] && Board[4] == Board[8]
                || Board[2] == Board[4] && Board[4] == Board[6];

            return mustStop;
        }

        public char Play(int CellIndex)
        {
            if (!mustStop && CellIndex > -1 && CellIndex < 9)
            {
                Board[CellIndex] = CurrentBead;
                GetTurn();
                return GetPlayedBead();
            }
            return Board[CellIndex];
        }

        public char GetWinner()
        {
            if (HaveWin())
                return GetPlayedBead();
            else
                return '\0' ;
        }

        public char GetTurn()
        {
            if (CurrentBead == 'X')
                CurrentBead = 'O';
            else
                CurrentBead = 'X';
            return CurrentBead;
        }

        public char GetPlayedBead()
        {
            if (CurrentBead == 'X')
                return 'O';
            else
                return 'X';
        }
    }
}
