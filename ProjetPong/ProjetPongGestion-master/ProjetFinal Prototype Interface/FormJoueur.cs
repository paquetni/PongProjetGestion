using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetFinal_Prototype_Interface
{
    public partial class FormJoueur : Form
    {
        string myConnection = "datasource=127.0.0.1;port=3306;username=root";
        public FormJoueur()
        {
            InitializeComponent();
        }

        private void buttonInscription_Click(object sender, EventArgs e)
        {
            FormAjouterJoueur form = new FormAjouterJoueur();
            form.Show();
        }

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);               
                MySqlCommand SelectCommand = new MySqlCommand("select * from pongbd.utilisateur where Pseudo ='" + textBoxPseudo.Text + "'and MotDePasse='" + textBoxMotDePasse.Text + "';", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();              
                int compteur = 0;
                while (myReader.Read())
                {
                    compteur = compteur + 1;
                }
                if(compteur ==1)
                {
                    MessageBox.Show("Bienvenue " + textBoxPseudo.Text + " !");
                }
                else if (compteur >1)
                {
                    MessageBox.Show("Accès refusé.");
                }
                else
                {
                    MessageBox.Show("Mauvais pseudo ou mot de passe.");
                }
                myConn.Close();
            }           

            catch (Exception)
            {
                throw;
            }
        }
    }
}
