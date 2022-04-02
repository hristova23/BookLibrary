using BookLibrary.Services.Models.User;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookLibrary.Forms
{
    public partial class Account : Form
    {
        private UserListingServiceModel user;

        public Account(UserListingServiceModel user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            firstNameTxtBox.Text = user.FirstName;
            lastNameTxtBox.Text = user.LastName;
            emailNameTxtBox.Text = user.Email;

            oldPassTxtBox.Text = "";
            newPassTxtBox.Text = "";
            confirmPassTxtBox.Text = "";

            coverPictureBox.Image = null;
        }

        private void UploadCoverBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";

            if (open.ShowDialog() == DialogResult.OK)
            {
                var imagePath = open.FileName;
                coverPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Account_Load(sender,e);
        }
    }
}
