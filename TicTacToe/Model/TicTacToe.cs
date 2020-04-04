using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class TicTacToe
    {
        public string[] Board;
        public string CurrentBead;
        bool mustStop;

        public TicTacToe()
        {
            Set();
        }

        public void Set()
        {
            Board = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            CurrentBead = "X";
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

        public string Play(int CellIndex)
        {
            if (!mustStop && CellIndex > -1 && CellIndex < 9)
            {
                Board[CellIndex] = CurrentBead;
                GetTurn();
                return GetPlayedBead();
            }
            return Board[CellIndex];
        }

        public string GetWinner()
        {
            if (HaveWin())
                return GetPlayedBead();
            else
                return null;
        }

        public string GetTurn()
        {
            if (CurrentBead == "X")
                CurrentBead = "O";
            else
                CurrentBead = "X";
            return CurrentBead;
        }

        public string GetPlayedBead()
        {
            if (CurrentBead == "X")
                return "O";
            else
                return "X";
        }
    }
}
