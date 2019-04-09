using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winfoms
{
    public partial class FormPrincipale : Form
    {
        Color m_couleurInitiale;
        Color m_NouvelleCouleur = Color.Red;

        public FormPrincipale()
        {
            InitializeComponent();
            m_couleurInitiale = BackColor;
            btn_Jaunir.Tag = Color.Yellow;
            btn_Verdir.Tag = Color.LimeGreen;
            Tag = Color.Red;
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
            }
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
