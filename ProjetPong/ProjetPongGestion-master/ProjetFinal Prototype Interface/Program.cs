using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetFinal_Prototype_Interface
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //string connString = "Server=127.0.0.1;Database=";
            //MySqlConnection conn = new MySqlConnection(connString);
            //MySqlCommand command = conn.CreateCommand();
            //command.CommandText = "";
             
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());

        }
    }
}
