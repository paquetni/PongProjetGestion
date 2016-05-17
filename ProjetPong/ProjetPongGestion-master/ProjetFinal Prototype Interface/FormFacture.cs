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
    public partial class FormFacture : Form
    {
        public FormFacture()
        {
            InitializeComponent();
        }

        private void buttonPayer_Click(object sender, EventArgs e)
        {
            FormImprimer form = new FormImprimer();
        }
    }
}
