using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace الأزهر_الشريف
{
    public partial class ActualPlan2 : Form
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

        public ActualPlan2(string val1, string val2, string val3, string val4, int choo)
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

        public void StylingDataGridView2()
        {


            #region Design & Pro
            dataGridView2.RowTemplate.Height = 28;
            dataGridView2.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridView2.Columns["Column1"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView2.Columns["Column2"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView2.Columns["Column12"].HeaderCell.Style.Font = new Font("Arial", 15);
            dataGridView2.Columns["Column13"].HeaderCell.Style.Font = new Font("Arial", 15);

            dataGridView2.Columns["Column1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Column2"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Column12"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Column13"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
            if (chooson == 2)
            {
                string year1 = Digits(Year);
                string year2 = Digits(yearplus);

                place3.Text = " الرجاء اعتماد الخطة المقترحة لمعهد " + InstituteName.ToString() + " للعام الدراسي " + year1 + " / " + year2 + " لمجلس الأباء والمعليمين ";
                dataGridView2.Rows.Add("المنتظر تحصيله عدد الطلاب X ٤ جنيه", StudentsCount * 15, "الإجمالي الكلي", "");
                master = StudentsCount * 15;
            }
            else if (chooson == 3)
            {
                string year1 = Digits(Year);
                string year2 = Digits(yearplus);

                place3.Text = " الرجاء اعتماد الخطة المقترحة لمعهد " + InstituteName.ToString() + " للعام الدراسي " + year1 + " / " + year2 + " لمجلس الأباء والمعليمين ";
                dataGridView2.Rows.Add("المنتظر تحصيله عدد الطلاب X ٥ جنيه", StudentsCount * 20, "الإجمالي الكلي", "");
                master = StudentsCount * 20;
            }


            double discount1 = master * 0.15;
            double rest1 = master - discount1;
            double discount2 = rest1 * 0.10;
            double rest2 = rest1 - discount2;
            double discount3 = rest2 * 0.05;
            double rest3 = rest2 - discount3;
            double discount4 = rest3 * 0.40;
            double discount5 = rest3 * 0.60;

            dataGridView2.Rows.Add("خصم ١٥٪ حصة وزارة المالية", discount1.ToString("N2"), "١٠ ٪ مطبوعات وأدوات خاصة بأنشطة الاتحاد", (master - discount1).ToString("N2"));
            dataGridView2.Rows.Add("خصم نسبة ١٥٪ وزارة المالية", discount2.ToString("N2"), "البا٩٠ ٪ الباقي أنشطة وبرامجقي", (master - discount1 - discount2).ToString("N2"));
            dataGridView2.Rows.Add("نسبة ٦٥ ٪ المخصصة للمعهد", discount3.ToString("N2"), "٪ باب ثاني", (master - discount1 - discount2 - discount3).ToString("N2"));
            dataGridView2.Rows.Add("نسبة ٢٠ ٪ مكافئات العاملين بالاتحاد بالمعهد", discount4.ToString("N2"), "٪ باب أول", discount5.ToString("N2"));
            dataGridView2.Rows.Add("المبلغ المتبقي", discount4.ToString("N2"), "نسبة ال ٦٠ ٪ للخدمات التعليمية", discount5.ToString("N2"));



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


            dataGridView1.Rows.Add("", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "", "", "", "", "", "-", "", "");
            dataGridView1.Rows.Add("", "الإجمالي", "", "", "", "", "", "", "");


        }




        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ActualPlan2_Load(object sender, EventArgs e)
        {
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


        private void ActaulPlan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                e.Cancel = true; // Cancel the form closing event
                Application.Exit(); // Close the entire application
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
            this.Hide();
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
    }
}
