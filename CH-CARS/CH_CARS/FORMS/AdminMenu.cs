using System;
using System.Drawing;
using System.Windows.Forms;

namespace CH_CARS
{
    public partial class AdminMenu : Form
    {
        private Button currentButton;
        private Form activeForm;
        public AdminMenu()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {

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
        private void saleCarsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.SaleCars(), sender);
        }
        private void rentCarsButton_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FORMS.RentCars(), sender);
        }
        private void addSaleCarsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.AddSaleCars(), sender);
        }
        private void addRentCarsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.AddRentCars(), sender);
        }
        private void updateSaleCarsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.UpdateSaleCars(), sender);
        }
        private void updateRentCars_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.UpdateRentCars(), sender);
        }
        private void seeUsersbutton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FORMS.Users(), sender);
        }
        private void logoutButton_Click(object sender, EventArgs e)
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
