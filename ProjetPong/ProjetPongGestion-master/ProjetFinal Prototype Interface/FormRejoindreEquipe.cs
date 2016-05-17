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
    public partial class FormRejoindreEquipe : Form
    {
        public FormRejoindreEquipe()
        {
            InitializeComponent();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreerEquipe_Click(object sender, EventArgs e)
        {
            FormCreerEquipe form = new FormCreerEquipe();
            form.Show();
        }
    }
}
