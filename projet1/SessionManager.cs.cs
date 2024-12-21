using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace projet1
{
    internal class SessionManager
    {
        private static int currentUserId;
        private static string currentUserType;

        public static void Login(string username, string password)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Vérifier l'utilisateur dans la table Technicien
                string queryTechnicien = "SELECT Id FROM technicien WHERE Nom = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(queryTechnicien, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        SetCurrentUser((int)result, "technicien");
                        return;
                    }
                }

                // Vérifier l'utilisateur dans la table Enseignant
                string queryEnseignant = "SELECT Id FROM Enseignant WHERE Nom = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(queryEnseignant, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        SetCurrentUser((int)result, "Enseignant");
                        return;
                    }
                }

                throw new Exception("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }

        public static void SetCurrentUser(int id, string userType)
        {
            currentUserId = id;
            currentUserType = userType;
        }

        public static int GetCurrentUserId()
        {
            if (currentUserId == 0)
            {
                throw new Exception("Aucun utilisateur connecté.");
            }
            return currentUserId;
        }

        public static string GetCurrentUserType()
        {
            if (string.IsNullOrEmpty(currentUserType))
            {
                throw new Exception("Aucun utilisateur connecté.");
            }
            return currentUserType;
        }

        public static bool ValidateUserId(int Id)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Vérifier dans les deux tables (Technicien et Enseignant)
                string query = "SELECT COUNT(*) FROM technicien WHERE Id = @Id UNION ALL SELECT COUNT(*) FROM Enseignant WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public static int GetCurrentEnseignantId()
        {
            if (currentUserType == "Enseignant")
            {
                return currentUserId;
            }
            throw new Exception("L'utilisateur actuel n'est pas un enseignant.");
        }

    }
}
