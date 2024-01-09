using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CH_CARS.FORMS
{
    public partial class Bill : Form
    {
        Bitmap memoryImages;
        public Bill()
        {
            InitializeComponent();
        }
        public Bill(string name, string price, string model, string company)
        {
            InitializeComponent();
            nameBox.Text = name;
            priceBox.Text = price;
            modelBox.Text = model;
            companyBox.Text = company;
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
            MessageBox.Show("PAY THE DUES TO GET THE CAR", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void CaptureScreen()
        {
            using (var myGraphics = CreateGraphics())
            {
                var s = this.Size;
                memoryImages = new Bitmap(s.Width, s.Height, myGraphics);
                using (var memoryGraphics = Graphics.FromImage(memoryImages))
                {
                    memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
                }
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var wScale = e.MarginBounds.Width / (float)memoryImages.Width;
            var hScale = e.MarginBounds.Height / (float)memoryImages.Height;
            var scale = wScale < hScale ? wScale : hScale;
            e.Graphics.ScaleTransform(scale, scale);
            e.Graphics.DrawImage(memoryImages, 0, 0);
        }
    }
}