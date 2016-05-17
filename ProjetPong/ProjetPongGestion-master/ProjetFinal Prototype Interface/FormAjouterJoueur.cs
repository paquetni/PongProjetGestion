using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetFinal_Prototype_Interface
{
    public partial class FormAjouterJoueur : Form
    {
        string file = "Aucune photo sélectionnée";

        public FormAjouterJoueur()
        {
            InitializeComponent();
        }

        string myConnection = "datasource=127.0.0.1;port=3306;username=root";

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonInscrire_Click(object sender, EventArgs e)
        {
            try
            {   int id = 103;
                                            
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("INSERT INTO pongbd.gestiondesjoueurs (id,Nom,Prenom,Courriel,DateNaissance,NuméroTéléphone,Photo) VALUES ('" + id + "','"  + textBoxNom.Text + "','" + textBoxPrenom.Text + "','" + textBoxCourriel.Text +"','" + dateTimePickerDateNaissance.Text + "','" + textBoxTelephone.Text + "','" + labelPhotoID.Text + "');", myConn);
                MySqlCommand SelectCommand2 = new MySqlCommand("INSERT INTO pongbd.utilisateur (id,Pseudo,MotDePasse) VALUES ('" + id + "','" + textBoxPseudo.Text + "','" + textBoxMotDePasse.Text + "');'");           
                myConn.Open();
                SelectCommand.ExecuteNonQuery();
                SelectCommand2.ExecuteNonQuery();
                myConn.Close();

            }
            catch (Exception)
            {
                throw;
            }
            

        }

        private void buttonChoisirPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            file = ofd.FileName;
            labelPhotoID.Text = file;
        }
    }
}
