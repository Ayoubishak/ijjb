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
    public partial class InsererExemplaire : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-AP8QM50\SQLEXPRESS;Initial Catalog=DB_bibliotheque;Integrated Security=True");

        public InsererExemplaire()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_reculer_Click(object sender, EventArgs e)
        {
            InsererLivre livre = new InsererLivre();

            livre.Show();
            this.Hide();
        }

        private void button_avancer_Click(object sender, EventArgs e)
        {
            InsererClient client = new InsererClient();

            client.Show();
            this.Hide();
        }

        private void ajouter_exemplaire_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC AjoutExemplaire '"+int.Parse(numero_examplaire.Value.ToString())+"','"+int.Parse(numero_RefLivre.Value.ToString())+"','"+int.Parse(nombre_exemplaire.Value.ToString())+"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Insertion effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void modifier_exemplaire_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC ModifExemplaire '" + int.Parse(numero_examplaire.Value.ToString()) + "','" + int.Parse(numero_RefLivre.Value.ToString()) + "','" + int.Parse(nombre_exemplaire.Value.ToString()) + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Modification effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void supprimer_exemplaire_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC SUppExemplaire '"+int.Parse(numero_examplaire.Value.ToString())+"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Suppression effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void select_exemplaire_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Examplaire", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_exemplaire.DataSource = table;
        }

        private void insert_exemplaire_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC AjoutExemplaire '"+int.Parse(numero_examplaire.Value.ToString())+"', '"+int.Parse(numero_RefLivre.Value.ToString())+"', '"+int.Parse(nombre_exemplaire.Value.ToString())+"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void delete_exemplaire_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC SUppExemplaire '"+int.Parse(numero_examplaire.Value.ToString())+"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void update_exemplaire_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC ModifExemplaire '" + int.Parse(numero_examplaire.Value.ToString()) + "', '" + int.Parse(numero_RefLivre.Value.ToString()) + "', '" + int.Parse(nombre_exemplaire.Value.ToString()) + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
