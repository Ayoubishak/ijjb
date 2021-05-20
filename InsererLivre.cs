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
    public partial class InsererLivre : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-AP8QM50\SQLEXPRESS;Initial Catalog=DB_bibliotheque;Integrated Security=True");

        public InsererLivre()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_reculer_Click(object sender, EventArgs e)
        {
            InsererDomaine domaine = new InsererDomaine();

            domaine.Show();
            this.Hide();
        }

        private void button_avancer_Click(object sender, EventArgs e)
        {
            InsererExemplaire exemplaire = new InsererExemplaire();

            exemplaire.Show();
            this.Hide();
        }

        private void Ajouter_livre_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC AjoutLivre '"+int.Parse(numero_livre.Value.ToString())+"', '"+int.Parse(numero_RefAuteur.Value.ToString())+"', '"+int.Parse(numero_RefDomaine.Value.ToString())+"', '"+titre_livre.Text+"', '"+langue_livre.Text+"', '"+date_edition_livre.Text+"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Insertion effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void Modifier_livre_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC ModifLivre '" + int.Parse(numero_livre.Value.ToString()) + "', '" + int.Parse(numero_RefAuteur.Value.ToString()) + "', '" + int.Parse(numero_RefDomaine.Value.ToString()) + "', '" + titre_livre.Text + "', '" + langue_livre.Text + "', '" + date_edition_livre.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Modification effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void supprimer_livre_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC SUppLivre '"+ int.Parse(numero_livre.Value.ToString()) +"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Suppression effectuée avec succès", "", MessageBoxButtons.OK);
        }

        private void select_livre_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Livre", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_livre.DataSource = table;
        }

        private void insert_livre_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC AjoutLivre '"+int.Parse(numero_livre.Value.ToString())+"', '"+int.Parse(numero_RefAuteur.Value.ToString())+"', '"+int.Parse(numero_RefDomaine.Value.ToString())+"', '"+titre_livre.Text+"', '"+langue_livre.Text+"', '"+date_edition_livre.Text+"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void delete_livre_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC SUppLivre '"+int.Parse(numero_livre.Value.ToString())+"'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }

        private void update_livre_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "EXEC ModifLivre '" + int.Parse(numero_livre.Value.ToString()) + "', '" + int.Parse(numero_RefAuteur.Value.ToString()) + "', '" + int.Parse(numero_RefDomaine.Value.ToString()) + "', '" + titre_livre.Text + "', '" + langue_livre.Text + "', '" + date_edition_livre.Text + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
        }
    }
}
