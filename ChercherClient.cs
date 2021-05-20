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
    public partial class ChercherClient : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-AP8QM50\SQLEXPRESS;Initial Catalog=DB_bibliotheque;Integrated Security=True");

        public ChercherClient()
        {
            InitializeComponent();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reculer_button_Click(object sender, EventArgs e)
        {
            ChercherLivre livre = new ChercherLivre();

            livre.Show();
            this.Hide();
        }

        private void recherche_button_Click(object sender, EventArgs e)
        {
            bool condition1 = int.Parse(recherche_client.Text.Length.ToString()) > 1;
            bool condition2 = int.Parse(recherche_client.Text.Length.ToString()) == 1;

            if (condition2)
            {
                SqlCommand cmd = new SqlCommand("select * from dbo.RetourClient('"+Char.Parse(recherche_client.Text)+"')", sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_client.DataSource = table;
            }
            else if (condition1)
            {
                SqlCommand cmd = new SqlCommand("EXEC RenvoiClient '"+recherche_client.Text+"'", sqlcon);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_client.DataSource = table;
            }
        }

        private void avancer_button_Click(object sender, EventArgs e)
        {
            Palmares palmares = new Palmares();

            palmares.Show();
            this.Hide();
        }
    }
}
