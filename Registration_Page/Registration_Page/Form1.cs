using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Page
{
    public partial class Form1 : Form
    {
        public bool flage1=false;
        public bool flage2 = false;
        public bool flage3 = false;
        public bool flage4 = false;
        public bool flage5 = false;
        public bool flage6 = false;




        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        #region Text Boxes (Name And Email)
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[A-Za-z]*$";
            if (Regex.IsMatch(txtName.Text, pattern))
            {
                if (!(txtName.Text.Trim() == string.Empty || txtName.Text.Length <= 5))
                {
                    if (txtName.Text.Length > 5)
                    {
                        txtErrorName.Text = "";
                        flage1 = true;
                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[A-Za-z0-9._%+-]+@gmail\.com$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                if (!(txtEmail.Text.Trim() == string.Empty || txtEmail.Text.Length <= 5))
                {
                    if (txtEmail.Text.Length > 5)
                    {
                        txtEmailError.Text = "";
                        flage2 = true;
                    }
                }
                else
                {
                    
                }
            }
            else
            {
                
            }
        }
        #endregion


        #region Radio Box (Gender)
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                GenderError.Text = "";
                flage3 = true;

            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                GenderError.Text = "";
                flage3 = true;
            }
        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                HoppiesError.Text = "";
                flage4 = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                HoppiesError.Text = "";
                flage5 = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                HoppiesError.Text = "";
                flage6 = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flage1 == false)
            {
                txtErrorName.Text = "Name more 6 Letters and Accepts Letters Only";
            }
            if (flage2 == false)
            {
                txtEmailError.Text = "Email Must be Like This : Email@gmail.com";

            }
            if (flage3 == false)
            {
                GenderError.Text = "Please Check Your Gender";
            }
            if (flage4 == false && flage5==false&&flage6==false)
            {
                HoppiesError.Text = "Please Check Your Hoppies";

            }


            if (flage1 == true && flage2 == true&& flage3==true && (flage4 == true || flage5 == true || flage6 == true))
            {

                txtErrorName.Text = "";
                txtEmailError.Text = "";
                GenderError.Text = "";
                HoppiesError.Text = "";
                done.Text = "Thank You, Your Registration Is Valid";
                done.ForeColor = Color.Green;
             

            }
            else
            {
                done.Text = "Sorry, Your Registration Is Not Valid";
                done.ForeColor= Color.Red;

            }
        }

        private void label55(object sender, EventArgs e)
        {

        }
    }
}
