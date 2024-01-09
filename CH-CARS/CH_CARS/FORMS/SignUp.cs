using CH_CARS.BL;
using CH_CARS.DL;
using System;
using System.Windows.Forms;

namespace CH_CARS.FORMS
{
    public partial class SignUp : Form
    {
        string userFile = "users.txt";
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
        }
        private void signUpbtn_Click_1(object sender, EventArgs e)
        {
            MUser user = signUp();
            if (user != null)
            {
                if (MUserDL.UserExists(user))
                    MessageBox.Show("!! Error User Exists !!", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    MUserDL.AddToList(user);
                    MUserDL.StoreInFileUser();
                    MessageBox.Show("Signed Up Successfully", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ClearDataFromForm();
            }
        }

        private void signInbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }
        private MUser signUp()
        {
            string name = nameBox.Text;
            string password = passwordBox.Text;
            string role = roleComboBox.Text;

            bool validateName = CarDL.AlphabetValidation(name);
            bool validatePassword = CarDL.AlphabetValidation(password);

            if (validateName && validatePassword)
            {
                if (role == "ADMIN")
                {
                    if (MUserDL.AdminValidation(role))
                    {
                        MUser user = new MUser(name, password, role);
                        return user;
                    }
                    else
                        MessageBox.Show("ADMIN EXISTS - There can be only ONE ADMIN ", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (role == "USER")
                {
                    MUser user = new MUser(name, password, role);
                    return user;
                }
                else
                    MessageBox.Show("Error", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("You can only use alphabets", "CH_CARS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ClearDataFromForm();
            return null;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ClearDataFromForm()
        {
            nameBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
            roleComboBox.SelectedIndex = -1;
        }
    }
}
