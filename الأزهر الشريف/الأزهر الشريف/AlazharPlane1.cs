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
    public partial class AlazharPlane1 : UserControl
    {
        private int _choose;

        public AlazharPlane1()
        {
            InitializeComponent();
        }

        private void AlazharPlane1_Load(object sender, EventArgs e)
        {

        }



        #region Buttons

        private void Childern(object sender, EventArgs e)
        {
            _choose = 0;
            panel1.Enabled = true;
            panel2.Enabled = false;

            button2.BackColor = Color.FromArgb(224, 224, 224);
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button4.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _choose = 1;
            panel1.Enabled = true;
            panel2.Enabled = false;

            button1.BackColor = Color.FromArgb(224, 224, 224);
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _choose = 2;
            panel1.Enabled = true;
            panel2.Enabled = false;

            button2.BackColor = Color.FromArgb(224, 224, 224);
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _choose = 3;
            panel1.Enabled = true;
            panel2.Enabled = false;

            button2.BackColor = Color.FromArgb(224, 224, 224);
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button1.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _choose = 0;
            panel2.Enabled = true;
            panel1.Enabled = false;

            button1.BackColor = Color.FromArgb(0, 192, 192);
            button2.BackColor = Color.MediumSlateBlue;
            button3.BackColor = Color.GreenYellow;
            button4.BackColor = Color.FromArgb(255, 128, 128);

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty)
            {
                MessageBox.Show("من فضلك ادخل كل البيانات المتاحة امامك");
            }
            else
            {
                ActualPlan newForm = new ActualPlan(textBox1.Text, textBox2.Text, textBox4.Text, textBox5.Text, _choose);
                newForm.Show();
                this.Hide();
            }
        }



        #endregion



        #region TextBoxs

        #region Digit Function

        public string Digits(string numb)
        {
            char[] id = { '٩', '٨', '٧', '٦', '٥', '٤', '٣', '٢', '١', '٠' };
            string myStr = numb.ToString();
            char[] myStr1 = myStr.ToCharArray();
            List<char> result = new List<char>();

            foreach (char num in myStr1)
            {
                switch (num)
                {
                    case '.':
                        result.Add(',');
                        break;
                    case '0':
                        result.Add(id[9]);
                        break;
                    case '1':
                        result.Add(id[8]);
                        break;
                    case '2':
                        result.Add(id[7]);
                        break;
                    case '3':
                        result.Add(id[6]);
                        break;
                    case '4':
                        result.Add(id[5]);
                        break;
                    case '5':
                        result.Add(id[4]);
                        break;
                    case '6':
                        result.Add(id[3]);
                        break;
                    case '7':
                        result.Add(id[2]);
                        break;
                    case '8':
                        result.Add(id[1]);
                        break;
                    case '9':
                        result.Add(id[0]);
                        break;
                    default:
                        result.Add(num);
                        break;
                }
            }

            return new string(result.ToArray());
        }

        #endregion

        #region TextBox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            string arabicText = Digits(inputText);
            textBox1.Text = arabicText;
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region TextBox2
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is an English character (A-Z or a-z)
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                // Suppress the key press if it's an English character
                e.Handled = true;
            }
        }

        #endregion

        #region TextBox4
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is an English character (A-Z or a-z)
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                // Suppress the key press if it's an English character
                e.Handled = true;
            }
        }
        #endregion

        #region TextBox5

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Get the text from the TextBox
            string inputText = textBox5.Text;

            // Apply the conversion function
            string arabicText = Digits(inputText);

            // Set the TextBox's text to the converted Arabic text
            textBox5.Text = arabicText;

            // Move the cursor to the end of the text
            textBox5.SelectionStart = textBox5.Text.Length;

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Suppress the key press if it's not a digit or control key
                e.Handled = true;
            }
        }



        #endregion


        #endregion





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
