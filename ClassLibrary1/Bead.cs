using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bead
    {
        public static readonly Bead X = new Bead("X", 'X', Color.Blue);
        public static readonly Bead O = new Bead("O", 'O', Color.Red);

        public string Name { get; set; }
        public char Symbol { get; set; }
        public Color Color { get; set; }

        public Bead(string name)
        {
            Set(name);
        }
        public Bead(string name, char symbol)
        {
            Set(name, symbol);
        }
        public Bead(string name, char symbol, Color color)
        {
            Set(name, symbol, color);
        }

        public Bead Set(string name, char symbol, Color color)
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
            return Set(name, symbol, Color.Black);
        }
        public Bead Set(string name)
        {
            return Set(name, name != null ? name.ToUpper()[0] : '\0', Color.Black);
        }
    }
}
