namespace projet1
{
    partial class Enseignant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnC = new Button();
            btndem = new Button();
            btnmat = new Button();
            button2 = new Button();
            panel2 = new Panel();
            btnRe = new Button();
            btnexit = new Button();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 119, 18);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(227, 119, 18);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 67);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1062, 20);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_user_48;
            pictureBox3.Location = new Point(991, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_grid_40;
            pictureBox2.Location = new Point(1147, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.téléchargement__1_;
            pictureBox1.Location = new Point(26, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnC
            // 
            btnC.BackColor = SystemColors.ControlLightLight;
            btnC.Cursor = Cursors.Hand;
            btnC.FlatAppearance.BorderSize = 0;
            btnC.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnC.FlatStyle = FlatStyle.Flat;
            btnC.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnC.ForeColor = SystemColors.GrayText;
            btnC.Image = Properties.Resources.icons8_chat_50;
            btnC.Location = new Point(-126, 316);
            btnC.Name = "btnC";
            btnC.Size = new Size(457, 63);
            btnC.TabIndex = 4;
            btnC.Text = "                          Chat";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btndem
            // 
            btndem.BackColor = SystemColors.ControlLightLight;
            btndem.Cursor = Cursors.Hand;
            btndem.FlatAppearance.BorderSize = 0;
            btndem.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btndem.FlatStyle = FlatStyle.Flat;
            btndem.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndem.ForeColor = SystemColors.GrayText;
            btndem.Image = Properties.Resources.icons8_demand_50;
            btndem.Location = new Point(-126, 233);
            btndem.Name = "btndem";
            btndem.Size = new Size(457, 63);
            btndem.TabIndex = 6;
            btndem.Text = "                                  Demande";
            btndem.UseVisualStyleBackColor = false;
            btndem.Click += btndem_Click;
            // 
            // btnmat
            // 
            btnmat.BackColor = SystemColors.ControlLightLight;
            btnmat.Cursor = Cursors.Hand;
            btnmat.FlatAppearance.BorderSize = 0;
            btnmat.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnmat.FlatStyle = FlatStyle.Flat;
            btnmat.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmat.ForeColor = SystemColors.GrayText;
            btnmat.Image = Properties.Resources.icons8_servers_group_50;
            btnmat.Location = new Point(-105, 29);
            btnmat.Name = "btnmat";
            btnmat.Size = new Size(436, 63);
            btnmat.TabIndex = 5;
            btnmat.Text = "                         Materiel";
            btnmat.UseVisualStyleBackColor = false;
            btnmat.Click += btnmat_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(227, 119, 18);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.GrayText;
            button2.Image = Properties.Resources.icons8_teacher_64;
            button2.Location = new Point(-126, 132);
            button2.Name = "button2";
            button2.Size = new Size(457, 63);
            button2.TabIndex = 3;
            button2.Text = "                                    Enseignant";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnRe);
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(btnC);
            panel2.Controls.Add(btndem);
            panel2.Controls.Add(btnmat);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 630);
            panel2.TabIndex = 5;
            // 
            // btnRe
            // 
            btnRe.BackColor = SystemColors.ControlLightLight;
            btnRe.Cursor = Cursors.Hand;
            btnRe.FlatAppearance.BorderSize = 0;
            btnRe.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnRe.FlatStyle = FlatStyle.Flat;
            btnRe.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRe.ForeColor = SystemColors.GrayText;
            btnRe.Image = Properties.Resources.icons8_return_24;
            btnRe.ImageAlign = ContentAlignment.MiddleLeft;
            btnRe.Location = new Point(26, 544);
            btnRe.Name = "btnRe";
            btnRe.Size = new Size(109, 30);
            btnRe.TabIndex = 9;
            btnRe.Text = "    Retour";
            btnRe.UseVisualStyleBackColor = false;
            btnRe.Click += btnRe_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = SystemColors.ControlLightLight;
            btnexit.Cursor = Cursors.Hand;
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnexit.ForeColor = SystemColors.GrayText;
            btnexit.Image = Properties.Resources.icons8_exit_48;
            btnexit.ImageAlign = ContentAlignment.MiddleLeft;
            btnexit.Location = new Point(191, 544);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(109, 30);
            btnexit.TabIndex = 8;
            btnexit.Text = "    Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click_1;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.ForeColor = Color.FromArgb(227, 119, 18);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(809, 453);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lister Les Enseignants";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(781, 441);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(351, 98);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(817, 486);
            tabControl1.TabIndex = 6;
            // 
            // Enseignant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 648);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.Crimson;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Enseignant";
            Text = "Enseignant";
            Load += Enseignant_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnC;
        private Button btndem;
        private Button btnmat;
        private Button button2;
        private Panel panel2;
        private Button btnRe;
        private Button btnexit;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
    }
}