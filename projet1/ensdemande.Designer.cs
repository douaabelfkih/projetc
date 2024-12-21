namespace projet1
{
    partial class ensdemande
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
            groupBox2 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            groupBox1 = new GroupBox();
            btnR = new Button();
            btnexit = new Button();
            panel2 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Location = new Point(626, 447);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 82);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Date de besoin";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(19, 42);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(669, 563);
            button2.Name = "button2";
            button2.Size = new Size(151, 39);
            button2.TabIndex = 3;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(483, 565);
            button4.Name = "button4";
            button4.Size = new Size(151, 37);
            button4.TabIndex = 3;
            button4.Text = "Ajouter";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(19, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(8, 26);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(377, 450);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 79);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Type de matériel ";
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
            btnR.Location = new Point(35, 508);
            btnR.Name = "btnR";
            btnR.Size = new Size(109, 40);
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
            btnexit.Location = new Point(177, 508);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(109, 40);
            btnexit.TabIndex = 8;
            btnexit.Text = "      Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnR);
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 581);
            panel2.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(227, 119, 18);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.icons8_home_48;
            button1.Location = new Point(-113, 30);
            button1.Name = "button1";
            button1.Size = new Size(457, 63);
            button1.TabIndex = 6;
            button1.Text = "                                    Demande";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1062, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 3;
            label1.Text = "Admin";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_user_48;
            pictureBox3.Location = new Point(991, 3);
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
            pictureBox1.Size = new Size(86, 61);
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
            panel1.Size = new Size(1197, 67);
            panel1.TabIndex = 14;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Location = new Point(967, 450);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 80);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Durée d'utilisation";
            // 
            // button5
            // 
            button5.Location = new Point(855, 563);
            button5.Name = "button5";
            button5.Size = new Size(151, 38);
            button5.TabIndex = 22;
            button5.Text = "Supprimer";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(327, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(857, 260);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ensdemande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 648);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(groupBox4);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ensdemande";
            Text = "ensdemande";
            Load += ensdemande_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button button2;
        private Button button4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox1;
        private Button btnR;
        private Button btnexit;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox4;
        private Button button5;
        private DataGridView dataGridView1;
    }
}