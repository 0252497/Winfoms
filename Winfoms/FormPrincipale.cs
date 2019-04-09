using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Drawing.Color;
namespace Winfoms
{
    public partial class FormPrincipale : Form
    {
        Color m_couleurInitiale;
        Color m_NouvelleCouleur = Red;

        public FormPrincipale()
        {
            InitializeComponent();
            m_couleurInitiale = BackColor;
            btn_Jaunir.Tag = Yellow;
            btn_Verdir.Tag = LimeGreen;
            Tag = Red;
        }

        private void buttonBonjour_Click(object sender, EventArgs e)
        {
            if (sender is Button bouton)
            {
                MessageBox.Show($"{bouton.Text} \nBonjour le monde!");
            }
        }

        private void modifierCouleurSelonTag(object sender, EventArgs e)
        {
            if(sender is Control control && control.Tag is Color couleur)
            {
                if (BackColor != couleur)
                {
                    BackColor = couleur;
                }
                else
                {
                    BackColor = m_couleurInitiale;
                }

               toolStripStatusLabelCouleurDeFond.Text = BackColor.ToString();
            }
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPrincipale_SizeChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelAction.Text = Size.ToString();
        }

        private void FormPrincipale_Move(object sender, EventArgs e)
        {
            toolStripStatusLabelAction.Text = Location.ToString();
        }

        private void FormPrincipale_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelAction.Text = $"({e.X}, {e.Y})";
        }

        private void FormPrincipale_MouseEnter(object sender, EventArgs e)
        {
            statusStrip1.BackColor = Black;
            statusStrip1.ForeColor = White;
        }

        private void FormPrincipale_MouseLeave(object sender, EventArgs e)
        {
            statusStrip1.BackColor = White;
            statusStrip1.ForeColor = Black;
        }

        private void statusStrip1_MouseHover(object sender, EventArgs e)
        {
            statusStrip1.BackColor = Orange;
            statusStrip1.ForeColor = Black;
        }

        private void FormPrincipale_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    Tag = Red;
                    break;

                case MouseButtons.Right:
                    Tag = RoyalBlue;
                    break;

                default:
                    Tag = DarkCyan;
                    break;
            }
        }

        private void FormPrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            var résultat = MessageBox.Show(this, "Voulez-vous vraiment quitter?", "Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            e.Cancel = résultat == DialogResult.Cancel;
        }

        private void FormPrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Au revoir!");
        }
    }
}
