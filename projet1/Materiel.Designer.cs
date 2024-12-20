namespace projet1
{
    partial class Materiel
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            btnEns = new Button();
            panel2 = new Panel();
            btnR = new Button();
            btnexit = new Button();
            btnC = new Button();
            btnDEm = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            treeView1 = new TreeView();
            tabPage2 = new TabPage();
            btnLiberer = new Button();
            btnAffecter = new Button();
            comboBoxEnseignants = new ComboBox();
            comboBoxMateriels = new ComboBox();
            dgvMateriels = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMateriels).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(1215, 67);
            panel1.TabIndex = 2;
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
            // button4
            // 
            button4.BackColor = Color.FromArgb(227, 119, 18);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.GrayText;
            button4.Image = Properties.Resources.icons8_servers_group_50;
            button4.Location = new Point(-105, 29);
            button4.Name = "button4";
            button4.Size = new Size(436, 63);
            button4.TabIndex = 5;
            button4.Text = "                         Materiel";
            button4.UseVisualStyleBackColor = false;
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
            panel2.Controls.Add(btnDEm);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnEns);
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 630);
            panel2.TabIndex = 3;
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
            btnR.Location = new Point(26, 571);
            btnR.Name = "btnR";
            btnR.Size = new Size(109, 30);
            btnR.TabIndex = 7;
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
            btnexit.Location = new Point(191, 571);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(109, 30);
            btnexit.TabIndex = 4;
            btnexit.Text = "    Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
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
            // btnDEm
            // 
            btnDEm.BackColor = SystemColors.ControlLightLight;
            btnDEm.Cursor = Cursors.Hand;
            btnDEm.FlatAppearance.BorderSize = 0;
            btnDEm.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnDEm.FlatStyle = FlatStyle.Flat;
            btnDEm.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDEm.ForeColor = SystemColors.GrayText;
            btnDEm.Image = Properties.Resources.icons8_demand_50;
            btnDEm.Location = new Point(-126, 233);
            btnDEm.Name = "btnDEm";
            btnDEm.Size = new Size(457, 63);
            btnDEm.TabIndex = 6;
            btnDEm.Text = "                                  Demande";
            btnDEm.UseVisualStyleBackColor = false;
            btnDEm.Click += btnDEm_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(337, 96);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(853, 557);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(treeView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(845, 524);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lister Les Materiels";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(53, 27);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(733, 406);
            treeView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(dgvMateriels);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(845, 524);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Etat de Materiel";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLiberer
            // 
            btnLiberer.BackColor = SystemColors.ControlLightLight;
            btnLiberer.Cursor = Cursors.Hand;
            btnLiberer.FlatAppearance.BorderSize = 0;
            btnLiberer.FlatStyle = FlatStyle.Flat;
            btnLiberer.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLiberer.ForeColor = SystemColors.GrayText;
            btnLiberer.Location = new Point(42, 68);
            btnLiberer.Name = "btnLiberer";
            btnLiberer.Size = new Size(218, 53);
            btnLiberer.TabIndex = 3;
            btnLiberer.Text = "Libérer";
            btnLiberer.UseVisualStyleBackColor = false;
            btnLiberer.Click += btnLiberer_Click;
            // 
            // btnAffecter
            // 
            btnAffecter.BackColor = SystemColors.ControlLightLight;
            btnAffecter.FlatAppearance.BorderSize = 0;
            btnAffecter.FlatStyle = FlatStyle.Flat;
            btnAffecter.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAffecter.ForeColor = SystemColors.GrayText;
            btnAffecter.Location = new Point(62, 144);
            btnAffecter.Name = "btnAffecter";
            btnAffecter.Size = new Size(183, 50);
            btnAffecter.TabIndex = 9;
            btnAffecter.Text = "Affecter";
            btnAffecter.UseVisualStyleBackColor = false;
            btnAffecter.Click += btnAffecter_Click;
            // 
            // comboBoxEnseignants
            // 
            comboBoxEnseignants.FormattingEnabled = true;
            comboBoxEnseignants.Location = new Point(62, 94);
            comboBoxEnseignants.Name = "comboBoxEnseignants";
            comboBoxEnseignants.Size = new Size(183, 36);
            comboBoxEnseignants.TabIndex = 8;
            // 
            // comboBoxMateriels
            // 
            comboBoxMateriels.FormattingEnabled = true;
            comboBoxMateriels.Location = new Point(62, 43);
            comboBoxMateriels.Name = "comboBoxMateriels";
            comboBoxMateriels.Size = new Size(183, 36);
            comboBoxMateriels.TabIndex = 7;
            comboBoxMateriels.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dgvMateriels
            // 
            dgvMateriels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriels.Location = new Point(22, 3);
            dgvMateriels.Name = "dgvMateriels";
            dgvMateriels.RowHeadersWidth = 51;
            dgvMateriels.Size = new Size(485, 392);
            dgvMateriels.TabIndex = 6;
            dgvMateriels.CellContentClick += dgvMateriels_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxMateriels);
            groupBox1.Controls.Add(comboBoxEnseignants);
            groupBox1.Controls.Add(btnAffecter);
            groupBox1.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(227, 119, 18);
            groupBox1.Location = new Point(521, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 207);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Affecter à";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLiberer);
            groupBox2.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(227, 119, 18);
            groupBox2.Location = new Point(521, 274);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 152);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Libérer";
            // 
            // Materiel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 695);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Materiel";
            Text = "Materiel";
            Load += Materiel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMateriels).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button4;
        private Button btnEns;
        private Panel panel2;
        private Button btnC;
        private Button btnDEm;
        private Button btnexit;
        private Button btnR;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TreeView treeView1;
        private DataGridView dgvMateriels;
        private ComboBox comboBoxMateriels;
        private Button btnLiberer;
        private Button btnAffecter;
        private ComboBox comboBoxEnseignants;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}