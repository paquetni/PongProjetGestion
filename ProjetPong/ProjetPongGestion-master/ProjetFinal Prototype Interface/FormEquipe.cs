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
    public partial class FormEquipe : Form
    {
        public FormEquipe()
        {
            InitializeComponent();
        }

        private void buttonRejoindreEquipe_Click(object sender, EventArgs e)
        {
            FormRejoindreEquipe form = new FormRejoindreEquipe();
            form.Show();
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            FormStatsEquipe form = new FormStatsEquipe();
            form.Show();
        }
    }
}
