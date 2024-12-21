namespace projet1
{
    partial class logintech
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
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            btnRe = new Button();
            btnexit = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 119, 18);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(227, 119, 18);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 67);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.téléchargement__1_;
            pictureBox1.Location = new Point(33, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(227, 119, 18);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(171, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 473);
            panel2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_user_48;
            pictureBox2.Location = new Point(104, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(367, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(534, 473);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(295, 34);
            label1.TabIndex = 0;
            label1.Text = "Bonjour technicien";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(btnRe);
            panel4.Controls.Add(btnexit);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(541, 120);
            panel4.Name = "panel4";
            panel4.Size = new Size(541, 470);
            panel4.TabIndex = 9;
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
            btnRe.Location = new Point(168, 370);
            btnRe.Name = "btnRe";
            btnRe.Size = new Size(109, 30);
            btnRe.TabIndex = 11;
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
            btnexit.Location = new Point(333, 370);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(109, 30);
            btnexit.TabIndex = 10;
            btnexit.Text = "    Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(265, 267);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 57);
            label4.Name = "label4";
            label4.Size = new Size(167, 27);
            label4.TabIndex = 6;
            label4.Text = "Saisie votre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 204);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 5;
            label3.Text = "password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 118);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 4;
            label2.Text = "Nom";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 202);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(291, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 1;
            // 
            // logintech
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 648);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "logintech";
            Text = "logintech";
            Load += logintech_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Button btnRe;
        private Button btnexit;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}