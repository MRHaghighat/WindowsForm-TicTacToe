using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Board
    {
        private int size;
        public int Size
        {
            get { return size; }
            set
            {
                size = value;
                cells = new Cell[size*size];
            }
        }

        private Cell[] cells;
        public Cell[] Cells
        {
            get { return cells; }
        }

        public bool HaveMatche
        {
            get
            {
                Bead bead;
                bool matched = false;

                for (int i = 0; i < size && !matched; i++)
                {
                    bead = cells[i].Bead;
                    matched = GetRow(i + 1).All(b => b?.Bead == bead) || GetColumn(i + 1).All(b => b?.Bead == bead);
                }

                return matched ? matched : Diameter(1).All(b => b.Bead == cells[0].Bead) || Diameter(2).All(b => b.Bead == cells[size - 1].Bead);
            }
        }
        public Bead[] GetOnBoardBeads
        {
            get
            {
                return cells.Select(c => c?.Bead).ToArray();
            }
        }

        public Board(int size)
        {
            Size = size;
        }

        public void SetOnBoard(int index, Bead bead)
        {
            cells[index] = new Cell(bead);
        }
        public Bead GetFromBoard(int index)
        {
            return cells[index]?.Bead;
        }

        public Cell[] GetRow(int index)
        {
            if (index > 0 && index <= size)
            {
                return cells.Skip((index - 1) * size).Take(size).ToArray();
            }
            return null;
        }

        public Cell[] GetColumn(int index)
        {
            if (index > 0 && index <= size)
            {
                return cells.Where((c, i) => i % size == (index - 1)).ToArray();
            }
            return null;
        }
        public Cell[] Diameter(int index)
        {
            if (index > 0 && index < 3)
            {
                List<Cell> c = new List<Cell>();
                switch (index)
                {
                    case 1:
                        for (int i = 0, j = 0; i < size * size; i++)
                        {
                            if (i == size * j + j)
                            {
                                c.Add(cells[i]);
                                j++;
                            }
                        }
                        break;
                    case 2:
                        for (int i = size - 1, j = 1; i <= size * (size - 1); i++)
                        {
                            if (i == (size - 1) * j)
                            {
                                c.Add(cells[i]);
                                j++;
                            }
                        }
                        break;
                }
                return cells.ToArray();
            }
            return null;
        }
    }
}
