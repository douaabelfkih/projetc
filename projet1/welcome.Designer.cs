namespace projet1
{
    partial class welcome
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            btnexit = new Button();
            btndem = new Button();
            btnMateriel = new Button();
            btnEns = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 119, 18);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 67);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.téléchargement__1_;
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnexit);
            panel2.Controls.Add(btndem);
            panel2.Controls.Add(btnMateriel);
            panel2.Controls.Add(btnEns);
            panel2.Location = new Point(234, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 532);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(295, 93);
            label3.Name = "label3";
            label3.Size = new Size(139, 27);
            label3.TabIndex = 10;
            label3.Text = "Vous etes :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(260, 27);
            label2.Name = "label2";
            label2.Size = new Size(212, 43);
            label2.TabIndex = 9;
            label2.Text = "Welcome !";
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
            btnexit.Location = new Point(309, 483);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(109, 30);
            btnexit.TabIndex = 8;
            btnexit.Text = "    Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // btndem
            // 
            btndem.BackColor = SystemColors.ButtonFace;
            btndem.Cursor = Cursors.Hand;
            btndem.FlatAppearance.BorderSize = 0;
            btndem.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            btndem.FlatStyle = FlatStyle.Flat;
            btndem.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndem.ForeColor = SystemColors.GrayText;
            btndem.Image = Properties.Resources.icons8_demand_50;
            btndem.ImageAlign = ContentAlignment.MiddleLeft;
            btndem.Location = new Point(216, 344);
            btndem.Name = "btndem";
            btndem.Size = new Size(316, 63);
            btndem.TabIndex = 4;
            btndem.Text = "Technicien";
            btndem.UseVisualStyleBackColor = false;
            btndem.Click += btndem_Click;
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
            btnMateriel.Location = new Point(219, 151);
            btnMateriel.Name = "btnMateriel";
            btnMateriel.Size = new Size(316, 63);
            btnMateriel.TabIndex = 5;
            btnMateriel.Text = "administrateur";
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
            btnEns.Location = new Point(216, 245);
            btnEns.Name = "btnEns";
            btnEns.Size = new Size(319, 63);
            btnEns.TabIndex = 3;
            btnEns.Text = "Enseignant";
            btnEns.UseVisualStyleBackColor = false;
            btnEns.Click += btnEns_Click;
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 695);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "welcome";
            Text = "welcome";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnexit;
        private Button btndem;
        private Button btnMateriel;
        private Button btnEns;
        private Label label2;
        private Label label3;
    }
}