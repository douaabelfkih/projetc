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
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        private static int currentUserId;
        private static string currentUserType;

        public static void SetCurrentUser(int id)
        {
            currentUserId = id;
            currentUserType = GetUserTypeFromDatabase(id); // Récupère le type de l'utilisateur
        }

        public static int GetCurrentUserId() => currentUserId;

        public static string GetCurrentUserType() => currentUserType;

        private static string GetUserTypeFromDatabase(int userId)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=monprojet;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Vérifie d'abord dans la table Enseignant
                string queryEnseignant = "SELECT COUNT(*) FROM Enseignant WHERE id = @UserId";
                using (SqlCommand command = new SqlCommand(queryEnseignant, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        return "Enseignant";
                    }
                }

                // Vérifie ensuite dans la table Technicien
                string queryTechnicien = "SELECT COUNT(*) FROM Technicien WHERE id = @UserId";
                using (SqlCommand command = new SqlCommand(queryTechnicien, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        return "Technicien";
                    }
                }
            }

            throw new Exception("Utilisateur introuvable dans les deux tables !");
        }
        public static void SetCurrentEnseignantId(int id)
        {
            // Si nécessaire, tu peux aussi vérifier que l'utilisateur est un enseignant ici
            currentUserId = id;
            currentUserType = "Enseignant";
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
