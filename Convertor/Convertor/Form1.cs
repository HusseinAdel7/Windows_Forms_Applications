using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor
{
    public partial class Convertor : Form
    {
        decimal integerNumberValue;
        bool f1=false, f2=false, f3=false;
        public Convertor()
        {
            InitializeComponent();
        }
        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            bool valid = decimal.TryParse(txtValue.Text, out integerNumberValue);
        }
        private void txtResult_TextChanged(object sender, EventArgs e)
        {
        }

        private void Mtok_CheckedChanged(object sender, EventArgs e)
        {
            f1 = true;
        }
        private void metomi_CheckedChanged(object sender, EventArgs e)
        {
            f2 = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mitome_CheckedChanged(object sender, EventArgs e)
        {
            f3 = true;

        }

       

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (f1 == true)
            {
                f1 = false;
                txtResult.Text = (integerNumberValue / 1000).ToString();
               
            }
            if (f2 == true)
            {
                f2 = false;
                txtResult.Text = (integerNumberValue / 1609).ToString();
               
            }
            if (f3 == true)
            {
                f3 = false;
                txtResult.Text = (integerNumberValue * 1609).ToString();
                
            }
        }

        
    }
}
