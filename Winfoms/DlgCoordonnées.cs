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

        public DlgCoordonnées(int x = 0, int y = 0)
        {
            InitializeComponent();

            X = x;
            Y = y;

            labelCoordonnées.Text = $"({X}, {Y})";

            ++X;
            ++Y;
        }
    }
}
