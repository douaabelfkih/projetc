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

        private void ChargerUtilisateurs()
        {
            string query = "SELECT id, nom FROM Technicien UNION SELECT id, nom FROM Enseignant WHERE id != @idActuel";

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idActuel", SessionManager.GetCurrentUserId());

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "nom";
                comboBox1.ValueMember = "id";
            }
        }

        // Envoyer un message
        public static void EnvoyerMessage(string texte, int destinataireId)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            using (SqlConnection cnx = new SqlConnection(connectionString))
            {
                cnx.Open();
                string query = @"
                 INSERT INTO Message (id_sender, id_receiver, message_content, timestamp)
                 VALUES (@idSender, @idReceiver, @messageContent, @timestamp)";

                using (SqlCommand command = new SqlCommand(query, cnx))
                {
                    command.Parameters.AddWithValue("@idSender", SessionManager.GetCurrentUserId());
                    command.Parameters.AddWithValue("@idReceiver", destinataireId);
                    command.Parameters.AddWithValue("@messageContent", texte);
                    command.Parameters.AddWithValue("@timestamp", DateTime.Now);

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
            ChargerUtilisateurs();
            ChargerMessages();
        }
        private void ChargerMessages()
        {
            string query = @"SELECT 
                     m.message_content AS Message,
                     u1.nom AS Expediteur,
                     u2.nom AS Destinataire,
                     m.timestamp AS Date
                  FROM Message m
                  JOIN (
                      SELECT id, nom FROM Technicien UNION SELECT id, nom FROM Enseignant
                  ) u1 ON m.id_sender = u1.id
                  JOIN (
                      SELECT id, nom FROM Technicien UNION SELECT id, nom FROM Enseignant
                  ) u2 ON m.id_receiver = u2.id
                  WHERE m.id_sender = @idActuel OR m.id_receiver = @idActuel
                  ORDER BY m.timestamp";

            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idActuel", SessionManager.GetCurrentUserId());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Créer une nouvelle colonne "MessageWithSender" pour concaténer les noms et le message
                DataColumn messageWithSenderColumn = new DataColumn("MessageWithSender", typeof(string));
                dt.Columns.Add(messageWithSenderColumn);

                // Remplir la nouvelle colonne avec l'expéditeur, le destinataire et le message
                foreach (DataRow row in dt.Rows)
                {
                    string senderName = row["Expediteur"].ToString();
                    string receiverName = row["Destinataire"].ToString();
                    string messageContent = row["Message"].ToString();

                    // Concaténer l'expéditeur, le destinataire et le message
                    row["MessageWithSender"] = $"{senderName} à {receiverName} : {messageContent}";
                }

                // Afficher la nouvelle colonne dans lstMessages
                lstMessages.DataSource = dt;
                lstMessages.DisplayMember = "MessageWithSender"; // Utiliser "MessageWithSender" pour afficher le nom + message
            }
        }

        private void EnvoyerMessage()
        {
            int idDestinataire = (int)comboBox1.SelectedValue;
            string message = txtMessage.Text;

            if (!string.IsNullOrEmpty(message))
            {
                string query = "INSERT INTO Message (id_sender, id_receiver, message_content, timestamp) " +
                               "VALUES (@idSender, @idReceiver, @content, @timestamp)";

                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idSender", SessionManager.GetCurrentUserId());
                    cmd.Parameters.AddWithValue("@idReceiver", idDestinataire);
                    cmd.Parameters.AddWithValue("@content", message);
                    cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    txtMessage.Clear();
                    ChargerMessages();
                }

            }
            else
            {
                MessageBox.Show("Veuillez écrire un message avant d'envoyer.");
            }
        }

        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            EnvoyerMessage();
        }



        private  void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                EnvoyerMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'envoi du message : {ex.Message}");
            }
        }
        

        

        
        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
