﻿using System;
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
    public partial class ensdemande : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;

        public ensdemande()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ensdemande_Load(object sender, EventArgs e)
        {
            // Récupérer les types de matériel à partir de la base de données
            LoadMaterialTypes();
            // Récupérer les durées possibles (1 jour, 2 jours, etc.)
            LoadDurations();
            ChargerDemandes();
        }

        private void ChargerDemandes()
        {
            // Connexion à la base de données
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            // Requête SQL pour récupérer les demandes de l'enseignant connecté, y compris la durée d'utilisation
            string query = @"SELECT 
                        dm.id AS Id,
                        dm.type_materiel AS TypeMateriel, 
                        dm.date_besoin AS DateBesoin, 
                        dm.etat AS Etat, 
                        dm.date_demande AS DateDemande,
                        dm.commentaire AS Commentaire,
                        dm.duree_utilisation AS DureeUtilisation  -- Ajout de la colonne durée d'utilisation
                    FROM DemandeMateriel dm 
                    WHERE dm.id_enseignant = @idEnseignant";  // Filtre par id_enseignant

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@idEnseignant", SessionManager.GetCurrentEnseignantId());  // ID de l'enseignant connecté

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Lier le DataTable au DataGridView
                dataGridView1.DataSource = dt;

                // Optionnel : personnalisation de l'affichage des colonnes
                dataGridView1.Columns["DateDemande"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns["DateBesoin"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns["Etat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["TypeMateriel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["Commentaire"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["DureeUtilisation"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  // Colonne de durée
            }
        }
        private void LoadMaterialTypes()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            string query = "SELECT Type FROM Materiel"; // Adapté à votre base

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, cnx);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Type";
                comboBox1.ValueMember = "Type";
            }
        }

        // Charger les durées (exemple : 1 jour, 2 jours, etc.)
        private void LoadDurations()
        {
            comboBox2.Items.Add("1 jour");
            comboBox2.Items.Add("2 jours");
            comboBox2.Items.Add("3 jours");
            // Ajoutez plus de durées si nécessaire
        }

        // Charger les quantités (exemple : 1, 2, 3, 4, etc.)


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Vérifiez si une ligne est sélectionnée
                if (dataGridView1.CurrentRow != null)
                {
                    // Récupérez la ligne actuellement sélectionnée
                    var currentRow = dataGridView1.CurrentRow;

                    // Assignez les valeurs des cellules aux ComboBox
                    comboBox1.Text = currentRow.Cells[0]?.Value?.ToString() ?? "";
                    comboBox2.Text = currentRow.Cells[1]?.Value?.ToString() ?? "";


                    // Tentez de convertir la cellule en une date et l'assignez au DateTimePicker
                    if (DateTime.TryParse(currentRow.Cells[2]?.Value?.ToString(), out DateTime selectedDate))
                    {
                        dateTimePicker1.Value = selectedDate;
                    }
                    else
                    {
                        // Définit une date par défaut et affiche un avertissement si la conversion échoue
                        dateTimePicker1.Value = DateTime.Today;
                        MessageBox.Show("La date est invalide ou absente. Une date par défaut a été assignée.",
                                        "Avertissement",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Message si aucune ligne n'est sélectionnée
                    MessageBox.Show("Aucune ligne sélectionnée. Veuillez double-cliquer sur une ligne de la table.",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Gestion des exceptions avec affichage d'un message
                MessageBox.Show($"Erreur : {ex.Message}",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les informations des champs de saisie
                string selectedTypeMateriel = comboBox1.SelectedValue?.ToString(); // Type de matériel
                string selectedDuration = comboBox2.SelectedItem?.ToString(); // Durée
                DateTime selectedDateBesoin = dateTimePicker1.Value; // Date de besoin
                int idEnseignant = SessionManager.GetCurrentEnseignantId(); // ID de l'enseignant connecté

                // Vérification des valeurs saisies
                if (string.IsNullOrEmpty(selectedTypeMateriel) || string.IsNullOrEmpty(selectedDuration))
                {
                    MessageBox.Show("Veuillez remplir tous les champs correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Appel de la méthode d'insertion
                InsertRequestToDatabase(idEnseignant, selectedTypeMateriel, selectedDuration, selectedDateBesoin);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Méthode pour insérer la demande dans la base de données
        private void InsertRequestToDatabase(int enseignantId, string typeMateriel, string duration, DateTime dateBesoin)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            string query = "INSERT INTO DemandeMateriel (id_enseignant, type_materiel, etat, date_demande, date_besoin, commentaire, duree_utilisation) " +
                           "VALUES (@id_enseignant, @type_materiel, @etat, @date_demande, @date_besoin, @commentaire, @duree_utilisation)";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id_enseignant", enseignantId);
                cmd.Parameters.AddWithValue("@type_materiel", typeMateriel);
                cmd.Parameters.AddWithValue("@etat", "En attente");
                cmd.Parameters.AddWithValue("@date_demande", DateTime.Now);
                cmd.Parameters.AddWithValue("@date_besoin", dateBesoin);
                cmd.Parameters.AddWithValue("@commentaire", "Demande de matériel");
                cmd.Parameters.AddWithValue("@duree_utilisation", duration);  // 

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Votre demande a été envoyée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement de la demande : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void btnR_Click(object sender, EventArgs e)
        {
            ensform cl = new ensform(); cl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérifier qu'une ligne est sélectionnée
                if (dataGridView1.CurrentRow != null)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);  // Récupérer l'ID de la ligne sélectionnée
                    string selectedTypeMateriel = comboBox1.SelectedValue?.ToString();
                    string selectedEtat = "En attente"; // Assurez-vous que vous avez un combobox ou textbox pour l'état
                    DateTime selectedDateBesoin = dateTimePicker1.Value;
                    string selectedDuration = comboBox2.SelectedItem?.ToString(); // Durée sélectionnée

                    // Vérification des valeurs saisies
                    if (string.IsNullOrEmpty(selectedTypeMateriel) || string.IsNullOrEmpty(selectedEtat) || string.IsNullOrEmpty(selectedDuration))
                    {
                        MessageBox.Show("Veuillez remplir tous les champs correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Appel de la méthode de mise à jour dans la base de données
                    UpdateRequestInDatabase(selectedId, selectedTypeMateriel, selectedDateBesoin, selectedDuration);
                }
                else
                {
                    MessageBox.Show("Aucune ligne sélectionnée. Veuillez sélectionner une demande pour la modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRequestInDatabase(int id, string typeMateriel, DateTime dateBesoin, string dureeUtilisation)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            string query = @"UPDATE DemandeMateriel
                     SET type_materiel = @typeMateriel,
                         
                         date_besoin = @dateBesoin,
                         duree_utilisation = @dureeUtilisation  -- Mise à jour de la durée
                     WHERE id = @id";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@typeMateriel", typeMateriel);
                
                cmd.Parameters.AddWithValue("@dateBesoin", dateBesoin);
                cmd.Parameters.AddWithValue("@dureeUtilisation", dureeUtilisation); // Ajout de la durée
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Demande modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerDemandes();  // Rafraîchir les demandes dans le DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour de la demande : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                // Vérifier qu'une ligne est sélectionnée
                if (dataGridView1.CurrentRow != null)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);  // Récupérer l'ID de la ligne sélectionnée

                    // Confirmer la suppression
                    DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette demande ?",
                                                          "Confirmer la suppression",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Appel de la méthode pour supprimer la demande
                        DeleteRequestFromDatabase(selectedId);
                    }
                }
                else
                {
                    MessageBox.Show("Aucune ligne sélectionnée. Veuillez sélectionner une demande pour la supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRequestFromDatabase(int id)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            string query = "DELETE FROM DemandeMateriel WHERE id = @id";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Demande supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChargerDemandes();  // Rafraîchir les demandes dans le DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression de la demande : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
