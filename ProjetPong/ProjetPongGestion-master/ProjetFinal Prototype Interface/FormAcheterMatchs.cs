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
    public partial class FormAcheterMatchs : Form
    {
        public FormAcheterMatchs()
        {
            InitializeComponent();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAcheter1_Click(object sender, EventArgs e)
        {
            FormFacture form = new FormFacture();
            form.Show();
        }
    }
}
