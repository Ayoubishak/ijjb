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
    public partial class InsererEmprunt : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-AP8QM50\SQLEXPRESS;Initial Catalog=DB_bibliotheque;Integrated Security=True");

        public InsererEmprunt()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_retour_Click(object sender, EventArgs e)
        {
            InsererClient client = new InsererClient();

            client.Show();
            this.Hide();
        }

        private void ajouter_emprunt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC AjoutEmprunt '"+int.Parse(numero_RefLivreEmprunt.Value.ToString())+"','"+int.Parse(numero_RefClient.Value.ToString())+"','"+date_Emprunt.Text+"','"+date_Retour.Text+"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Insertion effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void modifier_emprunt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC ModifEmprunt '" + int.Parse(numero_RefLivreEmprunt.Value.ToString()) + "','" + int.Parse(numero_RefClient.Value.ToString()) + "','" + date_Retour.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Modification effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void supprimer_emprunt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC SUppEmprunt '" + int.Parse(numero_RefLivreEmprunt.Value.ToString()) + "','" + int.Parse(numero_RefClient.Value.ToString()) + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Suppression effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void button_avancer_Click(object sender, EventArgs e)
        {
            ChercherLivre livre = new ChercherLivre();

            livre.Show();
            this.Hide();
        }

        private void select_emprunt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Emprunt", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_emprunt.DataSource = table;
        }

        private void insert_emprunt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC AjoutEmprunt '" + int.Parse(numero_RefLivreEmprunt.Value.ToString()) + "','" + int.Parse(numero_RefClient.Value.ToString()) + "','" + date_Emprunt.Text + "','" + date_Retour.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void delete_emprunt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC SUppEmprunt '" + int.Parse(numero_RefLivreEmprunt.Value.ToString()) + "','" + int.Parse(numero_RefClient.Value.ToString()) + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void update_emprunt_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC ModifEmprunt '" + int.Parse(numero_RefLivreEmprunt.Value.ToString()) + "','" + int.Parse(numero_RefClient.Value.ToString()) + "','" + date_Retour.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
