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
    public partial class Palmares : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-AP8QM50\SQLEXPRESS;Initial Catalog=DB_bibliotheque;Integrated Security=True");

        public Palmares()
        {
            InitializeComponent();
        }

        private void reculez_button_Click(object sender, EventArgs e)
        {
            ChercherClient client = new ChercherClient();

            client.Show();
            this.Hide();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LivreEmprunté_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Titre, COUNT(Id_Livre) as Nombre_Emprunt from Livre, Emprunt where Livre# = Id_Livre group by Titre", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Palmares.DataSource = table;
        }

        private void NombreDomaine_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Libelle as Genre, COUNT(Domaine) as NbrLivre from Domaine, Livre where Domaine# = Domaine group by Libelle", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Palmares.DataSource = table;
        }

        private void ClientLivreEmprunt_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Nom, Prenom, COUNT(Id_Client) as NbrEmprunt from Client, Emprunt where Client# = Id_Client group by Nom, Prenom", sqlcon);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_Palmares.DataSource = table;
        }
    }
}
