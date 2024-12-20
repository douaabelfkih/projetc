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

namespace projet1
{
    public partial class Materiel : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;

        int indice;
        public Materiel()
        {
            InitializeComponent();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEns_Click(object sender, EventArgs e)
        {
            Enseignant cl = new Enseignant(); cl.Show();
            this.Hide();
        }

        private void btnDEm_Click(object sender, EventArgs e)
        {
            Demande cl = new Demande(); cl.Show();
            this.Hide();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Chat cl = new Chat(); cl.Show();
            this.Hide();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Form1 cl = new Form1(); cl.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Materiel_Load(object sender, EventArgs e)
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection connection1 = new SqlConnection(connectionString))
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                connection1.Open();
                connection2.Open();

                // Commande pour les types
                SqlCommand cmdTypes = new SqlCommand("SELECT DISTINCT CAST(Type AS NVARCHAR(MAX)) AS Type FROM Materiel", connection1);
                SqlDataReader readerTypes = cmdTypes.ExecuteReader();

                while (readerTypes.Read())
                {
                    string typeMateriel = readerTypes["Type"].ToString();
                    TreeNode typeNode = new TreeNode(typeMateriel);

                    // Commande pour les références
                    SqlCommand cmdReferences = new SqlCommand("SELECT Reference FROM Materiel WHERE CAST(Type AS NVARCHAR(MAX)) = @type", connection2);
                    cmdReferences.Parameters.AddWithValue("@type", typeMateriel);

                    SqlDataReader readerReferences = cmdReferences.ExecuteReader();
                    while (readerReferences.Read())
                    {
                        string reference = readerReferences["Reference"].ToString();
                        TreeNode referenceNode = new TreeNode(reference);
                        typeNode.Nodes.Add(referenceNode);
                    }
                    readerReferences.Close();

                    treeView1.Nodes.Add(typeNode);
                }

                readerTypes.Close();
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Charger les matériels non affectés dans ComboBox1
                SqlCommand cmdMateriels = new SqlCommand("SELECT * FROM Materiel WHERE id NOT IN (SELECT id_materiel FROM Materiel_Affecter)", connection);
                SqlDataAdapter adapMateriels = new SqlDataAdapter(cmdMateriels);
                DataTable dtMateriels = new DataTable();
                adapMateriels.Fill(dtMateriels);
                comboBoxMateriels.DisplayMember = "Reference"; // Le nom du matériel
                comboBoxMateriels.ValueMember = "id";  // L'id du matériel
                comboBoxMateriels.DataSource = dtMateriels;
                LoadMaterielsNonAffectes();

                // Charger les enseignants dans ComboBox2
                SqlCommand cmdEnseignants = new SqlCommand("SELECT * FROM Enseignant", connection);
                SqlDataAdapter adapEnseignants = new SqlDataAdapter(cmdEnseignants);
                DataTable dtEnseignants = new DataTable();
                adapEnseignants.Fill(dtEnseignants);
                comboBoxEnseignants.DisplayMember = "nom";  // Le nom de l'enseignant
                comboBoxEnseignants.ValueMember = "id";  // L'id de l'enseignant
                comboBoxEnseignants.DataSource = dtEnseignants;

                // Charger les matériels affectés dans DataGridView
                SqlCommand cmdAffectations = new SqlCommand("SELECT m.Reference AS Materiel, e.nom AS Enseignant, ma.id FROM Materiel_Affecter ma JOIN Materiel m ON ma.id_materiel = m.id JOIN Enseignant e ON ma.id_enseignant = e.id", connection);
                SqlDataAdapter adapAffectations = new SqlDataAdapter(cmdAffectations);
                DataTable dtAffectations = new DataTable();
                adapAffectations.Fill(dtAffectations);
                dgvMateriels.DataSource = dtAffectations;
            }



        }


        private void dgvMateriels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAffecter_Click(object sender, EventArgs e)
        {
            int idMateriel = Convert.ToInt32(comboBoxMateriels.SelectedValue);
            int idEnseignant = Convert.ToInt32(comboBoxEnseignants.SelectedValue);
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmdAffecter = new SqlCommand("INSERT INTO Materiel_Affecter (id_materiel, id_enseignant) VALUES (@idMateriel, @idEnseignant)", connection);
                cmdAffecter.Parameters.AddWithValue("@idMateriel", idMateriel);
                cmdAffecter.Parameters.AddWithValue("@idEnseignant", idEnseignant);
                connection.Open();
                cmdAffecter.ExecuteNonQuery();
            }

            // Recharger les matériels affectés dans DataGridView
            LoadAffectations();
            LoadMaterielsNonAffectes();

        }

        private void btnLiberer_Click(object sender, EventArgs e)
        {
            // Assure-toi que la cellule sélectionnée correspond à une affectation
            int idAffectation = Convert.ToInt32(dgvMateriels.SelectedRows[0].Cells["id"].Value);

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmdLiberer = new SqlCommand("DELETE FROM Materiel_Affecter WHERE id = @idAffectation", connection);
                cmdLiberer.Parameters.AddWithValue("@idAffectation", idAffectation);
                connection.Open();
                cmdLiberer.ExecuteNonQuery();
            }

            // Recharger les matériels affectés dans DataGridView
            LoadAffectations();
            LoadMaterielsNonAffectes();

        }
        private void LoadAffectations()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmdAffectations = new SqlCommand("SELECT m.Reference AS Materiel, e.nom AS Enseignant, ma.id FROM Materiel_Affecter ma JOIN Materiel m ON ma.id_materiel = m.id JOIN Enseignant e ON ma.id_enseignant = e.id", connection);
                SqlDataAdapter adapAffectations = new SqlDataAdapter(cmdAffectations);
                DataTable dtAffectations = new DataTable();
                adapAffectations.Fill(dtAffectations);
                dgvMateriels.DataSource = dtAffectations;
            }
        }

        private void LoadMaterielsNonAffectes()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Sélectionner uniquement les matériels non affectés
                string queryMaterielsNonAffectes = @"
            SELECT * 
            FROM Materiel 
            WHERE id NOT IN (SELECT id_materiel FROM Materiel_Affecter)";
                SqlCommand cmdMaterielsNonAffectes = new SqlCommand(queryMaterielsNonAffectes, connection);
                SqlDataAdapter adapMaterielsNonAffectes = new SqlDataAdapter(cmdMaterielsNonAffectes);
                DataTable dtMaterielsNonAffectes = new DataTable();
                adapMaterielsNonAffectes.Fill(dtMaterielsNonAffectes);

                // Associer les données au ComboBox
                comboBoxMateriels.DisplayMember = "Reference"; // Afficher la référence du matériel
                comboBoxMateriels.ValueMember = "id"; // Utiliser l'ID du matériel comme valeur
                comboBoxMateriels.DataSource = dtMaterielsNonAffectes;
            }
        }

    }
}

