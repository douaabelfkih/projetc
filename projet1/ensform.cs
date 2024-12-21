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
    public partial class ensform : Form
    {
        public ensform()
        {
            InitializeComponent();
        }

        private void btndem_Click(object sender, EventArgs e)
        {
            ensdemande cl = new ensdemande(); cl.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Chat cl = new Chat(); cl.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
