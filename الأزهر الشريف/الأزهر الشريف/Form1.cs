namespace الأزهر_الشريف
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private int xOffset, yOffset;

        public Form1()
        {
            InitializeComponent();
            homePageApp1.Dock = DockStyle.Fill;
            alazharPlane12.Dock = DockStyle.Fill;
            alazharPlan21.Dock = DockStyle.Fill;
            contactUs1.Dock = DockStyle.Fill;
            settingsApp1.Dock = DockStyle.Fill;
            homePageApp2.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            Screen screen = Screen.PrimaryScreen;
            int screenWidth = screen.Bounds.Width;
            int screenHeight = screen.Bounds.Height;

            // Set the form size to fit the screen
            this.Size = new Size(screenWidth, screenHeight);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            homePageApp1.BringToFront();
            homePageApp2.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            alazharPlane12.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            alazharPlan21.BringToFront();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            contactUs1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                xOffset = e.X;
                yOffset = e.Y;
            }

        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {

            if (isDragging)
            {
                int newX = this.Left + e.X - xOffset;
                int newY = this.Top + e.Y - yOffset;
                this.Location = new System.Drawing.Point(newX, newY);
            }
        }

        private void Mouse_Up(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }

        }

        private void homePageApp2_Load(object sender, EventArgs e)
        {

        }

        private void contactUs1_Load(object sender, EventArgs e)
        {

        }
    }
}