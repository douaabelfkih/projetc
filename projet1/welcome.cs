using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet1
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void btnMateriel_Click(object sender, EventArgs e)
        {
            loginadmin loginAdmin = new loginadmin();
            loginAdmin.Show();
            this.Hide();
        }

        private void btnEns_Click(object sender, EventArgs e)
        {
            loginens loginEnd = new loginens();
            loginEnd.Show();
            this.Hide();
        }

        private void btndem_Click(object sender, EventArgs e)
        {
            logintech loginTech = new logintech();
            loginTech.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
