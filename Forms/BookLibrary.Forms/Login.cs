using BookLibrary.Data;
using BookLibrary.Services.Implementations;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void ClearForm(object sender, EventArgs e)
        {
            foreach (TextBox txtBox in this.Controls.OfType<TextBox>())
            {
                txtBox.Clear();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string email = EmailTxtBox.Text;
            string password = PasswordTxtBox.Text;

            using var data = new BookLibraryDbContext();
            var userService = new UserService(data);

            var user = userService.SearchByEmail(email);//throw error if email do not exit
            string hashedPassword = userService.HashPassword(password);

            if (user != null &&
                user.FirstOrDefault().PasswordHash == hashedPassword)
            {
                //if successful
                this.Hide();
                Main homeForm = new Main();
                homeForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
            ClearForm(sender,e);
        }

        private void CreateAccountLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.ShowDialog();
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheckBox.Checked)
            {
                PasswordTxtBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTxtBox.PasswordChar = '*';
            }
        }
    }
}
