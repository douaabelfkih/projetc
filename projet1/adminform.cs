namespace projet1
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void btnMateriel_Click(object sender, EventArgs e)
        {
            Technicien cl = new Technicien(); cl.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEns_Click(object sender, EventArgs e)
        {
            adminMateriel cl = new adminMateriel(); cl.Show();
            this.Hide();
        }

        private void btndem_Click(object sender, EventArgs e)
        {
            Departement cl = new Departement(); cl.Show();
            this.Hide();
        }
    }
}
