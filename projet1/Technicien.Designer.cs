namespace projet1
{
    partial class Technicien
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
            delete = new Button();
            Edit = new Button();
            Add = new Button();
            dataGridView1 = new DataGridView();
            txtNom = new TextBox();
            txtPassword = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
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
            // button4
            // 
            button4.BackColor = Color.FromArgb(227, 119, 18);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = Properties.Resources.icons8_teacher_64;
            button4.Location = new Point(-105, 29);
            button4.Name = "button4";
            button4.Size = new Size(437, 63);
            button4.TabIndex = 5;
            button4.Text = "                                       Technicien";
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
            btnEns.Image = Properties.Resources.icons8_servers_group_50;
            btnEns.Location = new Point(-126, 132);
            btnEns.Name = "btnEns";
            btnEns.Size = new Size(457, 63);
            btnEns.TabIndex = 3;
            btnEns.Text = "                                    Materiel";
            btnEns.UseVisualStyleBackColor = false;
            btnEns.Click += btnEns_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnR);
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnEns);
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 629);
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
            btnR.Size = new Size(109, 43);
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
            btnexit.Size = new Size(109, 43);
            btnexit.TabIndex = 4;
            btnexit.Text = "      Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // delete
            // 
            delete.Location = new Point(912, 543);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(144, 39);
            delete.TabIndex = 5;
            delete.Text = "Supprimer";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Edit
            // 
            Edit.Location = new Point(675, 543);
            Edit.Margin = new Padding(3, 4, 3, 4);
            Edit.Name = "Edit";
            Edit.Size = new Size(144, 39);
            Edit.TabIndex = 6;
            Edit.Text = "Modifier";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Add
            // 
            Add.Location = new Point(420, 554);
            Add.Margin = new Padding(3, 4, 3, 4);
            Add.Name = "Add";
            Add.Size = new Size(144, 39);
            Add.TabIndex = 7;
            Add.Text = "Ajouter";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(380, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(780, 188);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(56, 50);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(59, 62);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNom);
            groupBox1.Location = new Point(450, 363);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nom";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Location = new Point(826, 363);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "password";
            // 
            // Technicien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 695);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Add);
            Controls.Add(Edit);
            Controls.Add(delete);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Technicien";
            Text = "Materiel";
            Load += Technicien_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Button btnexit;
        private Button btnR;
        private Button delete;
        private Button Edit;
        private Button Add;
        private DataGridView dataGridView1;
        private TextBox txtNom;
        private TextBox txtPassword;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}