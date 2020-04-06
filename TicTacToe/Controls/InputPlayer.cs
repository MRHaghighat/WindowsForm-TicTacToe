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

        public Model.Bead SelectedBead
        {
            get => rbX.Checked ? Model.TicTacToe.X : Model.TicTacToe.O;
        }

        public InputPlayer()
        {
            InitializeComponent();
            txtPlayerO.Tag = pnlColorO.Tag = Model.TicTacToe.O;
            txtPlayerX.Tag = pnlColorX.Tag = Model.TicTacToe.X;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OnOk?.Invoke(this, new EventArgs());
        }

        private void txtPlayer_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            ((Model.Bead)(tb.Tag)).Name = tb.Text;
        }

        private void pnlColor_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog()== DialogResult.OK)
            {
                ((Panel)(sender)).BackColor = colorDialog.Color;
            }
        }

        private void pnlColor_BackColorChanged(object sender, EventArgs e)
        {
            ((Model.Bead)(((Panel)(sender)).Tag)).Color = ((Panel)(sender)).BackColor;
        }
    }
}
