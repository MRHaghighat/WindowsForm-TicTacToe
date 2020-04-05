using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Controls
{
    public partial class InputPlayer : UserControl
    {
        public event EventHandler OnOk;

        Model.Bead x;
        public Model.Bead X
        {
            get => Model.TicTacToe.X;
            set => Model.TicTacToe.X.Name = txtPlayerX.Text;
        }
        Model.Bead o;
        public Model.Bead O
        {
            get => Model.TicTacToe.X;
            set => Model.TicTacToe.O.Name = txtPlayerO.Text;
        }
        public Model.Bead StarterBead
        {
            get => rbX.Checked ? X : O;
        }

        public InputPlayer()
        {
            InitializeComponent();
            txtPlayerO.Tag = Model.TicTacToe.O;
            txtPlayerX.Tag = Model.TicTacToe.X;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OnOk?.Invoke(this, new EventArgs());
        }

        private void txtPlayer_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Tag == Model.TicTacToe.X)
            {
                Model.TicTacToe.X.Name = tb.Text;
            }
            else
            {
                Model.TicTacToe.O.Name = tb.Text;
            }
        }
    }
}
