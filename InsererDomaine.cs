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
    public partial class InsererDomaine : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-AP8QM50\SQLEXPRESS;Initial Catalog=DB_bibliotheque;Integrated Security=True");
        public InsererDomaine()
        {
            InitializeComponent();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_avant_Click(object sender, EventArgs e)
        {
            InsererLivre livres = new InsererLivre();

            livres.Show();
            this.Hide();
        }

        private void button_arriere_Click(object sender, EventArgs e)
        {
            InsererAuteurs auteurs = new InsererAuteurs();

            auteurs.Show();
            this.Hide();
        }

        private void libelle_domaine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ajouter_domaine_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Domaine", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_domaine.DataSource = table;

            MessageBox.Show("Opération réussie avec succès", "", MessageBoxButtons.OK);
        }

        private void modifier_domaine_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into dbo.Domaine(Domaine#, Libelle) values('"+int.Parse(numero_domaine.Value.ToString())+"', '"+libelle_domaine.Text+"')";
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            
            MessageBox.Show("Insertion réussie avec succès", "", MessageBoxButtons.OK);
        }

        private void supprimer_domaine_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Domaine where Domaine# = '" + int.Parse(numero_domaine.Value.ToString()) + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Suppression réussie avec succès", "", MessageBoxButtons.OK);
        }

        private void update_domaine_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlCommand cmd = sqlcon.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Domaine set Libelle = '" + libelle_domaine.Text + "' where Domaine# = '" + int.Parse(numero_domaine.Value.ToString()) + "'";
            cmd.ExecuteNonQuery();
            sqlcon.Close();

            MessageBox.Show("Modification réussie avec succès", "", MessageBoxButtons.OK);
        }
    }
}