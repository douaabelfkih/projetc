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

namespace projet1
{
    public partial class Demande : Form
    {

        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        public Demande()
        {
            InitializeComponent();
            LoadDemandes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmat_Click(object sender, EventArgs e)
        {
            Materiel cl = new Materiel(); cl.Show();
            this.Hide();
        }

        private void btnEns_Click(object sender, EventArgs e)
        {
            Enseignant cl = new Enseignant(); cl.Show();
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

        private void Demande_Load(object sender, EventArgs e)
        {

        }
        private void LoadDemandes()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                d.id AS ID_Demande,
                e.nom AS Enseignant,
                e.departement AS Departement,
                m.Type AS TypeMateriel, -- Utilisez le type du matériel
                d.etat AS Etat,
                d.date_demande AS DateDemande,
                d.date_besoin AS DateBesoin,
                d.commentaire AS Commentaire
            FROM DemandeMateriel d
            JOIN Enseignant e ON d.id_enseignant = e.id
            JOIN Materiel m ON d.type_materiel = m.Type"; 



                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dtDemandes = new DataTable();
                adapter.Fill(dtDemandes);

                dgvDemandes.DataSource = dtDemandes;
            }
        }

        private void btnAccepter_Click(object sender, EventArgs e)
        {
            if (dgvDemandes.SelectedRows.Count > 0)
            {
                int idDemande = Convert.ToInt32(dgvDemandes.SelectedRows[0].Cells["ID_Demande"].Value);

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE DemandeMateriel SET etat = 'Acceptée' WHERE id = @idDemande",
                        connection
                    );
                    cmd.Parameters.AddWithValue("@idDemande", idDemande);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                // Recharger les demandes après mise à jour
                LoadDemandes();
                MessageBox.Show("Demande acceptée avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une demande à accepter.");
            }
        }

        private void btnRefuser_Click(object sender, EventArgs e)
        {
            if (dgvDemandes.SelectedRows.Count > 0)
            {
                int idDemande = Convert.ToInt32(dgvDemandes.SelectedRows[0].Cells["ID_Demande"].Value);
                string commentaire = txtCommentaire.Text; // Un TextBox pour le commentaire du responsable

                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE DemandeMateriel SET etat = 'Refusée', commentaire = @commentaire WHERE id = @idDemande",
                        connection
                    );
                    cmd.Parameters.AddWithValue("@idDemande", idDemande);
                    cmd.Parameters.AddWithValue("@commentaire", commentaire);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }

                // Recharger les demandes après mise à jour
                LoadDemandes();
                MessageBox.Show("Demande refusée avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une demande à refuser.");
            }
        }

        private void dgvDemandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDemandes();
        }
    }
}
