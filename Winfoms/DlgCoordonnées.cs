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

            numericUpDownX.Value = X;
            numericUpDownY.Value = Y;

            labelCoordonnées.Text = Coordonnées.ToString();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (sender == numericUpDownX)
            {
                X = (int)numericUpDownX.Value;
            }

            if (sender == numericUpDownY)
            {
                Y = (int)numericUpDownY.Value;
            }

            labelCoordonnées.Text = Coordonnées.ToString();
        }
    }
}
