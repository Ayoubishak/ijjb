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
    public partial class ChercherLivre : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-AP8QM50\SQLEXPRESS;Initial Catalog=DB_bibliotheque;Integrated Security=True");

        public ChercherLivre()
        {
            InitializeComponent();
        }

        private void button_recherche_Click(object sender, EventArgs e)
        {
            bool condition1 = int.Parse(Recherche_Livre.Text.Length.ToString()) > 1;
            bool condition2 = int.Parse(Recherche_Livre.Text.Length.ToString()) == 1;

            if (condition2)
            {
                SqlCommand cmd = new SqlCommand("select * from dbo.RetourLivre('"+Char.Parse(Recherche_Livre.Text)+"')", sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_DetLivre.DataSource = table;
            }
            else if (condition1)
            {
                SqlCommand cmd = new SqlCommand("EXEC RenvoiLivre '"+Recherche_Livre.Text+"'", sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_DetLivre.DataSource = table;
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reculez_button_Click(object sender, EventArgs e)
        {
            InsererEmprunt emprunt = new InsererEmprunt();

            emprunt.Show();
            this.Hide();
        }

        private void avancer_button_Click(object sender, EventArgs e)
        {
            ChercherClient client = new ChercherClient();

            client.Show();
            this.Hide();
        }
    }
}
