namespace projet1
{
    partial class Demande
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
            button1 = new Button();
            btnmat = new Button();
            btnEns = new Button();
            panel2 = new Panel();
            btnR = new Button();
            btnexit = new Button();
            dgvDemandes = new DataGridView();
            btnAccepter = new Button();
            btnRefuser = new Button();
            txtCommentaire = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDemandes).BeginInit();
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 119, 18);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.GrayText;
            button1.Image = Properties.Resources.icons8_demand_50;
            button1.Location = new Point(-126, 233);
            button1.Name = "button1";
            button1.Size = new Size(457, 63);
            button1.TabIndex = 6;
            button1.Text = "                                  Demande";
            button1.UseVisualStyleBackColor = false;
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
            // btnEns
            // 
            btnEns.BackColor = SystemColors.ControlLightLight;
            btnEns.Cursor = Cursors.Hand;
            btnEns.FlatAppearance.BorderSize = 0;
            btnEns.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnEns.FlatStyle = FlatStyle.Flat;
            btnEns.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEns.ForeColor = SystemColors.GrayText;
            btnEns.Image = Properties.Resources.icons8_teacher_64;
            btnEns.Location = new Point(-126, 132);
            btnEns.Name = "btnEns";
            btnEns.Size = new Size(457, 63);
            btnEns.TabIndex = 3;
            btnEns.Text = "                                    Enseignant";
            btnEns.UseVisualStyleBackColor = false;
            btnEns.Click += btnEns_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnR);
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(btnC);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnmat);
            panel2.Controls.Add(btnEns);
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 630);
            panel2.TabIndex = 5;
            // 
            // btnR
            // 
            btnR.BackColor = SystemColors.ControlLightLight;
            btnR.Cursor = Cursors.Hand;
            btnR.FlatAppearance.BorderSize = 0;
            btnR.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnR.FlatStyle = FlatStyle.Flat;
            btnR.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnR.ForeColor = SystemColors.GrayText;
            btnR.Image = Properties.Resources.icons8_return_24;
            btnR.ImageAlign = ContentAlignment.MiddleLeft;
            btnR.Location = new Point(22, 551);
            btnR.Name = "btnR";
            btnR.Size = new Size(109, 30);
            btnR.TabIndex = 9;
            btnR.Text = "    Retour";
            btnR.UseVisualStyleBackColor = false;
            btnR.Click += btnR_Click;
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
            btnexit.Location = new Point(187, 551);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(109, 30);
            btnexit.TabIndex = 8;
            btnexit.Text = "    Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += button5_Click;
            // 
            // dgvDemandes
            // 
            dgvDemandes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDemandes.Location = new Point(400, 175);
            dgvDemandes.Name = "dgvDemandes";
            dgvDemandes.RowHeadersWidth = 51;
            dgvDemandes.Size = new Size(762, 393);
            dgvDemandes.TabIndex = 6;
            dgvDemandes.CellContentClick += dgvDemandes_CellContentClick;
            // 
            // btnAccepter
            // 
            btnAccepter.Location = new Point(744, 592);
            btnAccepter.Name = "btnAccepter";
            btnAccepter.Size = new Size(94, 29);
            btnAccepter.TabIndex = 7;
            btnAccepter.Text = "button2";
            btnAccepter.UseVisualStyleBackColor = true;
            btnAccepter.Click += btnAccepter_Click;
            // 
            // btnRefuser
            // 
            btnRefuser.Location = new Point(881, 592);
            btnRefuser.Name = "btnRefuser";
            btnRefuser.Size = new Size(94, 29);
            btnRefuser.TabIndex = 8;
            btnRefuser.Text = "button3";
            btnRefuser.UseVisualStyleBackColor = true;
            btnRefuser.Click += btnRefuser_Click;
            // 
            // txtCommentaire
            // 
            txtCommentaire.Location = new Point(1028, 594);
            txtCommentaire.Name = "txtCommentaire";
            txtCommentaire.Size = new Size(125, 27);
            txtCommentaire.TabIndex = 9;
            // 
            // Demande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 648);
            Controls.Add(txtCommentaire);
            Controls.Add(btnRefuser);
            Controls.Add(btnAccepter);
            Controls.Add(dgvDemandes);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Demande";
            Text = "Demande";
            Load += Demande_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDemandes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnC;
        private Button button1;
        private Button btnmat;
        private Button btnEns;
        private Panel panel2;
        private Button btnR;
        private Button btnexit;
        private DataGridView dgvDemandes;
        private Button btnAccepter;
        private Button btnRefuser;
        private TextBox txtCommentaire;
    }
}