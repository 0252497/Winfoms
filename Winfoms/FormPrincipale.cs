/* Formulaire FormPrincipale de mon premier projet Winforms. 
 * 
 * Auteure : Véronique Giguère
 * Création : 9 avril 2019
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Drawing.Color;

namespace Winforms
{
    public partial class FormPrincipale : Form
    {
        Color m_couleurInitiale;
        Color m_NouvelleCouleur = Red;

        (int? x, int? y) m_Coordonnées = (null, null);

        // Initialisé au démarrage du programme :
        public FormPrincipale()
        {
            InitializeComponent();
            m_couleurInitiale = BackColor;
            btn_Jaunir.Tag = Yellow;
            btn_Verdir.Tag = LimeGreen;
            enNoirToolStripMenuItem.Tag = Black;
            enRoseToolStripMenuItem.Tag = Pink;
            toolStripStatusLabelCouleurDeFond.Text = BackColor.ToString();
            toolStripStatusLabelCoordonnées.Text = m_Coordonnées.ToString();
            Tag = Red;
        }

        // --- Méthodes ---

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void coordonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // var résultat = new DlgCoordonnées().ShowDialog();
            // MessageBox.Show(résultat == DialogResult.OK ? "Parfait!" : "On annule!");

            // Passer les coordonnées au dialogue :
            var dlg = new DlgCoordonnées(m_Coordonnées.x, m_Coordonnées.y);
            var résultat = dlg.ShowDialog();

            if (résultat == DialogResult.OK)
            {
                // Récupérer X et Y modifiés dans un tuple :
                // var coordonnées = (dlg.X, dlg.Y);

                // Récupérer les nouvelles coordonnées du dialogue :
                m_Coordonnées = dlg.Coordonnées;

                // MessageBox.Show($"Nouvelles coordonnées: {m_Coordonnées}");

                toolStripStatusLabelCoordonnées.Text = m_Coordonnées.ToString();
            }
        }

        private void direBonjourSelonText(object sender, EventArgs e)
        {
            MessageBox.Show((sender is Control control ?
                $"{control.Text.Replace("&", "")}" :
                $"{sender.ToString().Replace("&", "")}") +
                " dit:\nBonjour le monde!");
        }

        private void effacerCoordonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Coordonnées = (null, null);

            toolStripStatusLabelCoordonnées.Text = m_Coordonnées.ToString();
        }

        private void FormPrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sortirIllicoToolStripMenuItem.Checked) return;

            MessageBox.Show("Au revoir!");
        }

        private void FormPrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sortirIllicoToolStripMenuItem.Checked) return;

            var résultat = MessageBox.Show(this, "Voulez-vous vraiment quitter?", "Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            e.Cancel = résultat == DialogResult.Cancel;
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

        private void FormPrincipale_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelAction.Text = $"({e.X}, {e.Y})";
        }

        private void FormPrincipale_Move(object sender, EventArgs e)
        {
            toolStripStatusLabelAction.Text = Location.ToString();
        }

        private void FormPrincipale_SizeChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelAction.Text = Size.ToString();
        }

        private void modifierCouleurSelonTag(object sender, EventArgs e)
        {
            if (sender is Control control && control.Tag is Color couleur)
            {
                BackColor = BackColor != couleur ? couleur : m_couleurInitiale;

                toolStripStatusLabelCouleurDeFond.Text = BackColor.ToString();
            }
            else if (sender is ToolStripItem item && item.Tag is Color color)
            {
                BackColor = BackColor != color ? color : m_couleurInitiale;

                toolStripStatusLabelCouleurDeFond.Text = BackColor.ToString();
            }
        }

        private void statusStrip1_MouseHover(object sender, EventArgs e)
        {
            statusStrip1.BackColor = Orange;
            statusStrip1.ForeColor = Black;
        }
    }
}
