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
    public partial class loginens : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        public loginens()
        {
            InitializeComponent();
        }

        private void loginens_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs
            string Nom = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Chaîne de connexion (remplacez par vos propres paramètres)
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";

            // Requête SQL pour récupérer l'id de l'enseignant
            string query = "SELECT Id FROM Enseignant WHERE Nom = @Nom AND Password = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nom", Nom);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    var result = command.ExecuteScalar(); // Retourne l'id ou null

                    if (result != null)
                    {
                        // Si les identifiants sont valides, on récupère l'id
                        int idEnseignant = Convert.ToInt32(result);

                        // Stocker l'id dans une variable ou une classe globale
                        SessionManager.SetCurrentEnseignantId(idEnseignant);

                        // Afficher un message de succès
                        MessageBox.Show("Connexion réussie !");
                        ensform welcomeens = new ensform();
                        welcomeens.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Si les identifiants sont incorrects
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

    }
}
