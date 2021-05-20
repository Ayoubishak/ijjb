using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Bibliotheque
{
    public partial class Authentification : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        public Authentification()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-AP8QM50\SQLEXPRESS;Initial Catalog=DB_bibliotheque;Integrated Security=True";
        }

        private void out_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrez_button_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Authentification";
            SqlDataReader dr = com.ExecuteReader();
            InsererAuteurs auteurs = new InsererAuteurs();

            if (dr.Read())
            {
                if(this.Identifiant.Text.Equals(dr["identifiant"].ToString()) && this.MotDePasse.Text.Equals(dr["motdepasse"].ToString()))
                {
                    MessageBox.Show("Authentification Réussi", "", MessageBoxButtons.OK);
                    auteurs.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Echec d'authentification", "", MessageBoxButtons.OKCancel);
                }
            }
            con.Close();
        }
    }
}
