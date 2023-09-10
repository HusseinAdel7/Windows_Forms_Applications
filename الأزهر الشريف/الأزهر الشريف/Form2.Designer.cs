namespace الأزهر_الشريف
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel5 = new Panel();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            button8 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 830);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 707);
            label1.Name = "label1";
            label1.Size = new Size(173, 40);
            label1.TabIndex = 1;
            label1.Text = "تسجيل الدخول";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 239);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 429);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1077, 793);
            button1.Name = "button1";
            button1.Size = new Size(205, 69);
            button1.TabIndex = 9;
            button1.Text = "دخول";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(668, 599);
            panel5.Name = "panel5";
            panel5.Size = new Size(911, 81);
            panel5.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 0, 64);
            textBox1.Location = new Point(4, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(817, 78);
            textBox1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(845, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(668, 388);
            panel4.Name = "panel4";
            panel4.Size = new Size(911, 81);
            panel4.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(0, 0, 64);
            textBox2.Location = new Point(4, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(817, 78);
            textBox2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(845, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1404, 541);
            label5.Name = "label5";
            label5.Size = new Size(175, 55);
            label5.TabIndex = 4;
            label5.Text = "كلمة السر";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1345, 330);
            label4.Name = "label4";
            label4.Size = new Size(234, 55);
            label4.TabIndex = 5;
            label4.Text = "إسم المستخدم";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(810, 85);
            label3.Name = "label3";
            label3.Size = new Size(410, 93);
            label3.TabIndex = 6;
            label3.Text = "تسجيل الدخول";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(349, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1440, 51);
            panel2.TabIndex = 10;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Right;
            button8.BackColor = Color.Silver;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(1332, 3);
            button8.Name = "button8";
            button8.Size = new Size(45, 39);
            button8.TabIndex = 6;
            button8.Text = "—";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Right;
            button6.BackColor = Color.Silver;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Red;
            button6.Location = new Point(1383, 3);
            button6.Name = "button6";
            button6.Size = new Size(45, 41);
            button6.TabIndex = 5;
            button6.Text = "❌";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1789, 830);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox2;
        private Button button8;
        private Button button6;
    }
}