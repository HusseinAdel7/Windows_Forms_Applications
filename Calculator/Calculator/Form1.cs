using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_5
{
    public partial class Form1 : Form
    {
        int opp;
        decimal firstNumber, secondNumber, result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void RemoveZero(string num)
        {
            if (txtResult.Text == "0")
                txtResult.Text = num;
            else
                txtResult.Text += num;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RemoveZero("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RemoveZero("2");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveZero("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveZero("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoveZero("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RemoveZero("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RemoveZero("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RemoveZero("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RemoveZero("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            RemoveZero("0");
        }

        
        private void CalcResult(int opp)
        {
            switch (opp)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    txtResult.Text = result.ToString();
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    txtResult.Text = result.ToString();
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    txtResult.Text = result.ToString();
                    break;
                case 4:
                    result = firstNumber / secondNumber;
                    txtResult.Text = result.ToString();
                    break;
                default:
                    MessageBox.Show("Must Choose Operation");
                    break;
            }
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Trim() == string.Empty || txtResult.Text.Trim() == "0")
                MessageBox.Show("Please, Enter The First Number");
            firstNumber = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            opp = 1;

        }
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Trim() == string.Empty || txtResult.Text.Trim() == "0")
                MessageBox.Show("Please, Enter The First Number");
            firstNumber = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            opp = 4;

        }

        private void buttonMultipy_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Trim() == string.Empty || txtResult.Text.Trim() == "0")
                MessageBox.Show("Please, Enter The First Number");
            firstNumber = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            opp = 3;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            opp = 0;
            txtResult.Text = "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if(txtResult.Text!="0")
            {
                if(!txtResult.Text.Contains("."))
                    txtResult.Text += ".";
            }
                
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Trim() == string.Empty || txtResult.Text.Trim() == "0")
                MessageBox.Show("Please, Enter The First Number");
            firstNumber = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            opp = 2;

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            
            if (txtResult.Text.Trim() == string.Empty || txtResult.Text.Trim() == "0")
                MessageBox.Show("Please, Enter Second The Number");
            secondNumber= Convert.ToDecimal(txtResult.Text);
            CalcResult(opp);
        }


    }
}
