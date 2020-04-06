using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cell
    {
        public Bead Bead { get; set; }
        public bool IsBlocked { get; set; }

        public Cell(Bead bead)
        {
            Bead = bead;
        }
    }
}
