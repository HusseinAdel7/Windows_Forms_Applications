using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Full_Registeration_Form
{
    public partial class Form1 : Form
    {
        bool flage=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Validation obj= new Validation();
            string fname= obj.FirstnameError(txtFname.Text);
            fnameError.Text= fname.ToString();
            string lname = obj.LastnameError(txtLname.Text);
            lnameError.Text = lname.ToString();
            string email = obj.EmailError(txtEmail.Text);
            emailError.Text = email.ToString();
            string password = obj.passwoedError(txtPassword.Text);
            passError.Text = password.ToString();
            string passwordConfirm = obj.passwoedConfirmationError(txtConfirmPassword.Text, txtPassword.Text);
            confirmPassError.Text = passwordConfirm.ToString();
            if (flage == false) genderError.Text = "Must Select";
            string mobile = obj.mobileError(txtMobile.Text);
            mobileError.Text = mobile.ToString();
            string address = obj.AddressError(txtAddress.Text);
            addressError.Text = address.ToString();
            if(fnameError.Text=="" && lnameError.Text == "" && emailError.Text == "" && passError.Text == "" && confirmPassError.Text == "" && genderError.Text == "" && birthdayError.Text == "" && mobileError.Text == "" && addressError.Text == "")
            {
                done.ForeColor = Color.Green;
                done.Text = "Thanks, Your Registration is Valid";
            }
            else
            {
                done.ForeColor= Color.Red;
                done.Text = "Sorry, Your Registration is not Valid";
            }

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '\0')
            {
                txtConfirmPassword.PasswordChar = '*';
            }
            else
            {
                txtConfirmPassword.PasswordChar = '\0';
            }
        }

        private void femal_CheckedChanged(object sender, EventArgs e)
        {
            if (femal.Checked)
            {
                genderError.Text = "";
                flage = true;
            }
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            if (male.Checked)
            {
                genderError.Text = "";
                flage = true;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker.Value != DateTime.MinValue)
            {
                birthdayError.Text = "";
            }
            else
            {
                birthdayError.Text = "Must Select";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtBirthday.Text = "";
            txtConfirmPassword.Text = "";
            txtEmail.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtMobile.Text = "";
            txtPassword.Text = "";
            femal.Checked = false;
            fnameError.Text = "";
            lnameError.Text = "";
            emailError.Text = "";
            passError.Text = "";
            confirmPassError.Text = "";
            genderError.Text = "";
            birthdayError.Text = "";
            mobileError.Text = "";
            addressError.Text = "";

        }
    }
}
