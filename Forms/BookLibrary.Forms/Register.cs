using BookLibrary.Data;
using BookLibrary.Data.Models;
using BookLibrary.Services.Implementations;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class Register : Form
    {
        public Register()
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

        private void LoginLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
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
                ConfirmPasswordTxtBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTxtBox.PasswordChar = '*';
                ConfirmPasswordTxtBox.PasswordChar = '*';
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTxtBox.Text;
            string lastName = LastNameTxtBox.Text;
            string email = EmailTxtBox.Text;
            string password = PasswordTxtBox.Text;
            string confirmPassword = ConfirmPasswordTxtBox.Text;

            using var data = new BookLibraryDbContext();
            var userService = new UserService(data);

            try
            {
                User createdUser = userService.Create(firstName, lastName, email, password, confirmPassword);
                LoginLbl_Click(sender,e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }

            ClearForm(sender, e);
        }
    }
}
