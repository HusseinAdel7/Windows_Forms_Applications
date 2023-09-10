namespace الأزهر_الشريف
{
    partial class ActualPlan2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualPlan2));
            panel3 = new Panel();
            button2 = new Button();
            label4 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            place2 = new Label();
            label3 = new Label();
            place3 = new Label();
            label9 = new Label();
            place = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 799);
            panel3.Name = "panel3";
            panel3.Size = new Size(1924, 256);
            panel3.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(21, 136);
            button2.Name = "button2";
            button2.Size = new Size(205, 69);
            button2.TabIndex = 13;
            button2.Text = "رجوع للخلف";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(972, 2);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(846, 230);
            label4.TabIndex = 15;
            label4.Text = resources.GetString("label4.Text");
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(21, 64);
            button1.Name = "button1";
            button1.Size = new Size(205, 69);
            button1.TabIndex = 14;
            button1.Text = "طباعة / حفظ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += printButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(0, 210);
            panel2.Name = "panel2";
            panel2.Size = new Size(1924, 601);
            panel2.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            dataGridView1.Location = new Point(69, 237);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1735, 346);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.CellValidated += Cell_Validated;
            // 
            // Column3
            // 
            Column3.HeaderText = "النسبة";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 95;
            // 
            // Column4
            // 
            Column4.HeaderText = "المشروعات\t";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 300;
            // 
            // Column5
            // 
            Column5.HeaderText = "طلاب";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 225;
            // 
            // Column6
            // 
            Column6.HeaderText = "طالبات";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 225;
            // 
            // Column7
            // 
            Column7.HeaderText = "مكان التنفيذ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 250;
            // 
            // Column8
            // 
            Column8.HeaderText = "موعد التنفيذ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 250;
            // 
            // Column9
            // 
            Column9.HeaderText = "باب أول";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 105;
            // 
            // Column10
            // 
            Column10.HeaderText = "باب ثاني";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 105;
            // 
            // Column11
            // 
            Column11.HeaderText = "إجمالي";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column12, Column13 });
            dataGridView2.Location = new Point(70, 14);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RightToLeft = RightToLeft.Yes;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1735, 217);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "البيان";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 655;
            // 
            // Column2
            // 
            Column2.HeaderText = "المبلغ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 185;
            // 
            // Column12
            // 
            Column12.HeaderText = "البيان";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 655;
            // 
            // Column13
            // 
            Column13.HeaderText = "المبلغ";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Width = 186;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(place2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(place3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(place);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1924, 204);
            panel1.TabIndex = 18;
            // 
            // place2
            // 
            place2.AutoSize = true;
            place2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            place2.Location = new Point(1194, 97);
            place2.Name = "place2";
            place2.Size = new Size(0, 28);
            place2.TabIndex = 23;
            place2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1741, 67);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 18;
            label3.Text = "إدارة رعاية الطلاب";
            // 
            // place3
            // 
            place3.AutoSize = true;
            place3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            place3.Location = new Point(1071, 166);
            place3.Name = "place3";
            place3.Size = new Size(0, 28);
            place3.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(1468, 137);
            label9.Name = "label9";
            label9.Size = new Size(299, 28);
            label9.TabIndex = 22;
            label9.Text = "     السلام عليكم ورحمة الله وبركاته";
            // 
            // place
            // 
            place.AutoSize = true;
            place.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            place.Location = new Point(1581, 38);
            place.Name = "place";
            place.RightToLeft = RightToLeft.Yes;
            place.Size = new Size(0, 28);
            place.TabIndex = 19;
            place.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1774, 9);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 20;
            label2.Text = "الأزهر الشريف";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ActualPlan2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ActualPlan2";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActualPlan2";
            WindowState = FormWindowState.Maximized;
            FormClosing += ActaulPlan_FormClosing;
            Load += ActualPlan2_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button2;
        private Label label4;
        private Button button1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label place2;
        private Label label3;
        private Label place3;
        private Label label9;
        private Label place;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}