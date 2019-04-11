/* Dialogue de coordonnées DlgCoordonnées.
 * 
 * Auteure : Véronique Giguère
 * Création : 10 avril 2019 
 */
using System;
using System.Windows.Forms;

namespace Winforms
{
    public partial class DlgCoordonnées : Form
    {
        public int? X { get; private set; }
        public int? Y { get; private set; }

        public (int? x, int? y) Coordonnées => (X, Y);

        // Initialisation au démarrage :
        public DlgCoordonnées(int? x = null, int? y = null)
        {
            InitializeComponent();

            X = x;
            Y = y;

            numericUpDownX.Value = X ?? 0;
            numericUpDownY.Value = Y ?? 0;
            
            labelCoordonnées.Text = Coordonnées.ToString();

            checkBoxVerrouiller.Checked = true;
        }

        private void checkBoxVerrouiller_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownX.Enabled = !checkBoxVerrouiller.Checked;
            numericUpDownY.Enabled = !checkBoxVerrouiller.Checked;
            buttonOk.Enabled = !checkBoxVerrouiller.Checked;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            X = (int)numericUpDownX.Value;
            Y = (int)numericUpDownY.Value;
            labelCoordonnées.Text = Coordonnées.ToString();
        }
    }
}
