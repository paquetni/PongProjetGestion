using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinal_Prototype_Interface
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonJoueur_Click(object sender, EventArgs e)
        {
            FormJoueur form = new FormJoueur();
            form.Show();
        }

        private void buttonTournois_Click(object sender, EventArgs e)
        {
            FormTournois form = new FormTournois();
            form.Show();
        }

        private void buttonEquipe_Click(object sender, EventArgs e)
        {
            FormEquipe form = new FormEquipe();
            form.Show();
        }

        private void buttonJouer_Click(object sender, EventArgs e)
        {
            FormRejoindreMatch form = new FormRejoindreMatch();
            form.Show();
        }

        private void buttonTableauBord_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void buttonAcheter_Click(object sender, EventArgs e)
        {
            FormAcheterMatchs form = new FormAcheterMatchs();
            form.Show();
        }
    }
}
