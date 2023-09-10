using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using OfficeOpenXml;

using System;
using System.Drawing;


using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;
using OfficeOpenXml.Core.ExcelPackage;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace الأزهر_الشريف
{

    public partial class ActualPlan : Form
    {

        public int StudentsCount;
        public string Year;
        public string InstituteName;
        public string PlaceName;
        string yearplus;
        public int chooson;
        string resultInSecondDGV;



        public string Digitts(string numb)
        {
            char[] id = { '9', '8', '7', '6', '5', '4', '3', '2', '1', '0' };
            string myStr = numb.ToString();
            char[] myStr1 = myStr.ToCharArray();
            List<char> result = new List<char>();

            foreach (char num in myStr1)
            {
                switch (num)
                {
                    case '.':
                        result.Add('.');
                        break;
                    case '٠':
                        result.Add(id[9]);
                        break;
                    case '١':
                        result.Add(id[8]);
                        break;
                    case '٢':
                        result.Add(id[7]);
                        break;
                    case '٣':
                        result.Add(id[6]);
                        break;
                    case '٤':
                        result.Add(id[5]);
                        break;
                    case '٥':
                        result.Add(id[4]);
                        break;
                    case '٦':
                        result.Add(id[3]);
                        break;
                    case '٧':
                        result.Add(id[2]);
                        break;
                    case '٨':
                        result.Add(id[1]);
                        break;
                    case '٩':
                        result.Add(id[0]);
                        break;
                    default:
                        result.Add(num);
                        break;
                }
            }

            return new string(result.ToArray());
        }

        public ActualPlan(string val1, string val2, string val3, string val4, int choo)
        {
            InitializeComponent();
            string convertedString = Digitts(val1);
            int intValue = int.Parse(convertedString);
            StudentsCount = intValue;
            InstituteName = val2;
            PlaceName = val3;
            Year = Digitts(val4);
            int tempyear = int.Parse(Year);
            int yearplusone = tempyear + 1;
            yearplus = Digitts(yearplusone.ToString());
            chooson = choo;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void StylingDataGridView2()
        {

            #region Design & Pro
            dataGridView2.RowTemplate.Height = 28;
            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView2.Columns["Column1"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView2.Columns["Column2"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView2.Columns["Column1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Column2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            #endregion

            place.Text = "";
            place.Text = " الإدارة المركزية لمنطقة " + PlaceName.ToString() + " " + "الأزهرية";
            place2.Text = " السيد صاحب الفضيلة /                      رئيس الإدارة المركزية لمنطقة " + PlaceName.ToString() + " " + " الأزهرية";




            double master = 0.0;
            if (chooson == 0)
            {
                string year1 = Digits(Year);
                string year2 = Digits(yearplus);

                place3.Text = " الرجاء اعتماد الخطة المقترحة لروضة معهد " + InstituteName.ToString() + " للعام الدراسي " + year1 + " / " + year2 + " لمجلس الأباء والمعليمين ";
                dataGridView2.Rows.Add("المتحصل هذا العام لعدد طلاب X ٥ جنيه", StudentsCount * 5);
                master = StudentsCount * 5;
            }
            else if (chooson == 1)
            {
                string year1 = Digits(Year);
                string year2 = Digits(yearplus);

                place3.Text = " الرجاء اعتماد الخطة المقترحة لمعهد " + InstituteName.ToString() + " للعام الدراسي " + year1 + " / " + year2 + " لمجلس الأباء والمعليمين ";
                dataGridView2.Rows.Add("المتحصل هذا العام لعدد طلاب X ١٠ جنيه", StudentsCount * 10);
                master = StudentsCount * 10;
            }
            else if (chooson == 2)
            {
                string year1 = Digits(Year);
                string year2 = Digits(yearplus);

                place3.Text = " الرجاء اعتماد الخطة المقترحة لمعهد " + InstituteName.ToString() + " للعام الدراسي " + year1 + " / " + year2 + " لمجلس الأباء والمعليمين ";
                dataGridView2.Rows.Add("المتحصل هذا العام لعدد طلاب X ١٥ جنيه", StudentsCount * 15);
                master = StudentsCount * 15;
            }
            else if (chooson == 3)
            {
                string year1 = Digits(Year);
                string year2 = Digits(yearplus);

                place3.Text = " الرجاء اعتماد الخطة المقترحة لمعهد " + InstituteName.ToString() + " للعام الدراسي " + year1 + " / " + year2 + " لمجلس الأباء والمعليمين ";
                dataGridView2.Rows.Add("المتحصل هذا العام لعدد طلاب X ٢٠ جنيه", StudentsCount * 20);
                master = StudentsCount * 20;
            }
            double discount1 = master * 0.15;
            dataGridView2.Rows.Add("خصم ١٥٪ حصة وزارة المالية", discount1.ToString("N2"));

            double rest1 = master - discount1;
            dataGridView2.Rows.Add("الباقي", rest1.ToString("N2"));

            double discount2 = rest1 * 0.10;
            dataGridView2.Rows.Add("خصم ١٠ ٪ حصة المنطقة + حصة المجلس الأعلي للأباء والمعلمين\t", discount2.ToString("N2"));

            double rest2 = rest1 - discount2;
            dataGridView2.Rows.Add("الباقي", rest2.ToString("N2"));

            double discount3 = rest2 * 0.05;
            dataGridView2.Rows.Add("٥ ٪ الخاصة بمكافئة العاملين بمجلس الأباء بالمعهد\t", discount3.ToString("N2"));

            double rest3 = rest2 - discount3;
            dataGridView2.Rows.Add("الباقي", rest3.ToString("N2"));

            double discount4 = rest3 * 0.40;
            resultInSecondDGV = discount4.ToString("N2");
            dataGridView2.Rows.Add("نسبة ال ٤٠ ٪ للأنشطة\t", discount4.ToString("N2"));

            double discount5 = rest3 * 0.60;
            dataGridView2.Rows.Add("نسبة ال ٦٠ ٪ للخدمات التعليمية\t", discount5.ToString("N2"));



        }
        public void StylingDataGridView1()
        {


            dataGridView1.RowTemplate.Height = 28; // Replace 40 with your desired
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView1.Columns["Column3"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView1.Columns["Column4"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView1.Columns["Column5"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView1.Columns["Column6"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView1.Columns["Column7"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView1.Columns["Column8"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView1.Columns["Column9"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView1.Columns["Column10"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView1.Columns["Column11"].HeaderCell.Style.Font = new Font("Arial", 15);

            // Center the header text for "Column1"
            dataGridView1.Columns["Column3"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Column4"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Column5"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Column6"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Column7"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Column8"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Column9"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Column10"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Column11"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;



            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.Columns[0].ReadOnly = true;


            dataGridView1.Rows.Add("١", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("٢", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("٣", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("٤", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("٥", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("٦", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("٧", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("٨", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("٩", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("١٠", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "الإجمالي", "", "", "", "", "", "", "");







        }
        private void ActualPlan_Load(object sender, EventArgs e)
        {
            #region cost




            #endregion
            Screen screen = Screen.PrimaryScreen;
            int screenWidth = screen.Bounds.Width;
            int screenHeight = screen.Bounds.Height;

            // Set the form size to fit the screen
            this.Size = new Size(screenWidth, screenHeight);
            panel1.Dock = DockStyle.Fill;
            this.Controls.Add(panel1);
            StylingDataGridView2();
            StylingDataGridView1();

        }

        private void Row_Enter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ClearSelection();

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Row_Enter2(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void Cell_Click1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the clicked cell
                DataGridViewCell clickedCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Highlight the cell's border by changing its border style
                clickedCell.Style.SelectionBackColor = Color.White; // Set the background color to highlight
                clickedCell.Style.SelectionForeColor = Color.Black; // Set the text color for contrast

                // Clear other selections
                dataGridView1.ClearSelection();
                clickedCell.Selected = true;
            }
        }









        #region Events
        private void Cell_Validating(object sender, DataGridViewCellValidatingEventArgs e)
        {



        }
        private void CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == 10 && e.ColumnIndex >= 2 && e.ColumnIndex <= 8)
            {
                e.Handled = true; // Prevent the default cell painting
                using (Brush backBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(backBrush, e.CellBounds);
                }
                e.Graphics.DrawString("", e.CellStyle.Font, Brushes.Black, e.CellBounds, StringFormat.GenericDefault);
            }
        }

        private void Cell_End_Edit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void Key_Press(object sender, KeyPressEventArgs e)
        {

        }
        #endregion




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

        private void Cell_Validated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8) // Replace with the actual column index
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string inputValue = cell.Value?.ToString(); // Get the cell's value

                // Check if the input is a valid integer
                if (int.TryParse(inputValue, out int numericValue))
                {
                    // Apply the Digits function to transform the numeric input to Arabic
                    string arabicNumber = Digits(numericValue.ToString());

                    // Clear the cell's existing value and set the converted Arabic number
                    cell.Value = arabicNumber;
                }
                else
                {
                    // If the input is not a valid integer, clear the cell's value
                    cell.Value = string.Empty;
                }
            }
            if (e.ColumnIndex == 1)
            {
                DataGridViewCell cell1 = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                string inputValue = cell1.Value?.ToString();

                // Check if the input contains only Arabic letters (i.e., an Arabic string)
                if (!Regex.IsMatch(inputValue, "^[\\p{IsArabic}]+$"))
                {
                    cell1.Value = string.Empty;
                }
            }
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                DataGridViewCell cell2 = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                string inputValue = cell2.Value?.ToString();

                // Check if the input contains characters other than English letters
                if (!Regex.IsMatch(inputValue, "^[^a-zA-Z]+$"))
                {
                    cell2.Value = string.Empty;
                }
            }
        }

        private void Cell_Begin_Edit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == 10)
            {
                e.Cancel = true; // Cancel the edit for all cells in this row
            }
        }

        private void Print_Pge(object sender, PrintPageEventArgs e)
        {

        }

        private int currentPage = 0;
        private Bitmap printBitmap;

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (currentPage == 0)
            {
                // Create a bitmap of the form's content
                printBitmap = new Bitmap(this.Width * 4, this.Height * 4); // Increase resolution
                this.DrawToBitmap(printBitmap, new Rectangle(0, 0, printBitmap.Width, printBitmap.Height));
            }

            // Calculate the portion of the form content to print on this page
            int startY = currentPage * e.PageBounds.Height;
            Rectangle sourceRect = new Rectangle(0, startY * 10, printBitmap.Width, e.PageBounds.Height * 10); // Increase resolution

            // Calculate the destination rectangle on the print page
            Rectangle destRect = new Rectangle(e.PageBounds.Left, e.PageBounds.Top, e.PageBounds.Width, e.PageBounds.Height);

            // Set the resolution for the graphics object
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            // Draw the portion of the form content on the print page
            graphics.DrawImage(printBitmap, destRect, sourceRect, GraphicsUnit.Pixel);

            currentPage++;

            // Continue printing if there are more pages
            e.HasMorePages = (currentPage * e.PageBounds.Height < printBitmap.Height);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                currentPage = 0;
                printDoc.Print();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActaulPlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                e.Cancel = true; // Cancel the form closing event
                Application.Exit(); // Close the entire application
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
