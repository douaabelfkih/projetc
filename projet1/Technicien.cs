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
using System.Reflection.PortableExecutable;

namespace projet1
{
    public partial class Technicien : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        public Technicien()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEns_Click(object sender, EventArgs e)
        {
            adminMateriel cl = new adminMateriel();
            cl.Show();
            this.Hide();
        }

        private void btnDEm_Click(object sender, EventArgs e)
        {
            Departement cl = new Departement();
            cl.Show();
            this.Hide();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Form1 cl = new Form1();
            cl.Show();
            this.Hide();
        }

        private void AddUser(string nom, string password)
        {
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Le nom et le mot de passe ne peuvent pas être vides.");
            }

            string query = "INSERT INTO technicien (Nom, Password) VALUES (@Nom, @Password)";
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Password", password);

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string password = txtPassword.Text;

            AddUser(nom, password);

            MessageBox.Show("Utilisateur ajouté avec succès !");
            LoadUsers(); // Recharger la liste des utilisateurs
        }
        private void UpdateUser(int id, string nom, string password)
        {
            string query = "UPDATE technicien SET Nom = @Nom, Password = @Password WHERE Id = @Id";
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Nom", nom);
                cmd.Parameters.AddWithValue("@Password", password);

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'utilisateur sélectionné
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                string nom = txtNom.Text;
                string password = txtPassword.Text;

                // Appeler la fonction de mise à jour
                UpdateUser(id, nom, password);

                MessageBox.Show("Utilisateur modifié avec succès !");
                LoadUsers(); // Recharger la liste des utilisateurs
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier.");
            }
        }
        private void DeleteUser(int id)
        {
            string query = "DELETE FROM technicien WHERE Id = @Id";
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Id", id);

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer l'ID de l'utilisateur sélectionné
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Appeler la fonction de suppression
                DeleteUser(id);

                MessageBox.Show("Utilisateur supprimé avec succès !");
                LoadUsers(); // Recharger la liste des utilisateurs
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
            }
        }
        private void LoadUsers()
        {
            string query = "SELECT * FROM technicien";
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cnx.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                // Vérifier si les colonnes existent déjà
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("Id", "Id");
                    dataGridView1.Columns.Add("Nom", "Nom");
                    dataGridView1.Columns.Add("Password", "Password");
                }

                dataGridView1.Rows.Clear(); // Vider les anciennes données

                // Ajouter les lignes au DataGridView
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["Id"], reader["Nom"], reader["Password"]);
                }

                cnx.Close();
            }
        }


        private void Technicien_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }



}
