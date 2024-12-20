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
    public partial class Chat : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;

        public Chat()
        {
            InitializeComponent();
        }


        // Envoyer un message
        public static void EnvoyerMessage(string texte, int destinataireId)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection cnx = new SqlConnection(connectionString))

            {
                cnx.Open();
                string query = @"
                INSERT INTO Messages (Texte, ExpediteurId, TypeExpediteur, DestinataireId, DateEnvoi)
                VALUES (@Texte, @ExpediteurId, @TypeExpediteur, @DestinataireId, @DateEnvoi)";

                using (SqlCommand command = new SqlCommand(query, cnx))
                {
                    command.Parameters.AddWithValue("@Texte", texte);
                    command.Parameters.AddWithValue("@ExpediteurId", SessionManager.GetCurrentUserId());
                    command.Parameters.AddWithValue("@TypeExpediteur", SessionManager.GetCurrentUserType());
                    command.Parameters.AddWithValue("@DestinataireId", destinataireId);
                    command.Parameters.AddWithValue("@DateEnvoi", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
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

        private void btndem_Click(object sender, EventArgs e)
        {
            Demande cl = new Demande(); cl.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            Form1 cl = new Form1(); cl.Show();
            this.Hide();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            try
            {
                // Charger les destinataires dans la ComboBox
                var destinataires = Chat.RecupererDestinataires();
                comboBox1.DataSource = destinataires;
                comboBox1.DisplayMember = "Nom";
                comboBox1.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des destinataires : {ex.Message}");
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupérer le texte du message
                string message = txtMessage.Text;

                if (string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Veuillez écrire un message avant d'envoyer.");
                    return;
                }

                // ID du destinataire (à remplacer par un champ ou une sélection réelle)
                int destinataireId = 2; // Exemple : ID de l'autre utilisateur

                // Envoyer le message
                Chat.EnvoyerMessage(message, destinataireId);

                // Mettre à jour la liste des messages
                AfficherMessages(destinataireId);

                // Vider la boîte de texte
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'envoi du message : {ex.Message}");
            }
        }
        private void AfficherMessages(int destinataireId)
        {
            try
            {
                // Récupérer les messages
                var messages = Chat.RecupererMessages(destinataireId);

                // Afficher les messages dans la liste
                lstMessages.Items.Clear();
                foreach (var message in messages)
                {
                    lstMessages.Items.Add(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des messages : {ex.Message}");
            }
        }
        public class Destinataire
        {
            public int Id { get; set; }
            public string Nom { get; set; }
        }

        public static List<string> RecupererMessages(int destinataireId)
        {
            var messages = new List<string>();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
            SELECT Texte, TypeExpediteur, DateEnvoi
            FROM Messages
            WHERE (ExpediteurId = @UserId AND DestinataireId = @DestinataireId)
               OR (ExpediteurId = @DestinataireId AND DestinataireId = @UserId)
            ORDER BY DateEnvoi ASC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", SessionManager.GetCurrentUserId());
                    command.Parameters.AddWithValue("@DestinataireId", destinataireId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string texte = reader["Texte"].ToString();
                            string expediteur = reader["TypeExpediteur"].ToString();
                            string dateEnvoi = Convert.ToDateTime(reader["DateEnvoi"]).ToString("g");

                            messages.Add($"{expediteur} ({dateEnvoi}): {texte}");
                        }
                    }
                }
            }

            return messages;
        }
        public static List<(int Id, string Nom)> RecupererDestinataires()
        {
            var destinataires = new List<(int, string)>();
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = SessionManager.GetCurrentUserType() == "Enseignant" ?
                    "SELECT id, nom FROM Technicien" :
                    "SELECT id, nom FROM Enseignant";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nom = reader.GetString(1);
                        destinataires.Add((id, nom));
                    }
                }
            }

            return destinataires;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
