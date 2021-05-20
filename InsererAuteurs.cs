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
    public partial class InsererAuteurs : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-AP8QM50\SQLEXPRESS;Initial Catalog=DB_bibliotheque;Integrated Security=True");
        
        
        public InsererAuteurs()
        {
            InitializeComponent();
        }

        private void InsererAuteurs_Load(object sender, EventArgs e)
        {

        }

        private void button_arret_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_passage_Click(object sender, EventArgs e)
        {
            InsererDomaine domaine = new InsererDomaine();

            domaine.Show();
            this.Hide();
        }

        private void ajouter_auteur_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Auteur", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_auteur.DataSource = table;

            MessageBox.Show("Opération réussie avec succès", "", MessageBoxButtons.OK);
        }

        private void modifier_auteur_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC InsererAuteur '" + int.Parse(num_auteur.Value.ToString()) + "','" + nom_auteur.Text + "','" + prenom_auteur.Text + "','" + dateNaissance_auteur.Text + "','" + nationalite_auteur.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Insertion effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void supprimer_auteur_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC SUppAuteur '"+int.Parse(num_auteur.Value.ToString())+ "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Suppression effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_auteur_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC ModifAuteur '" + int.Parse(num_auteur.Value.ToString()) + "','" + nom_auteur.Text + "','" + prenom_auteur.Text + "','" + dateNaissance_auteur.Text + "','" + nationalite_auteur.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Modification effectuée avec succès", "", MessageBoxButtons.OK);
        }
    }
}
