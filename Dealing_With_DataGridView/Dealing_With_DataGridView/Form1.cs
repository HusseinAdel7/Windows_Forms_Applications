using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using OfficeOpenXml;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Dealing_With_DataGridView
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private DataGridViewPrintDocument dataGridViewPrintDocument;

        private BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
            InitializeDataGridView();
            dataGridView1.AllowUserToAddRows = false;
            printDocument.PrintPage += PrintDocument_PrintPage;
            dataGridViewPrintDocument = new DataGridViewPrintDocument(dataGridView1);
        }


        #region Loading Form And Setting The Header For DataGridView And Size For Them
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set The Header Text 
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[0].ReadOnly = true;

            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[1].ReadOnly = true;

            dataGridView1.Columns[2].Name = "Age";
            dataGridView1.Columns[2].HeaderText = "Age";
            dataGridView1.Columns[2].ReadOnly = true;

            dataGridView1.Columns[3].Name = "Address";
            dataGridView1.Columns[3].HeaderText = "Address";
            dataGridView1.Columns[3].ReadOnly = true;

            dataGridView1.Columns[4].Name = "Position";
            dataGridView1.Columns[4].HeaderText = "Position";
            dataGridView1.Columns[4].ReadOnly = true;

            dataGridView1.Columns[5].Name = "Salary";
            dataGridView1.Columns[5].HeaderText = "Salary";
            dataGridView1.Columns[5].ReadOnly = true;

            // Set Size For The Column In dataGridView1
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 198;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 100;
        }
        #endregion


        #region Styling dataGridView1 (Font, Size, and Color)
        private void InitializeDataGridView()
        {
            SetDataGridViewFont();
        }
        private void SetDataGridViewFont()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        #endregion


        #region Check Function Validation For TextBox Field
        public void check()
        {
            Validation obj = new Validation();
            string id = obj.IdError(txtId.Text);
            errorId.Text = id.ToString();

            string name = obj.NameError(txtName.Text);
            errorName.Text = name.ToString();

            string age = obj.AgeError(txtAge.Text);
            errorAge.Text = age.ToString();

            string address = obj.AddressError(txtAddress.Text);
            errorAddress.Text = address.ToString();

            string position = obj.AddressError(txtPosition.Text);
            errorPosition.Text = position.ToString();

            string salary = obj.SalaryError(txtSalary.Text);
            errorSalary.Text = salary.ToString();


        }
        #endregion


        #region Select An Employee And Show Its Data In The Text Boxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtAge.Text = selectedRow.Cells["Age"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                txtPosition.Text = selectedRow.Cells["Position"].Value.ToString();
                txtSalary.Text = selectedRow.Cells["Salary"].Value.ToString();
            }
        }
        #endregion


        #region Add New Employee (Add Button)
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtAge.Text == "" || txtAddress.Text == "" || txtPosition.Text == "" || txtSalary.Text == "")
            {
                MessageBox.Show("All Fields Must be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.BackColor = Color.LightGray;
                this.ForeColor = Color.Black;
            }
            else
            {
                check();
                if (!(errorId.Text == "" && errorName.Text == "" && errorAge.Text == "" && errorAddress.Text == "" && errorPosition.Text == "" && errorSalary.Text == ""))
                {
                }
                else
                {
                    dataGridView1.Rows.Add(new string[]
                           { txtId.Text,
                             txtName.Text,
                             txtAge.Text,txtAddress.Text,
                             txtPosition.Text,
                             txtSalary.Text
                           });
                    txtId.Text = "";
                    txtName.Text = "";
                    txtAge.Text = "";
                    txtAddress.Text = "";
                    txtPosition.Text = "";
                    txtSalary.Text = "";
                }
            }
        }
        #endregion


        #region Updating Data Using Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("There Are No Data To Update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = Color.LightGray;
                this.ForeColor = Color.Black;
            }
            else
            {
                check();
                if (txtId.Text == "" || txtName.Text == "" || txtAge.Text == "" || txtAddress.Text == "" || txtPosition.Text == "" || txtSalary.Text == "")
                {
                    MessageBox.Show("All Fields Must be Filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.BackColor = Color.LightGray;
                    this.ForeColor = Color.Black;
                }
                else
                {
                    if (!(errorId.Text == "" && errorName.Text == "" && errorAge.Text == "" && errorAddress.Text == "" && errorPosition.Text == "" && errorSalary.Text == ""))
                    {
                    }
                    else
                    {
                        DataGridViewRow selectedRow = dataGridView1.CurrentRow;
                        if (selectedRow != null)
                        {
                            selectedRow.Cells["Id"].Value = txtId.Text.ToString();
                            selectedRow.Cells["Name"].Value = txtName.Text.ToString();
                            selectedRow.Cells["Age"].Value = txtAge.Text.ToString();
                            selectedRow.Cells["Address"].Value = txtAddress.Text.ToString();
                            selectedRow.Cells["Position"].Value = txtPosition.Text.ToString();
                            selectedRow.Cells["Salary"].Value = txtSalary.Text.ToString();
                        }
                        txtId.Text = "";
                        txtName.Text = "";
                        txtAge.Text = "";
                        txtAddress.Text = "";
                        txtPosition.Text = "";
                        txtSalary.Text = "";
                    }
                }
            }
        }
        #endregion


        #region Rest The dataGridView1 (Clear All Content)
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("There Are No Data To Clear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = Color.LightGray;
                this.ForeColor = Color.Black;
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
        }
        #endregion


        #region Delete One Employee or More
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("There Are No Data To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = Color.LightGray;
                this.ForeColor = Color.Black;
            }
            else
            {
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                if (selectedRow != null)
                {
                    dataGridView1.Rows.RemoveAt(selectedRow.Index);
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Must Select One Row Or More To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.BackColor = Color.LightGray;
                    this.ForeColor = Color.Black;
                }
            }
        }
        #endregion


        #region Print The dataGridView1 Via Printer
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            dataGridViewPrintDocument.DrawDataGridView(e.Graphics);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("There Are No Data To Print", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = Color.LightGray;
                this.ForeColor = Color.Black;
            }
            else
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }
        #endregion


        #region Save The dataGridView1 As an Excel Sheet
        private void ExportDataGridViewToExcel(DataGridView dataGridView, ExcelWorksheet worksheet)
        {
            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount <= 0)
            {
                MessageBox.Show("There Are No Data To Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = Color.LightGray;
                this.ForeColor = Color.Black;
            }
            else
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                try
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (ExcelPackage excelPackage = new ExcelPackage())
                            {
                                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                                ExportDataGridViewToExcel(dataGridView1, worksheet);
                                File.WriteAllBytes(saveFileDialog.FileName, excelPackage.GetAsByteArray());
                            }
                            MessageBox.Show("Data saved to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


        #region Exit Function and Button
        private void Exit()
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do You Want To Exit !! ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Exit();

        }
        #endregion


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }
        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }
    }
}
