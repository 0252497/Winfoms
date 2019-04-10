using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms
{
    public partial class DlgCoordonnées : Form
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public (int x, int y) Coordonnées => (X, Y);

        public DlgCoordonnées(int x = 0, int y = 0)
        {
            InitializeComponent();
            X = x;
            Y = y;

            numericUpDownX.Enabled = !checkBoxVerrouiller.Checked;
            numericUpDownY.Enabled = !checkBoxVerrouiller.Checked;

            numericUpDownX.Value = X;
            numericUpDownY.Value = Y;

            labelCoordonnées.Text = Coordonnées.ToString();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            X = (int)numericUpDownX.Value;
            Y = (int)numericUpDownY.Value;
            labelCoordonnées.Text = Coordonnées.ToString();
        }

        private void checkBoxVerrouiller_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownX.Enabled = !checkBoxVerrouiller.Checked;
            numericUpDownY.Enabled = !checkBoxVerrouiller.Checked;
        }
    }
}
