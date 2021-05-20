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
    public partial class InsererClient : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-AP8QM50\SQLEXPRESS;Initial Catalog=DB_bibliotheque;Integrated Security=True");

        public InsererClient()
        {
            InitializeComponent();
        }

        private void button_reculer_Click(object sender, EventArgs e)
        {
            InsererExemplaire exemplaire = new InsererExemplaire();

            exemplaire.Show();
            this.Hide();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_avancer_Click(object sender, EventArgs e)
        {
            InsererEmprunt emprunt = new InsererEmprunt();

            emprunt.Show();
            this.Hide();
        }

        private void Ajouter_client_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC AjoutClient '"+int.Parse(numero_client.Value.ToString())+"','"+nom_client.Text+"','"+prenom_client.Text+"','"+CIN_client.Text+"','"+DateNaissance_client.Text+"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Insertion effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void modifier_client_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC ModifClient '" + int.Parse(numero_client.Value.ToString()) + "','" + nom_client.Text + "','" + prenom_client.Text + "','" + CIN_client.Text + "','" + DateNaissance_client.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Modification effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void supprimer_client_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC SUppClient '" + int.Parse(numero_client.Value.ToString()) + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Suppression effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void select_client_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Client", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_client.DataSource = table;
        }

        private void insert_client_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC AjoutClient '" + int.Parse(numero_client.Value.ToString()) + "','" + nom_client.Text + "','" + prenom_client.Text + "','" + CIN_client.Text + "','" + DateNaissance_client.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void delete_client_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC SUppClient '" + int.Parse(numero_client.Value.ToString()) + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void update_client_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC ModifClient '" + int.Parse(numero_client.Value.ToString()) + "','" + nom_client.Text + "','" + prenom_client.Text + "','" + CIN_client.Text + "','" + DateNaissance_client.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
