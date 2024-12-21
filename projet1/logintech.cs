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
    public partial class logintech : Form
    {

        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        public logintech()
        {
            InitializeComponent();
        }

        private void logintech_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { // Récupérer les valeurs des champs
            string Nom = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            try
            {
                // Appeler la méthode Login dans SessionManager
                SessionManager.Login(Nom, password);

                // Si l'authentification réussit, affichez le message et redirigez vers WelcomeTech
                MessageBox.Show("Connexion réussie !");
                Form1 welcomeTech = new Form1();
                welcomeTech.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Si une exception se produit (par exemple, utilisateur non trouvé), afficher l'erreur
                MessageBox.Show($"Erreur de connexion : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            welcome cl = new welcome(); cl.Show();
        }
    }
}
