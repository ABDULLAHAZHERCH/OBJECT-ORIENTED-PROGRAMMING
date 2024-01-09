using System;
using System.Drawing;
using System.Windows.Forms;

namespace CH_CARS
{
    public partial class ClientMenu : Form
    {
        private Button currentButton;
        private Form activeForm;
        public ClientMenu()
        {
            InitializeComponent();
        }
        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            DisableButton();
            label1.Text = "HOME";
        }
        private void saleCarsbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.SaleCars(), sender);
        }
        private void RentCarsbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.RentCars(), sender);
        }
        private void BuyCarbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.BuyACar(), sender);
        }

        private void rentCarbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.RentACar(), sender);
        }

        private void bookBuybutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.BookBuy(), sender);
        }
        private void bookRentbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.BookRent(), sender);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            DialogResult result = MessageBox.Show("You Are Logging out", "CH_CARS", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Hide();
                FORMS.MainPage mainPage = new FORMS.MainPage();
                mainPage.Show();
            }

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.childPanel.Controls.Add(childForm);
            this.childPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(55, 149, 189);
                    ((Control)btnSender).BackColor = color;
                    ((Control)btnSender).ForeColor = Color.White;
                    panel2.BackColor = color;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control item in panel1.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    Color color = Color.FromArgb(58, 16, 120);
                    item.BackColor = color;
                    item.ForeColor = Color.White;
                    panel2.BackColor = color;
                }
            }
        }
        private void ClientMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
