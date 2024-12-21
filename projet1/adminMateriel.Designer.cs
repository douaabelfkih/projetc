namespace projet1
{
    partial class adminMateriel
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
            btnmat = new Button();
            button2 = new Button();
            panel2 = new Panel();
            btnRe = new Button();
            btnexit = new Button();
            Add = new Button();
            Edit = new Button();
            delete = new Button();
            dataGridView1 = new DataGridView();
            txtDepart = new TextBox();
            txtReference = new TextBox();
            txtType = new TextBox();
            txtNom = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
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
            panel1.Paint += panel1_Paint;
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
            pictureBox2.Location = new Point(1141, 3);
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
            // btnmat
            // 
            btnmat.BackColor = SystemColors.ControlLightLight;
            btnmat.Cursor = Cursors.Hand;
            btnmat.FlatAppearance.BorderSize = 0;
            btnmat.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnmat.FlatStyle = FlatStyle.Flat;
            btnmat.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmat.ForeColor = SystemColors.GrayText;
            btnmat.Image = Properties.Resources.icons8_teacher_64;
            btnmat.Location = new Point(-105, 29);
            btnmat.Name = "btnmat";
            btnmat.Size = new Size(437, 63);
            btnmat.TabIndex = 5;
            btnmat.Text = "                                        Technicien";
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
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.icons8_servers_group_50;
            button2.Location = new Point(-126, 132);
            button2.Name = "button2";
            button2.Size = new Size(457, 63);
            button2.TabIndex = 3;
            button2.Text = "                                    Materiel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnRe);
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(btnmat);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 629);
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
            btnRe.Size = new Size(109, 47);
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
            btnexit.Size = new Size(109, 47);
            btnexit.TabIndex = 8;
            btnexit.Text = "       Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click_1;
            // 
            // Add
            // 
            Add.ForeColor = Color.Black;
            Add.Location = new Point(458, 518);
            Add.Margin = new Padding(3, 4, 3, 4);
            Add.Name = "Add";
            Add.Size = new Size(144, 39);
            Add.TabIndex = 11;
            Add.Text = "Ajouter";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Edit
            // 
            Edit.ForeColor = Color.Black;
            Edit.Location = new Point(664, 518);
            Edit.Margin = new Padding(3, 4, 3, 4);
            Edit.Name = "Edit";
            Edit.Size = new Size(144, 39);
            Edit.TabIndex = 10;
            Edit.Text = "Modifier";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // delete
            // 
            delete.ForeColor = Color.Black;
            delete.Location = new Point(868, 518);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(144, 39);
            delete.TabIndex = 9;
            delete.Text = "Supprimer";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(381, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(744, 220);
            dataGridView1.TabIndex = 12;
            // 
            // txtDepart
            // 
            txtDepart.Location = new Point(50, 26);
            txtDepart.Name = "txtDepart";
            txtDepart.Size = new Size(125, 27);
            txtDepart.TabIndex = 13;
            // 
            // txtReference
            // 
            txtReference.Location = new Point(46, 26);
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(125, 27);
            txtReference.TabIndex = 14;
            // 
            // txtType
            // 
            txtType.Location = new Point(35, 37);
            txtType.Name = "txtType";
            txtType.Size = new Size(125, 27);
            txtType.TabIndex = 15;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(27, 37);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(125, 27);
            txtNom.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNom);
            groupBox1.Location = new Point(327, 397);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 81);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nom";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(txtType);
            groupBox2.Location = new Point(540, 397);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(184, 81);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Type";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtReference);
            groupBox3.Location = new Point(197, 74);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(206, 71);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDepart);
            groupBox4.Location = new Point(971, 397);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(214, 81);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Departement";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox1);
            groupBox5.Location = new Point(750, 397);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(193, 81);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Reference";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // adminMateriel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 648);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Add);
            Controls.Add(Edit);
            Controls.Add(delete);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.Crimson;
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminMateriel";
            Text = "Enseignant";
            Load += adminMateriel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnmat;
        private Button button2;
        private Panel panel2;
        private Button btnRe;
        private Button btnexit;
        private Button Add;
        private Button Edit;
        private Button delete;
        private DataGridView dataGridView1;
        private TextBox txtDepart;
        private TextBox txtReference;
        private TextBox txtType;
        private TextBox txtNom;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox textBox1;
    }
}