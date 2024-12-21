namespace projet1
{
    partial class adminform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnexit = new Button();
            btnMateriel = new Button();
            btnEns = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(1215, 67);
            panel1.TabIndex = 0;
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
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(btnMateriel);
            panel2.Controls.Add(btnEns);
            panel2.Location = new Point(201, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(718, 548);
            panel2.TabIndex = 1;
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
            btnexit.Location = new Point(309, 471);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(109, 41);
            btnexit.TabIndex = 8;
            btnexit.Text = "      Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // btnMateriel
            // 
            btnMateriel.BackColor = SystemColors.ButtonFace;
            btnMateriel.Cursor = Cursors.Hand;
            btnMateriel.FlatAppearance.BorderSize = 0;
            btnMateriel.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnMateriel.FlatStyle = FlatStyle.Flat;
            btnMateriel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMateriel.ForeColor = SystemColors.GrayText;
            btnMateriel.Image = Properties.Resources.icons8_servers_group_50;
            btnMateriel.ImageAlign = ContentAlignment.MiddleLeft;
            btnMateriel.Location = new Point(215, 140);
            btnMateriel.Name = "btnMateriel";
            btnMateriel.Size = new Size(315, 63);
            btnMateriel.TabIndex = 5;
            btnMateriel.Text = "Technicien";
            btnMateriel.UseVisualStyleBackColor = false;
            btnMateriel.Click += btnMateriel_Click;
            // 
            // btnEns
            // 
            btnEns.BackColor = SystemColors.ButtonFace;
            btnEns.Cursor = Cursors.Hand;
            btnEns.FlatAppearance.BorderSize = 0;
            btnEns.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btnEns.FlatStyle = FlatStyle.Flat;
            btnEns.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEns.ForeColor = SystemColors.GrayText;
            btnEns.Image = Properties.Resources.icons8_teacher_64;
            btnEns.ImageAlign = ContentAlignment.MiddleLeft;
            btnEns.Location = new Point(215, 229);
            btnEns.Name = "btnEns";
            btnEns.Size = new Size(319, 63);
            btnEns.TabIndex = 3;
            btnEns.Text = "Materiel";
            btnEns.UseVisualStyleBackColor = false;
            btnEns.Click += btnEns_Click;
            // 
            // adminform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 695);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminform";
            Text = "adminform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnMateriel;
        private Button btnEns;
        private Button btnexit;
    }
}
