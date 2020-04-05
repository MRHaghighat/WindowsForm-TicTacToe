using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    public class Bead
    {
        public string Name { get; set; }
        public char Symbol { get; set; }
        public System.Drawing.Color Color { get; set; }

        public Bead(string name)
        {
            Set(name);
        }
        public Bead(string name, char symbol)
        {
            Set(name, symbol);
        }
        public Bead(string name, char symbol, System.Drawing.Color color)
        {
            Set(name, symbol, color);
        }

        public Bead Set(string name, char symbol, System.Drawing.Color color)
        {
            if (name != null)
            {
                Name = name;
                Symbol = symbol;
                Color = color;
            }
            else
                throw new ArgumentNullException("Name for Bead can not be null");
            return this;
        }
        public Bead Set(string name, char symbol)
        {
            return Set(name, symbol, System.Drawing.Color.Black);
        }
        public Bead Set(string name)
        {
            return Set(name, name != null ? name.ToUpper()[0] : '\0', System.Drawing.Color.Black);
        }
    }
}
