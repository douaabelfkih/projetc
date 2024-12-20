using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projet1
{
    public partial class adminMateriel : Form
    {

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

        public adminMateriel()
        {
            InitializeComponent();
        }

      
        private void btnexit_Click(object sender, EventArgs e)
        {
            // Handle the button click event for exit (if any specific logic is needed)
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmat_Click(object sender, EventArgs e)
        {
            Technicien cl = new Technicien();
            cl.Show();
            this.Hide();
        }

        private void btndem_Click(object sender, EventArgs e)
        {
            Departement cl = new Departement();
            cl.Show();
            this.Hide();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            adminform cl = new adminform();
            cl.Show();
            this.Hide();
        }

        

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                string query = "DELETE FROM Materiel WHERE Id = @Id";

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

                using (SqlConnection cnx = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }

                ChargerMateriels();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                string nom = txtNom.Text;
                string type = txtType.Text;
                string reference = txtReference.Text;
                string departement = txtDepart.Text;

                string query = "UPDATE Materiel SET Nom = @Nom, Type = @Type, Reference = @Reference, Departement = @Departement WHERE Id = @Id";

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
                using (SqlConnection cnx = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Reference", reference);
                    cmd.Parameters.AddWithValue("@Departement", departement);

                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }

                ChargerMateriels();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string type = txtType.Text;
            string reference = txtReference.Text;
            string departement = txtDepart.Text;

            string query = "INSERT INTO Materiel (Nom, Type, Reference, Departement) VALUES (@Nom, @Type, @Reference, @Departement)";

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                // Créer une commande SQL
                using (SqlCommand cmd = new SqlCommand(query, cnx))
                {
                    // Ajouter les paramètres à la commande
                    cmd.Parameters.AddWithValue("@Nom", nom);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Reference", reference);
                    cmd.Parameters.AddWithValue("@Departement", departement);

                    // Ouvrir la connexion
                    cnx.Open();

                    // Exécuter la commande
                    cmd.ExecuteNonQuery();

                    // Fermer la connexion (automatique avec "using")
                }
            }

            // Actualiser la liste des matériels
            ChargerMateriels();
        }
        private void ChargerMateriels()
        {
            string query = "SELECT * FROM Materiel";

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, cnx))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void LoadMateriels()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            string query = "SELECT * FROM Materiel";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }
        private void AjouterMateriel(string nom, string type, string reference, string departement)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            string query = "INSERT INTO Materiel (Nom, Type, Reference, Departement) VALUES (@Nom, @Type, @Reference, @Departement)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Reference", reference);
                cmd.Parameters.AddWithValue("@Departement", departement);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void ModifierMateriel(int id, string nom, string type, string reference, string departement)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            string query = "UPDATE Materiel SET Nom = @Nom, Type = @Type, Reference = @Reference, Departement = @Departement WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@Reference", reference);
                cmd.Parameters.AddWithValue("@Departement", departement);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void SupprimerMateriel(int id)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            string query = "DELETE FROM Materiel WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void adminMateriel_Load(object sender, EventArgs e)
        {
  
            ChargerMateriels();
        

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
    
}
