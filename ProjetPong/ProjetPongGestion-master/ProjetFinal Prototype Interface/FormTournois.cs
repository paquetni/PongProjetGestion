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
    public partial class FormTournois : Form
    {
        public FormTournois()
        {
            InitializeComponent();
        }

        private void buttonInscriptionTournoi_Click(object sender, EventArgs e)
        {
            FormInscriptionTournoi form = new FormInscriptionTournoi();
            form.Show();
        }
    }
}
