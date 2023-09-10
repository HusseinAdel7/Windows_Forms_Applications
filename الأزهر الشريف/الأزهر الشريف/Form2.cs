using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace الأزهر_الشريف
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredText = textBox2.Text;
            string enteredText1 = textBox1.Text;

            if (enteredText=="حسين" && enteredText1 =="12345678" )
            {
                // Hide the current form (Form1)
                this.Hide();

                // Create an instance of Form2 and show it
                Form1 form1 = new Form1();
                form1.ShowDialog();

                // Close Form1 when Form2 is closed (optional)
                this.Close();
            }
            else
            {
                MessageBox.Show("أسم المستخدم وكلمة السر خاطئة ");
            }
        }
    }
}
