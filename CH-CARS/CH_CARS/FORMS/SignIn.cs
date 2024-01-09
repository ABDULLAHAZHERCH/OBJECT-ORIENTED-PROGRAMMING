using CH_CARS.BL;
using CH_CARS.DL;
using System;
using System.Windows.Forms;

namespace CH_CARS.FORMS
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void signInBtn_Click_1(object sender, EventArgs e)
        {
            
            MUser user = signIn();
            if (user != null)
            {
                user = MUserDL.FindUserInList(user);
                if (user == null)
                    MessageBox.Show("Enter Valid Data", "CH_CARS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                else if (user.IsAdmin())
                {
                    this.Hide();
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                    MessageBox.Show("Logged In as ADMIN", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    ClientMenu clientMenu = new ClientMenu();
                    clientMenu.Show();
                    MessageBox.Show("Logged In as CUSTOMER", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearDataFromForm();
            }
        }
        private void signUpbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
        private MUser signIn()
        {
            string name = nameBox.Text;
            string password = passwordBox.Text;

            if (name != null && password != null)
            {
                MUser user = new MUser(name, password);
                return user;
            }
            else
                MessageBox.Show("Enter Valid Data", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ClearDataFromForm();
            return null;
        }
        private void ClearDataFromForm()
        {
            nameBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
        }
    }
}
